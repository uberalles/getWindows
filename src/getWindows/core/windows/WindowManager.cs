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
using System.Text;
using System.Threading.Tasks;
using WinProc.core.ui;

namespace getWindows.core.windows
{
    class WindowManager
    {
        public static WindowsList GetWindows
        {
            get
            {
                WindowsList _list = new WindowsList();

                try
                {

                    return _list;
                }
                catch (Exception ex)
                {
                    InformUser.showError(ex.Message);
                    return _list;
                }
            }
        }

        public static Boolean MaximizeWindow(int handle)
        {
            try
            {
                
                return true;
            }
            catch (Exception ex)
            {
                InformUser.showError(ex.Message);
                return false;
            }
        }

        public static Boolean MinimizeWindow(int handle)
        {
            try
            {

                return true;
            }
            catch (Exception ex)
            {
                InformUser.showError(ex.Message);
                return false;
            }
        }

        public static Boolean HideWindow(int handle)
        {
            try
            {

                return true;
            }
            catch (Exception ex)
            {
                InformUser.showError(ex.Message);
                return false;
            }
        }
    }
}
