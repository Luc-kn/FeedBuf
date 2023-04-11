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
    public partial class FeedupOverview : Form
    {
        public FeedupOverview()
        {
            InitializeComponent();
            Feedup Dummyfeedup = new Feedup(1, DateTime.Now, DateTime.Now,"a","a","a","a",true,DateTime.Now,"a");
            foreach (Feedup item in Dummyfeedup.Read())
            {
                feedupFromDatabaseLstBx.Items.Add("date: " + item.Deadline + " feedup: " + item.FeedUp);
            }
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Overview overview = new Overview();
            overview.ShowDialog();
            this.Close();
        }

       

        private void addFeedbackToDataBaseBtn_Click(object sender, EventArgs e)
        {
            Feedup feedup = new Feedup(0,DateTime.Today, DateTime.Parse(addDoneDateTxtBx.Text), addDocumentTxtBx.Text, addSubjectTxtBx.Text,addTeacherNameTxtbx.Text,addFeedupTxtBx.Text, true,DateTime.Parse(addDoneDateTxtBx.Text),"");
            Feedup feedupCreate = feedup.Create(feedup);
            feedupFromDatabaseLstBx.Items.Clear();

            foreach (Feedup item in feedup.Read())
            {
                feedup.Update(item);
                feedupFromDatabaseLstBx.Items.Add("date: " + item.Deadline + " feedup: " + item.FeedUp);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
