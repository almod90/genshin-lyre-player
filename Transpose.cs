using System;
using System.Windows.Forms;

namespace GenshinLyrePlayer
{
    public partial class Transpose : Form
    {
        private int _semitone = 0;
        public int Semitone
        {
            get => _semitone;
            private set
            {
                _semitone = value;
                uiTransposeSemitones.Value = _semitone;
                uiTransposeSemitonesValue.Text = $"{_semitone} semitones";
            }
        }
        public Transpose()
        {
            InitializeComponent();
        }

        private void uiTransposeSemitones_ValueChanged(object sender, EventArgs e)
        {
            Semitone = ((TrackBar)sender).Value;
        }

        private void uiTransposeReset_Click(object sender, EventArgs e)
        {
            Semitone = 0;
        }
    }
}
