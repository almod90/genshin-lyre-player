using System.Collections.Generic;
using WindowsInput.Native;

namespace GenshinLyrePlayer
{
    public static class MihoyoVirtualKeyMap
    {
        public static VirtualKeyCode GetKeyForTransposedNote(int note, int transpose)
        {
            return GetKeyForNote(note + transpose);
        }

        private static VirtualKeyCode GetKeyForNote(int note)
        {
            switch (note)
            {
                // C3
                case 48:
                    return VirtualKeyCode.VK_Z;
                case 50:
                    return VirtualKeyCode.VK_X;
                case 52:
                    return VirtualKeyCode.VK_C;
                case 53:
                    return VirtualKeyCode.VK_V;
                case 55:
                    return VirtualKeyCode.VK_B;
                case 57:
                    return VirtualKeyCode.VK_N;
                case 59:
                    return VirtualKeyCode.VK_M;
                
                // C4
                case 60:
                    return VirtualKeyCode.VK_A;
                case 62:
                    return VirtualKeyCode.VK_S;
                case 64:
                    return VirtualKeyCode.VK_D;
                case 65:
                    return VirtualKeyCode.VK_F;
                case 67:
                    return VirtualKeyCode.VK_G;
                case 69:
                    return VirtualKeyCode.VK_H;
                case 71:
                    return VirtualKeyCode.VK_J;
                
                case 72:
                    return VirtualKeyCode.VK_Q;
                case 74:
                    return VirtualKeyCode.VK_W;
                case 76:
                    return VirtualKeyCode.VK_E;
                case 77:
                    return VirtualKeyCode.VK_R;
                case 79:
                    return VirtualKeyCode.VK_T;
                case 81:
                    return VirtualKeyCode.VK_Y;
                case 83:
                    return VirtualKeyCode.VK_U;
            }

            return VirtualKeyCode.ESCAPE;
        }
    }
}