using System.Collections.Generic;
using WindowsInput.Native;

namespace GenshinLyrePlayer
{
    public static class MihoyoVirtualKeyMap
    {
        private static List<string> notesCollection;

        private static void BuildNotesCollection()
        {
            if (notesCollection != null) return;

            notesCollection = new List<string>();

            var items = new string[] { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
            for (int i = 1; i <= 6; i++)
            {
                foreach (var note in items)
                {
                    notesCollection.Add($"{note}{i}");
                }
                
            }
        }
        public static VirtualKeyCode GetKeyForTransposedNote(string note, int transpose)
        {
            if (transpose == 0) return GetKeyForNote(note);
            BuildNotesCollection();
            var i = notesCollection.IndexOf(note);
            try
            {
                note = notesCollection[i + transpose] ?? note;
            }
            catch
            {
                // Don't care
            }
            return GetKeyForNote(note);
        }

        private static VirtualKeyCode GetKeyForNote(string note)
        {
            switch (note)
            {
                case "C3":
                    return VirtualKeyCode.VK_Z;
                case "D3":
                    return VirtualKeyCode.VK_X;
                case "E3":
                    return VirtualKeyCode.VK_C;
                case "F3":
                    return VirtualKeyCode.VK_V;
                case "G3":
                    return VirtualKeyCode.VK_B;
                case "A3":
                    return VirtualKeyCode.VK_N;
                case "B3":
                    return VirtualKeyCode.VK_M;
                
                case "C4":
                    return VirtualKeyCode.VK_A;
                case "D4":
                    return VirtualKeyCode.VK_S;
                case "E4":
                    return VirtualKeyCode.VK_D;
                case "F4":
                    return VirtualKeyCode.VK_F;
                case "G4":
                    return VirtualKeyCode.VK_G;
                case "A4":
                    return VirtualKeyCode.VK_H;
                case "B4":
                    return VirtualKeyCode.VK_J;
                
                case "C5":
                    return VirtualKeyCode.VK_Q;
                case "D5":
                    return VirtualKeyCode.VK_W;
                case "E5":
                    return VirtualKeyCode.VK_E;
                case "F5":
                    return VirtualKeyCode.VK_R;
                case "G5":
                    return VirtualKeyCode.VK_T;
                case "A5":
                    return VirtualKeyCode.VK_Y;
                case "B5":
                    return VirtualKeyCode.VK_U;
            }

            return VirtualKeyCode.ESCAPE;
        }
    }
}