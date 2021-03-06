﻿namespace ImageGlass
{
    partial class frmAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblComponent = new System.Windows.Forms.Label();
            this.lblReferences = new System.Windows.Forms.Label();
            this.panInfo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkCheckUpdate = new System.Windows.Forms.LinkLabel();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.lnkFacebook = new System.Windows.Forms.LinkLabel();
            this.lnkProjectPage = new System.Windows.Forms.LinkLabel();
            this.lnkIGHomepage = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.lnkEmail = new System.Windows.Forms.LinkLabel();
            this.lblInfoContact = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.panComponent = new System.Windows.Forms.Panel();
            this.fileList1 = new ImageGlass.FileList.FileList();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSlogant = new System.Windows.Forms.Label();
            this.panReferences = new System.Windows.Forms.Panel();
            this.txtReferences = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSoftwareUpdate = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panInfo.SuspendLayout();
            this.panComponent.SuspendLayout();
            this.panReferences.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(176)))));
            this.lblInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(12, 94);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(139, 40);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Tag = "1";
            this.lblInfo.Text = "Info";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInfo.Click += new System.EventHandler(this.lblMenu_Click);
            this.lblInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblMenu_MouseDown);
            this.lblInfo.MouseEnter += new System.EventHandler(this.lblMenu_MouseEnter);
            this.lblInfo.MouseLeave += new System.EventHandler(this.lblMenu_MouseLeave);
            this.lblInfo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblMenu_MouseUp);
            // 
            // lblComponent
            // 
            this.lblComponent.BackColor = System.Drawing.Color.Silver;
            this.lblComponent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblComponent.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblComponent.ForeColor = System.Drawing.Color.White;
            this.lblComponent.Location = new System.Drawing.Point(157, 94);
            this.lblComponent.Name = "lblComponent";
            this.lblComponent.Size = new System.Drawing.Size(139, 40);
            this.lblComponent.TabIndex = 2;
            this.lblComponent.Tag = "0";
            this.lblComponent.Text = "Components";
            this.lblComponent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblComponent.Click += new System.EventHandler(this.lblMenu_Click);
            this.lblComponent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblMenu_MouseDown);
            this.lblComponent.MouseEnter += new System.EventHandler(this.lblMenu_MouseEnter);
            this.lblComponent.MouseLeave += new System.EventHandler(this.lblMenu_MouseLeave);
            this.lblComponent.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblMenu_MouseUp);
            // 
            // lblReferences
            // 
            this.lblReferences.BackColor = System.Drawing.Color.Silver;
            this.lblReferences.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReferences.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblReferences.ForeColor = System.Drawing.Color.White;
            this.lblReferences.Location = new System.Drawing.Point(302, 94);
            this.lblReferences.Name = "lblReferences";
            this.lblReferences.Size = new System.Drawing.Size(139, 40);
            this.lblReferences.TabIndex = 3;
            this.lblReferences.Tag = "0";
            this.lblReferences.Text = "References";
            this.lblReferences.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReferences.Click += new System.EventHandler(this.lblMenu_Click);
            this.lblReferences.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblMenu_MouseDown);
            this.lblReferences.MouseEnter += new System.EventHandler(this.lblMenu_MouseEnter);
            this.lblReferences.MouseLeave += new System.EventHandler(this.lblMenu_MouseLeave);
            this.lblReferences.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblMenu_MouseUp);
            // 
            // panInfo
            // 
            this.panInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panInfo.AutoScroll = true;
            this.panInfo.BackColor = System.Drawing.Color.White;
            this.panInfo.Controls.Add(this.label1);
            this.panInfo.Controls.Add(this.lnkCheckUpdate);
            this.panInfo.Controls.Add(this.lblUpdate);
            this.panInfo.Controls.Add(this.lnkFacebook);
            this.panInfo.Controls.Add(this.lnkProjectPage);
            this.panInfo.Controls.Add(this.lnkIGHomepage);
            this.panInfo.Controls.Add(this.label2);
            this.panInfo.Controls.Add(this.linkLabel4);
            this.panInfo.Controls.Add(this.linkLabel2);
            this.panInfo.Controls.Add(this.lnkEmail);
            this.panInfo.Controls.Add(this.lblInfoContact);
            this.panInfo.Controls.Add(this.lblCopyright);
            this.panInfo.Controls.Add(this.lblVersion);
            this.panInfo.Location = new System.Drawing.Point(12, 138);
            this.panInfo.Name = "panInfo";
            this.panInfo.Size = new System.Drawing.Size(594, 385);
            this.panInfo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Logo designer: Nguyễn Quốc Tuấn";
            // 
            // lnkCheckUpdate
            // 
            this.lnkCheckUpdate.AutoSize = true;
            this.lnkCheckUpdate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lnkCheckUpdate.LinkArea = new System.Windows.Forms.LinkArea(0, 99);
            this.lnkCheckUpdate.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkCheckUpdate.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(131)))), ((int)(((byte)(244)))));
            this.lnkCheckUpdate.Location = new System.Drawing.Point(48, 356);
            this.lnkCheckUpdate.Name = "lnkCheckUpdate";
            this.lnkCheckUpdate.Size = new System.Drawing.Size(120, 23);
            this.lnkCheckUpdate.TabIndex = 15;
            this.lnkCheckUpdate.TabStop = true;
            this.lnkCheckUpdate.Text = "» Check for update";
            this.lnkCheckUpdate.UseCompatibleTextRendering = true;
            this.lnkCheckUpdate.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(131)))), ((int)(((byte)(244)))));
            this.lnkCheckUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCheckUpdate_LinkClicked);
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Underline);
            this.lblUpdate.Location = new System.Drawing.Point(19, 328);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(118, 19);
            this.lblUpdate.TabIndex = 13;
            this.lblUpdate.Text = "Software updates:";
            // 
            // lnkFacebook
            // 
            this.lnkFacebook.AutoSize = true;
            this.lnkFacebook.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lnkFacebook.LinkArea = new System.Windows.Forms.LinkArea(10, 99);
            this.lnkFacebook.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkFacebook.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(131)))), ((int)(((byte)(244)))));
            this.lnkFacebook.Location = new System.Drawing.Point(48, 301);
            this.lnkFacebook.Name = "lnkFacebook";
            this.lnkFacebook.Size = new System.Drawing.Size(307, 23);
            this.lnkFacebook.TabIndex = 12;
            this.lnkFacebook.TabStop = true;
            this.lnkFacebook.Text = "Facebook: https://www.facebook.com/ImageGlass";
            this.lnkFacebook.UseCompatibleTextRendering = true;
            this.lnkFacebook.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(131)))), ((int)(((byte)(244)))));
            this.lnkFacebook.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkFacebook_LinkClicked);
            // 
            // lnkProjectPage
            // 
            this.lnkProjectPage.AutoSize = true;
            this.lnkProjectPage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lnkProjectPage.LinkArea = new System.Windows.Forms.LinkArea(8, 99);
            this.lnkProjectPage.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkProjectPage.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(131)))), ((int)(((byte)(244)))));
            this.lnkProjectPage.Location = new System.Drawing.Point(48, 278);
            this.lnkProjectPage.Name = "lnkProjectPage";
            this.lnkProjectPage.Size = new System.Drawing.Size(261, 23);
            this.lnkProjectPage.TabIndex = 11;
            this.lnkProjectPage.TabStop = true;
            this.lnkProjectPage.Text = "Source: http://www.imageglass.org/source";
            this.lnkProjectPage.UseCompatibleTextRendering = true;
            this.lnkProjectPage.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(131)))), ((int)(((byte)(244)))));
            this.lnkProjectPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkProjectPage_LinkClicked);
            // 
            // lnkIGHomepage
            // 
            this.lnkIGHomepage.AutoSize = true;
            this.lnkIGHomepage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lnkIGHomepage.LinkArea = new System.Windows.Forms.LinkArea(22, 99);
            this.lnkIGHomepage.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkIGHomepage.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(131)))), ((int)(((byte)(244)))));
            this.lnkIGHomepage.Location = new System.Drawing.Point(48, 255);
            this.lnkIGHomepage.Name = "lnkIGHomepage";
            this.lnkIGHomepage.Size = new System.Drawing.Size(278, 23);
            this.lnkIGHomepage.TabIndex = 10;
            this.lnkIGHomepage.TabStop = true;
            this.lnkIGHomepage.Text = "ImageGlass home page: www.imageglass.org";
            this.lnkIGHomepage.UseCompatibleTextRendering = true;
            this.lnkIGHomepage.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(131)))), ((int)(((byte)(244)))));
            this.lnkIGHomepage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkIGHomepage_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Underline);
            this.label2.Location = new System.Drawing.Point(19, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Website: ";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.linkLabel4.LinkArea = new System.Windows.Forms.LinkArea(7, 23);
            this.linkLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel4.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(131)))), ((int)(((byte)(244)))));
            this.linkLabel4.Location = new System.Drawing.Point(48, 200);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(156, 23);
            this.linkLabel4.TabIndex = 7;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Phone: +84 167 4710360";
            this.linkLabel4.UseCompatibleTextRendering = true;
            this.linkLabel4.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(131)))), ((int)(((byte)(244)))));
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.linkLabel2.LinkArea = new System.Windows.Forms.LinkArea(7, 23);
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(131)))), ((int)(((byte)(244)))));
            this.linkLabel2.Location = new System.Drawing.Point(48, 177);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(94, 23);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Skype: d2phap";
            this.linkLabel2.UseCompatibleTextRendering = true;
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(131)))), ((int)(((byte)(244)))));
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // lnkEmail
            // 
            this.lnkEmail.AutoSize = true;
            this.lnkEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lnkEmail.LinkArea = new System.Windows.Forms.LinkArea(7, 23);
            this.lnkEmail.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkEmail.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(131)))), ((int)(((byte)(244)))));
            this.lnkEmail.Location = new System.Drawing.Point(48, 154);
            this.lnkEmail.Name = "lnkEmail";
            this.lnkEmail.Size = new System.Drawing.Size(166, 23);
            this.lnkEmail.TabIndex = 4;
            this.lnkEmail.TabStop = true;
            this.lnkEmail.Text = "Email: d2phap@gmail.com";
            this.lnkEmail.UseCompatibleTextRendering = true;
            this.lnkEmail.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(131)))), ((int)(((byte)(244)))));
            this.lnkEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEmail_LinkClicked);
            // 
            // lblInfoContact
            // 
            this.lblInfoContact.AutoSize = true;
            this.lblInfoContact.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Underline);
            this.lblInfoContact.Location = new System.Drawing.Point(19, 126);
            this.lblInfoContact.Name = "lblInfoContact";
            this.lblInfoContact.Size = new System.Drawing.Size(60, 19);
            this.lblInfoContact.TabIndex = 2;
            this.lblInfoContact.Text = "Contact:";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCopyright.Location = new System.Drawing.Point(19, 49);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(292, 38);
            this.lblCopyright.TabIndex = 1;
            this.lblCopyright.Text = "Copyright © 2010-[xxxx] by Dương Diệu Pháp\r\nAll rights reserved.";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblVersion.Location = new System.Drawing.Point(19, 16);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(108, 21);
            this.lblVersion.TabIndex = 0;
            this.lblVersion.Text = "Version: [xxxx]";
            // 
            // panComponent
            // 
            this.panComponent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panComponent.AutoScroll = true;
            this.panComponent.Controls.Add(this.fileList1);
            this.panComponent.Location = new System.Drawing.Point(554, 36);
            this.panComponent.MinimumSize = new System.Drawing.Size(688, 385);
            this.panComponent.Name = "panComponent";
            this.panComponent.Size = new System.Drawing.Size(688, 385);
            this.panComponent.TabIndex = 6;
            this.panComponent.Visible = false;
            // 
            // fileList1
            // 
            this.fileList1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileList1.BackColor = System.Drawing.Color.Transparent;
            this.fileList1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileList1.Location = new System.Drawing.Point(0, 0);
            this.fileList1.Name = "fileList1";
            this.fileList1.Size = new System.Drawing.Size(688, 385);
            this.fileList1.TabIndex = 0;
            this.fileList1.Title = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(131)))), ((int)(((byte)(238)))));
            this.label4.Location = new System.Drawing.Point(79, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "ImageGlass";
            // 
            // lblSlogant
            // 
            this.lblSlogant.AutoSize = true;
            this.lblSlogant.BackColor = System.Drawing.Color.Transparent;
            this.lblSlogant.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.lblSlogant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.lblSlogant.Location = new System.Drawing.Point(82, 49);
            this.lblSlogant.Name = "lblSlogant";
            this.lblSlogant.Size = new System.Drawing.Size(232, 20);
            this.lblSlogant.TabIndex = 8;
            this.lblSlogant.Text = "Free and open source image viewer";
            // 
            // panReferences
            // 
            this.panReferences.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panReferences.AutoScroll = true;
            this.panReferences.BackColor = System.Drawing.Color.White;
            this.panReferences.Controls.Add(this.txtReferences);
            this.panReferences.Location = new System.Drawing.Point(466, 114);
            this.panReferences.Name = "panReferences";
            this.panReferences.Size = new System.Drawing.Size(594, 385);
            this.panReferences.TabIndex = 16;
            this.panReferences.Visible = false;
            // 
            // txtReferences
            // 
            this.txtReferences.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReferences.BackColor = System.Drawing.Color.White;
            this.txtReferences.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReferences.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtReferences.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtReferences.Location = new System.Drawing.Point(19, 16);
            this.txtReferences.Name = "txtReferences";
            this.txtReferences.ReadOnly = true;
            this.txtReferences.Size = new System.Drawing.Size(564, 354);
            this.txtReferences.TabIndex = 2;
            this.txtReferences.Text = resources.GetString("txtReferences.Text");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.label5.Location = new System.Drawing.Point(82, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Free and open source image viewer";
            // 
            // lblSoftwareUpdate
            // 
            this.lblSoftwareUpdate.AutoSize = true;
            this.lblSoftwareUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Underline);
            this.lblSoftwareUpdate.Location = new System.Drawing.Point(19, 310);
            this.lblSoftwareUpdate.Name = "lblSoftwareUpdate";
            this.lblSoftwareUpdate.Size = new System.Drawing.Size(118, 19);
            this.lblSoftwareUpdate.TabIndex = 13;
            this.lblSoftwareUpdate.Text = "Software updates:";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(395, -29);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(66, 24);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(227, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 32);
            this.label3.TabIndex = 18;
            this.label3.Text = "BETA";
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(618, 538);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panReferences);
            this.Controls.Add(this.lblSlogant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panComponent);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblReferences);
            this.Controls.Add(this.lblComponent);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.panInfo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmAbout";
            this.Text = "About";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panInfo.ResumeLayout(false);
            this.panInfo.PerformLayout();
            this.panComponent.ResumeLayout(false);
            this.panReferences.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblComponent;
        private System.Windows.Forms.Label lblReferences;
        private System.Windows.Forms.Panel panInfo;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel lnkEmail;
        private System.Windows.Forms.Label lblInfoContact;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnkIGHomepage;
        private System.Windows.Forms.LinkLabel lnkProjectPage;
        private System.Windows.Forms.LinkLabel lnkFacebook;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.LinkLabel lnkCheckUpdate;
        private System.Windows.Forms.Panel panComponent;
        private FileList.FileList fileList1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSlogant;
        private System.Windows.Forms.Panel panReferences;
        private System.Windows.Forms.RichTextBox txtReferences;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSoftwareUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}