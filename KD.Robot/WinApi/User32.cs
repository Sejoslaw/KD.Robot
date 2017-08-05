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
    }
}
