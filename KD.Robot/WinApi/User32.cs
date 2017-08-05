using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace KD.Robot.WinApi
{
    /// <summary>
    /// Contains methods from user32.dll
    /// </summary>
    public static class User32
    {
        /// <summary>
        /// Sets the Window as a foreground.
        /// </summary>
        /// <param name="hWnd"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        /// <summary>
        /// The ClientToScreen API converts the client-area coordinates of a specified point to screen coordinates.
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="lpPoint"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern bool ClientToScreen(IntPtr hWnd, ref Point lpPoint);

        /// <summary>
        /// The SetCursorPos API
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCursorPos(int x, int y);

        /// <summary>
        /// This function is useful to simulate mouse buttons and wheel event to screen.
        /// </summary>
        /// <param name="dwFlags"> Use MouseEventFlags </param>
        /// <param name="dx"></param>
        /// <param name="dy"></param>
        /// <param name="dwData"></param>
        /// <param name="dwExtraInfo"></param>
        [DllImport("user32.dll")]
        public static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, UIntPtr dwExtraInfo);
    }
}
