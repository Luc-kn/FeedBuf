﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feedbuff
{
    public partial class Welkom : Form
    {
        public Welkom()
        {
            //Loads Welkom window.
            InitializeComponent();
        }
        //Setting assignment for border styling.
            [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
            private static extern IntPtr CreateRoundRectRgn
         (
             int nLeftRect,     // x-coordinate of upper-left corner
             int nTopRect,      // y-coordinate of upper-left corner
             int nRightRect,    // x-coordinate of lower-right corner
             int nBottomRect,   // y-coordinate of lower-right corner
             int nWidthEllipse, // width of ellipse
             int nHeightEllipse // height of ellipse
        );

        private void Welkom_Load(object sender, EventArgs e)
        {
            //Loads Welkom window in certain borderstyle design.
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void studentBtn_Click(object sender, EventArgs e)
        {
            //Continues user to Studentlogin window.
            this.Hide();
            Student_Login Studentlg= new Student_Login();
            Studentlg.ShowDialog();
            this.Close();
        }
    }
}
