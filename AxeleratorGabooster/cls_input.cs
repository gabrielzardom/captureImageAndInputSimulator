using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput;
using WindowsInput.Native;

namespace AxeleratorGabooster
{
    class cls_input
    {
        cls_coordenatesHandler coordenates;

        InputSimulator obj_inputSimulator = new InputSimulator();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        public const int MOUSEEVENTF_LEFTDOWN       = 0x00000002;
        public const int MOUSEEVENTF_LEFTUP         = 0x00000004;
        public const int MOUSEEVENTF_RIGHTDOWN      = 0x00000008;
        public const int MOUSEEVENTF_RIGHTUP        = 0x00000010;
        public void set_obj_coordenates(cls_coordenatesHandler newCoordenates)
        {
            coordenates = newCoordenates;
        }

        public void fun_void_pressKey(VirtualKeyCode VKC)
        {
            //obj_inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_D)
            obj_inputSimulator.Keyboard.KeyPress(VKC);
        }

        public void inp_mouseRC()
        {
            obj_inputSimulator.Mouse.RightButtonClick();
        }

        public void inp_mouseLC()
        {
            obj_inputSimulator.Mouse.LeftButtonClick();
        }

        public void inp_mouseTRC()
        {
            mouse_event(MOUSEEVENTF_RIGHTDOWN, System.Windows.Forms.Cursor.Position.X, System.Windows.Forms.Cursor.Position.Y, 0, 0);
            System.Threading.Thread.Sleep(2000);
            mouse_event(MOUSEEVENTF_RIGHTUP, System.Windows.Forms.Cursor.Position.X, System.Windows.Forms.Cursor.Position.Y, 0, 0);
        }

        public void inp_mouseMove(int int_x, int int_y, int int_screenW, int int_screenH)
        {
            obj_inputSimulator.Mouse.MoveMouseTo(65535 * Convert.ToDouble(int_x) / (int_screenW - 1), 65535 * Convert.ToDouble(int_y) / (int_screenH - 1));
        }

    }
}
