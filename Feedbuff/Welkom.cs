using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feedbuff
{
    public partial class Welkom : Form
    {
        public Welkom()
        {
            InitializeComponent();
        }

        private void Welkom_Load(object sender, EventArgs e)
        {

        }

        private void studentBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentLoginRegister Studentlr = new StudentLoginRegister();
            Studentlr.ShowDialog();
            this.Close();
        }
    }
}
