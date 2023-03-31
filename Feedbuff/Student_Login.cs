using System;
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
    public partial class Student_Login : Form
    {
        public Student_Login()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentLoginRegister StudentRg = new StudentLoginRegister();
            StudentRg.ShowDialog();
            this.Close();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Overview StudentOv = new Overview();
            StudentOv.ShowDialog();
            this.Close();
        }
    }
}
