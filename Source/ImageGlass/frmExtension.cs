﻿/*
ImageGlass Project - Image viewer for Windows
Copyright (C) 2013 DUONG DIEU PHAP
Project homepage: http://imageglass.org

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
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ImageGlass;
using ImageGlass.Plugins;
using ImageGlass.Theme;
using ImageGlass.Services.Configuration;

namespace ImageGlass
{
    public partial class frmExtension : Form
    {
        public frmExtension()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Global.Plugins.ClosePlugins();
            this.Close();
        }

        private void frmExtension_Load(object sender, EventArgs e)
        {
            //Load config
            //Windows Bound (Position + Size)--------------------------------------------
            Rectangle rc = GlobalSetting.StringToRect(GlobalSetting.GetConfig(this.Name + ".WindowsBound",
                                                "280,125,840,500"));
            this.Bounds = rc;

            //windows state--------------------------------------------------------------
            string s = GlobalSetting.GetConfig(this.Name + ".WindowsState", "Normal");
            if (s == "Normal")
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (s == "Maximized")
            {
                this.WindowState = FormWindowState.Maximized;
            }

            //Apply Windows theme
            RenderTheme r = new RenderTheme();
            r.ApplyTheme(tvExtension);

            if (!System.IO.Directory.Exists(Application.StartupPath + @"\Plugins"))
            {
                System.IO.Directory.CreateDirectory(Application.StartupPath + @"\Plugins");
            }
            else
            {
                Global.Plugins.FindPlugins(Application.StartupPath + @"\Plugins");

                foreach (ImageGlass.Plugins.Types.AvailablePlugin p in Global.Plugins.AvailablePlugins)
                {
                    TreeNode n = new TreeNode(p.Instance.Name);
                    tvExtension.Nodes.Add(n);
                    n = null;

                }
            }

            //Load language:
            this.Text = GlobalSetting.LangPack.Items["frmExtension._Text"];
            lnkGetMoreExt.Text = GlobalSetting.LangPack.Items["frmExtension.lnkGetMoreExt"];
            tvExtension.Nodes[0].Text = GlobalSetting.LangPack.Items["frmExtension.Node0"];
            btnClose.Text = GlobalSetting.LangPack.Items["frmExtension.btnClose"];

        }

        private void tvExtension_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvExtension.SelectedNode != null)
            {
                ImageGlass.Plugins.Types.AvailablePlugin p = Global.Plugins.AvailablePlugins.Find(
                                          tvExtension.SelectedNode.Text);
                if (p != null)
                {
                    panExtension.Controls.Clear();
                    p.Instance.MainInterface.Dock = DockStyle.Fill;
                    panExtension.Controls.Add(p.Instance.MainInterface);
                }
                else
                {
                    panExtension.Controls.Clear();
                    panExtension.Controls.Add(lnkGetMoreExt);
                }
            }
        }

        private void lnkGetMoreExt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.imageglass.org/download/extensions");
            }
            catch { }
        }

        private void frmExtension_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Save config---------------------------------
            if (this.WindowState == FormWindowState.Normal)
            {
                //Windows Bound-------------------------------------------------------------------
                GlobalSetting.SetConfig(this.Name + ".WindowsBound", GlobalSetting.RectToString(this.Bounds));
            }

            //Windows State-------------------------------------------------------------------
            GlobalSetting.SetConfig(this.Name + ".WindowsState", this.WindowState.ToString());
        }
    }
}
