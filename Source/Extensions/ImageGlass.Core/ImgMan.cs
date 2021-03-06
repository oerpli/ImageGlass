﻿/*
 * imaeg - generic image utility in C#
 * Copyright (C) 2010  ed <tripflag@gmail.com>
 *
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License v2
 * (version 2) as published by the Free Software Foundation.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, refer to the following URL:
 * http://www.gnu.org/licenses/old-licenses/gpl-2.0.txt
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace ImageGlass.Core
{
    public class ImgMan
    {
        const int MAXQUE = 5;

        //string root;
        private List<Img> image; //luu danh sach img chua load
        private List<Img> queue; //load 1 so img vao bo nho
        public ImgFilter filter;
		//public int loadNext = 0;//load truoc vao hanh doi
        public bool imgError = false;
		
		public Bitmap ErrorImage()
        {
            return ImageGlass.Core.Properties.Resources.Image_Error;            
        }

        public ImgMan()
        {
            image = new List<Img>();
            queue = new List<Img>();
        }
		
        public ImgMan(string[] filenames)
        {
            //debug();
            //this.root = root;
            image = new List<Img>();
            queue = new List<Img>();

            foreach (string name in filenames)
			{
                image.Add(new Img(name));
			}

            filter = new ImgFilter();
            Thread loada = new Thread(new ThreadStart(Loader));
            loada.Priority = ThreadPriority.BelowNormal;
            loada.IsBackground = true;
            loada.Start();

            //Program.dbg("ImgMan instance created");
        }

        private Label lb;
        private void debug()
        {
            lb = new Label();
            lb.Visible = true;
            lb.Dock = DockStyle.Fill;
            Form fm = new Form();
            fm.Controls.Add(lb);
            fm.Size = new Size(320, 900);
            fm.TopMost = true;
            fm.Show();
            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Tick += new EventHandler(t_Tick);
            t.Interval = 100;
            t.Start();
        }
        void t_Tick(object sender, EventArgs e)
        {
            StringBuilder a = new StringBuilder();
            StringBuilder b = new StringBuilder();
            for (int i = 0; i < image.Count; i++)
            {
                if (image[i].IsFinished)
                {
                    a.AppendLine(i + " - " + image[i].GetFileName());
                }
            }
            for (int i = 0; i < queue.Count; i++)
            {
                b.AppendLine(i + " - " + queue[i].GetFileName());
            }
            lb.Text = System.DateTime.Now.Ticks +
                "\n\n" + a.ToString() +
                "\n\n" + b.ToString();
        }

        /// <summary>
        /// Returns image i, applying all configured enhancements
        /// </summary>
        /// <param name="i">The image to return</param>
        /// <returns>Image i</returns>
        public Image GetImage(int i)
        {
            // Start off with unloading excessive images
            for (int a = 0; a < i - 3; a++)
            {
                image[a].Dispose();
            }
            for (int a = i + 3; a < image.Count; a++)
            {
                image[a].Dispose();
            }

            // New filter settings?
            if (filter.hasChanged())
            { //ALTERNATIVE_CODE
                foreach (Img im in image)
                {
                    im.Dispose();
                }
            }

            queue.Clear();
            queue.Add(image[i]);
            Enqueue(i + 1);
            //enqueue(i + 2);
            Enqueue(i - 1);
            //enqueue(i - 2);

            while (!image[i].IsFinished)
                Thread.Sleep(1);
			
			if (image[i].IsFailed)
            {
                imgError = true;
                return new Bitmap(1, 1);//ImageGlass.Core.Properties.Resources.Image_Error);
            }
            else
            {
                imgError = false;                
                return (Image)image[i].Get();
            }
        }

        /// <summary>
        /// Enqueue image i at a lower priority (caching)
        /// </summary>
        /// <param name="i"></param>
        private void Enqueue(int i)
        {
            if (i < 0 || i >= image.Count) return;
            if (!image[i].IsFinished)
            {
                //foreach (Img j in queue)
                //if (image[i] == j) return;
                queue.Add(image[i]);
                //queue.Insert(1, image[i]);
            }
        }

        /// <summary>
        /// Worker thread; loads images.
        /// </summary>
        private void Loader()
        {
            while (true)
            {
                if (queue.Count > 0)
                {
                    Img i = queue[0];
                    queue.RemoveAt(0);
                    //Program.dbg("Loader requested on " + i.getName());
                    if (!i.IsFinished)
                    {
                        //i.load(root);
                        //Program.dbg("Loader executing on " + i.getName());
                        //i.load(root, filter); //ALTERNATIVE_CODE
                        i.Load(filter); //ALTERNATIVE_CODE
                        //i.set(filter.apply(i.get())); //ALTERNATIVE_CODE
                    }
                }
                else
                {
                    Thread.Sleep(10);
                }
            }
        }

        public int Length
        {
            get { return image.Count; }
            set { }
        }
        public string GetFileName(int i)
        {
            if (i < 0 || i > image.Count)
                return "";

            return image[i].GetFileName();
        }
        //public string getPath(int i)
        //{
        //    if (i < 0 || i > image.Count)
        //        return "";

        //    //return root + image[i].GetFileName();
        //    return image[i].GetFileName();
        //}
        public void SetFileName(int i, string s)
        {
            image[i].SetFileName(s);
        }
        public void Unload(int i)
        {
            if (image[i] != null)
                image[i].Dispose();
        }
        public void Remove(int i)
        {
            Unload(i);
            image.RemoveAt(i);
        }
		public void Dispose()
        {
            for (int i = 0; i < Length; i++)
            {
                Remove(i);
            }
            image.Clear();
            queue.Clear();
        }
    }
}
