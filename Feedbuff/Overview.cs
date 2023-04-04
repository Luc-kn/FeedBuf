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
    public partial class Overview : Form
    {
        public Overview()
        {
            InitializeComponent();
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void goToFeedbackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FeedbackOverview feedbackOverview = new FeedbackOverview();
            feedbackOverview.ShowDialog();
            this.Close();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Login Studentlg = new Student_Login();
            Studentlg.ShowDialog();
            this.Close();
        }

        private void feedForwardBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FeedforwardOverview feedforwardOverview = new FeedforwardOverview();
            feedforwardOverview.ShowDialog();
            this.Close();
        }

        private void leerDoelenBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FeedupOverview feedupOverview = new FeedupOverview();
            feedupOverview.ShowDialog();
            this.Close();
        }
    }
}
