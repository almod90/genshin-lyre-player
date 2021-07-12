using System.Dynamic;

namespace GenshinLyrePlayer
{
    public class MihoyoMap
    {
        public static Keyboard.ScanCodeShort GetKeyForNote(string note)
        {
            switch (note)
            {
                case "C3":
                    return Keyboard.ScanCodeShort.KEY_Z;
                case "D3":
                    return Keyboard.ScanCodeShort.KEY_X;
                case "E3":
                    return Keyboard.ScanCodeShort.KEY_C;
                case "F3":
                    return Keyboard.ScanCodeShort.KEY_V;
                case "G3":
                    return Keyboard.ScanCodeShort.KEY_B;
                case "A3":
                    return Keyboard.ScanCodeShort.KEY_N;
                case "B3":
                    return Keyboard.ScanCodeShort.KEY_M;
                
                case "C4":
                    return Keyboard.ScanCodeShort.KEY_A;
                case "D4":
                    return Keyboard.ScanCodeShort.KEY_S;
                case "E4":
                    return Keyboard.ScanCodeShort.KEY_D;
                case "F4":
                    return Keyboard.ScanCodeShort.KEY_F;
                case "G4":
                    return Keyboard.ScanCodeShort.KEY_G;
                case "A4":
                    return Keyboard.ScanCodeShort.KEY_H;
                case "B4":
                    return Keyboard.ScanCodeShort.KEY_J;
                
                case "C5":
                    return Keyboard.ScanCodeShort.KEY_Q;
                case "D5":
                    return Keyboard.ScanCodeShort.KEY_W;
                case "E5":
                    return Keyboard.ScanCodeShort.KEY_E;
                case "F5":
                    return Keyboard.ScanCodeShort.KEY_R;
                case "G5":
                    return Keyboard.ScanCodeShort.KEY_T;
                case "A5":
                    return Keyboard.ScanCodeShort.KEY_Y;
                case "B5":
                    return Keyboard.ScanCodeShort.KEY_U;
            }

            return Keyboard.ScanCodeShort.ESCAPE;
        }
    }
}