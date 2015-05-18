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

using getWindows.core.windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinProc.core.ui;

namespace getWindows.core.ui.forms
{
    public partial class mainForm : Form
    {
        private WindowsList _list;

        public mainForm()
        {
            InitializeComponent();
            _list = WindowManager.GetWindows;
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            aboutForm about = new aboutForm();
            about.ShowDialog();
            about.Dispose();
            about = null;
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            foreach (Window w in _list)
            {
                ListViewItem item = new ListViewItem(new String[] { w.Handle.ToInt32().ToString(), w.Title });
                item.Tag = w;
                winlist.Items.Add(item);
                counter.Text = winlist.Items.Count + " windows.";
            }
        }

        private void minWindowMenuItem_Click(object sender, EventArgs e)
        {
            if (winlist.SelectedItems.Count == 1)
            {
                WindowManager.MinimizeWindow((Window)winlist.SelectedItems[0].Tag);
            }
        }

        private void maxWindowMenuItem_Click(object sender, EventArgs e)
        {
            if (winlist.SelectedItems.Count == 1)
            {
                WindowManager.MaximizeWindow((Window)winlist.SelectedItems[0].Tag);
            }
        }

        private void hideWindowMenuItem_Click(object sender, EventArgs e)
        {
            if (winlist.SelectedItems.Count == 1)
            {
                WindowManager.HideWindow((Window)winlist.SelectedItems[0].Tag);
            }
        }

        private void showWindowNormalMenuItem_Click(object sender, EventArgs e)
        {
            if (winlist.SelectedItems.Count == 1)
            {
                WindowManager.NormalizeWindow((Window)winlist.SelectedItems[0].Tag);
            }
        }

        private void popupMenu_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                if (winlist.SelectedItems.Count == 1)
                {
                    minWindowMenuItem.Visible = true;
                    maxWindowMenuItem.Visible = true;
                    hideWindowMenuItem.Visible = true;
                    showWindowNormalMenuItem.Visible = true;
                }
                else
                {
                    minWindowMenuItem.Visible = false;
                    maxWindowMenuItem.Visible = false;
                    hideWindowMenuItem.Visible = false;
                    showWindowNormalMenuItem.Visible = false;
                }
            }
            catch (Exception ex)
            {
                InformUser.showError(ex.Message);
            }
        }

        private void winlist_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    Point pt = popupMenu.PointToScreen(e.Location);
                    popupMenu.Show(pt);
                }
            }
            catch (Exception ex)
            {
                InformUser.showError(ex.Message);
            }
        }
    }
}
