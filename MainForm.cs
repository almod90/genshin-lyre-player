using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Melanchall.DryWetMidi.Core;
using Melanchall.DryWetMidi.Devices;
using Melanchall.DryWetMidi.Interaction;
using WindowsInput;
using WindowsInput.Native;

namespace GenshinLyrePlayer
{
    public partial class MainForm : Form
    {
        private string _lastMidiFile = "";
        private int _transposeFor = 0;

        private bool _isPlaying;

        private readonly InputSimulator _input;
        private readonly BackgroundWorker _worker;

        public MainForm()
        {
            InitializeComponent();

            _input = new InputSimulator();
            
            var hook = new GlobalKeyboardHook();

            hook.HookedKeys.Add(Keys.NumPad5);
            hook.HookedKeys.Add(Keys.NumPad6);

            hook.KeyDown += (sender, args) =>
            {
                switch (args.KeyCode)
                {
                    case Keys.NumPad5:
                        if (_worker.IsBusy) return;
                        _worker.RunWorkerAsync();
                        break;
                    case Keys.NumPad6:
                        _worker.CancelAsync();
                        break;
                }
            };
            
            _worker = new BackgroundWorker()
            {
                WorkerSupportsCancellation = true
            };
            
            _worker.DoWork += (sender, args) =>
            {
                Play();
            };

            uiHeader.BackColor = Color.FromArgb(100, Color.Black);
            uiFooter.BackColor = Color.FromArgb(150, Color.Black);
        }

        #region Moving window without header

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Helper_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        private void PlayNotesAsKeys(IEnumerable<Note> notes)
        {
            var keys = new List<VirtualKeyCode>();
            foreach (var note in notes)
            {
                var key = MihoyoVirtualKeyMap.GetKeyForTransposedNote(note.ToString(), _transposeFor);
                if (key != VirtualKeyCode.ESCAPE)
                {
                    keys.Add(key);
                }
            }

            if (keys.Count > 0) _input.Keyboard.KeyPress(keys.ToArray());
        }

        private void Play()
        {
            if (string.IsNullOrEmpty(_lastMidiFile))
            {
                SetStatus("Please load file first");
                return;
            }
            if (_isPlaying)
            {
                return;
            }

            _isPlaying = true;
            SetStatus("Playing");

            var _file = MidiFile.Read(_lastMidiFile);
            var _playback = _file.GetPlayback();

            _playback.NotesPlaybackStarted += (sender, args) =>
            {
                if (_worker.CancellationPending)
                {
                    _playback.Stop();
                }
                PlayNotesAsKeys(args.Notes);
            };

            _playback.Stopped += (sender, args) => { _isPlaying = false; SetStatus("Stopped"); };
            _playback.Finished += (sender, args) => { _isPlaying = false; SetStatus("Playback Completed");};

            _playback.Play();
        }

        private void uiClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uiLoadMidi_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog()
            {
                Filter = "*.mid|*.mid"
            };

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                _lastMidiFile = openFile.FileName;
                using (var transpose = new Transpose())
                {
                    _transposeFor = 0;
                    if (transpose.ShowDialog() == DialogResult.OK)
                    {
                        _transposeFor = transpose.Semitone;
                    }
                }
                Ready();
            }
        }

        private void Ready()
        {
            uiReady.Text = "V";
            uiReady.ForeColor = Color.Lime;
            uiReadyText.Text = $"MIDI Loaded [{Path.GetFileName(_lastMidiFile)}]";
        }

        private void SetStatus(string text)
        {
            if (uiStatusValue.InvokeRequired)
            {
                uiStatusValue.Invoke((MethodInvoker)delegate { uiStatusValue.Text = text; });
            }
            else
            {
                uiStatusValue.Text = text;
            }
        }

        private void uiOptions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon");
        }
    }
}