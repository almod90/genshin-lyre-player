using System;

namespace GenshinLyrePlayer
{
    public class TimedKeyEvent
    {
        public Keyboard.ScanCodeShort Key { get; set; }
        public TimeSpan Time { get; set; }

        public TimedKeyEvent()
        {
            
        }
    }
}