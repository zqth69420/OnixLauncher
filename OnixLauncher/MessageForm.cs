﻿using System;
using System.Windows.Forms;

namespace OnixLauncher
{
    public partial class MessageForm : Form
    {
        public MessageForm(string title, string subtitle)
        {
            InitializeComponent();
            MessageTitle.Text = title;
            MessageSubtitle.Text = subtitle;
        }

        private void Okay_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            Winapi.ReleaseCapture();
            Winapi.SendMessage(Handle, Winapi.WM_NCLBUTTONDOWN, Winapi.HT_CAPTION, 0);
        }
    }
}