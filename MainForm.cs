using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Melanchall.DryWetMidi.Core;
using Melanchall.DryWetMidi.Devices;
using Melanchall.DryWetMidi.Interaction;
using WindowsInput;
using WindowsInput.Native;

namespace GenshinLyrePlayer
{
    public partial class Form1 : Form
    {
        private string _lastMidiFile = "";
        private Keyboard _keyboard = new Keyboard();
        private GlobalKeyboardHook _hook;

        private List<TimedKeyEvent> _events = new List<TimedKeyEvent>();

        private MidiFile _file;
        private Playback _playback;
        private bool _isPlaying = false;
        private InputSimulator _input;

        private BackgroundWorker _worker;

        public Form1()
        {
            InitializeComponent();

            _input = new InputSimulator();

            _hook = new GlobalKeyboardHook();
            
            _hook.HookedKeys.Add(Keys.NumPad5);
            _hook.HookedKeys.Add(Keys.NumPad6);

            _hook.KeyDown += (sender, args) =>
            {
                if (args.KeyCode == Keys.NumPad5)
                {
                    _worker.RunWorkerAsync();
                }
                if (args.KeyCode == Keys.NumPad6)
                {
                    _worker.CancelAsync();
                }
                
            };
            
            _worker = new BackgroundWorker()
            {
                WorkerSupportsCancellation = true
            };
            
            _worker.DoWork += PlayMidiFileInThread;
        }

        private void PlayMidiFileInThread(object sender, DoWorkEventArgs e)
        {
            Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog()
            {
                Filter = "*.mid|*.mid"
            };

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                _lastMidiFile = textBox1.Text = openFile.FileName;
                SetupMidiFile(_lastMidiFile);
            }
        }

        private void SetupMidiFile(string fileName)
        {
            _file = MidiFile.Read(fileName);
            /*_playback = _file.GetPlayback();
            
            _playback.NotesPlaybackStarted += (sender, args) =>
            {
                var note = args.Notes.First();
                _input.Keyboard.KeyPress(MihoyoMapOther.GetKeyForNote(note.ToString()));
                //PlayNotesAsKeys(args.Notes, false);
            };
            /*_playback.NotesPlaybackFinished += (sender, args) =>
            {
                PlayNotesAsKeys(args.Notes, true);
            };*/
            //_playback.Stopped += (sender, args) => { _isPlaying = false; };
            //_playback.Finished += (sender, args) => { _isPlaying = false; };
        }

        private void PlayNotesAsKeys(IEnumerable<Note> notes)
        {
            var keys = new List<VirtualKeyCode>();
            foreach (var note in notes)
            {
                var key = MihoyoMapOther.GetKeyForNote(note.ToString());
                /*if (key != Keyboard.ScanCodeShort.ESCAPE)
                {
                    keys.Add(key);
                    Debug.WriteLine(DateTime.Now.ToString() + " " + (isKeyUp ? "OFF" : "ON") + " " + key);
                }*/
                if (key != VirtualKeyCode.ESCAPE)
                {
                    keys.Add(key);
                }
            }

            if (keys.Count > 0) _input.Keyboard.KeyPress(keys.ToArray());
            //_keyboard.Send(keys.ToArray(), isKeyUp);
        }

        private void Play()
        {
            if (_isPlaying)
            {
                LogString("Already playing, wait till the end or stop");
                return;
            }

            //LogString("Playing");
            _isPlaying = true;

            _file = MidiFile.Read(_lastMidiFile);
            _playback = _file.GetPlayback();

            _playback.NotesPlaybackStarted += (sender, args) =>
            {
                if (_worker.CancellationPending)
                {
                    _playback.Stop();
                }
                var note = args.Notes.First();
                PlayNotesAsKeys(args.Notes);
                /*Debug.WriteLine(note.ToString());
                var t = new Thread(() =>
                {
                    PlayNotesAsKeys(args.Notes);
                    //_input.Keyboard.KeyPress(MihoyoMapOther.GetKeyForNote(note.ToString()));
                });
                t.Start();*/
                
                //PlayNotesAsKeys(args.Notes, false);
            };
            /*_playback.NotesPlaybackFinished += (sender, args) =>
            {
                PlayNotesAsKeys(args.Notes, true);
            };*/
            _playback.Stopped += (sender, args) => { _isPlaying = false; };
            _playback.Finished += (sender, args) => { _isPlaying = false; };

            _playback.Play();
        }

        private IEnumerable<Note> GetMidiNotes(string fileName)
        {
            var file = MidiFile.Read(fileName);
            return file.GetNotes();
        }

        public void LogString(string text)
        {
            richTextBox1.Text = richTextBox1.Text.Insert(0, $"{text}\r\n");
        }
    }
}