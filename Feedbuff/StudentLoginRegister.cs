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
    public partial class StudentLoginRegister : Form
    {
        public StudentLoginRegister()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Login Studentlg = new Student_Login();
            Studentlg.ShowDialog();
            this.Close();
        }
      
    }
}
