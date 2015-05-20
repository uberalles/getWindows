/*
 * 
    getWindows - Manage opened Windows
    Copyright (C) 2015 uberalles - uber_alles999@yahoo.com

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WinProc.core.ui;

namespace getWindows.core.windows
{
    class WindowManager
    {
        private delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);
        private const int SWHIDE = 0;
        private const int SWSHOWNORMAL = 1;
        private const int SWSHOWMINIMIZED = 2;
        private const int SWSHOWMAXIMIZED = 3;

        [DllImport("user32.dll")]
        static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern int GetWindowTextLength(IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);

        public static WindowsList GetWindows
        {
            get
            {
                WindowsList _list = new WindowsList();
                try
                {
                    EnumWindows(delegate(IntPtr hWnd, IntPtr param)
                    {
                        int size = GetWindowTextLength(hWnd);
                        if (size++ > 0)
                        {
                            StringBuilder str = new StringBuilder(size);
                            GetWindowText(hWnd, str, str.Capacity);
                            if (String.IsNullOrEmpty(str.ToString()) == false)
                                _list.Add(new Window(hWnd, str.ToString()));
                        }
                        return true;
                    }, IntPtr.Zero);

                    return _list;
                }
                catch (Exception ex)
                {
                    InformUser.showError(ex.Message);
                    return _list;
                }
            }
        }

        public static Boolean MaximizeWindow(Window w)
        {
            return _handleWindow(w, SWSHOWMAXIMIZED);
        }

        public static Boolean MinimizeWindow(Window w)
        {
            return _handleWindow(w, SWSHOWMINIMIZED);
        }

        public static Boolean HideWindow(Window w)
        {
            return _handleWindow(w, SWHIDE);
        }

        public static Boolean NormalizeWindow(Window w)
        {
            return _handleWindow(w, SWSHOWNORMAL);
        }

        private static Boolean _handleWindow(Window w, int Cmd)
        {
            try
            {
                return ShowWindowAsync(w.Handle, Cmd);
            }
            catch (Exception ex)
            {
                InformUser.showError(ex.Message);
                return false;
            }
        }
    }
}
