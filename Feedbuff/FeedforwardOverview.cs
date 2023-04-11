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
    public partial class FeedforwardOverview : Form
    {
        public FeedforwardOverview()
        {
            InitializeComponent();
            FeedForward DummyFeedforward = new FeedForward(1, DateTime.Now, "a", "a", "a", "A", true);
            foreach (FeedForward item in DummyFeedforward.Read())
            {
                feedforwardFromDatabaseLstBx.Items.Add("date: " + item.Date + " feedforward: " + item.GivenFeedForward);
            }
        }

        private void addFeedbackToDataBaseBtn_Click(object sender, EventArgs e)
        {
            FeedForward feedforward = new FeedForward(0, DateTime.Now, addDocumentTxtBx.Text, addSubjectTxtBx.Text, addTeacherNameTxtbx.Text, addFeedbackTxtBx.Text, false);
            FeedForward feedbackCreate = feedforward.Create(feedforward);
            feedforwardFromDatabaseLstBx.Items.Clear();
            foreach(FeedForward item in feedforward.Read())
            {
                feedforward.Update(item);
                feedforwardFromDatabaseLstBx.Items.Add("date: " + item.Date + " feedforward: " + item.GivenFeedForward);

            }
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Overview overview = new Overview();
            overview.ShowDialog();
            this.Close();
        }
    }
}
