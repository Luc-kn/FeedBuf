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
    public partial class FeedbackOverview : Form
    {
        public FeedbackOverview() { 
            InitializeComponent();
            Feedback DummyFeedback = new Feedback(1, DateTime.Now, "a", "a", "a", "A", true);
            foreach(Feedback item in DummyFeedback.Read())
            {
                feedbackFromDatabaseLstBx.Items.Add("date: "+item.Date+" feedback: "+item.GivenFeedback);
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
            Feedback feedback = new Feedback(0, DateTime.Now, addDocumentTxtBx.Text, addSubjectTxtBx.Text, addTeacherNameTxtbx.Text, addFeedbackTxtBx.Text, true);
            Feedback feedbackCreate = feedback.Create(feedback);
            feedbackFromDatabaseLstBx.Items.Clear();
            foreach (Feedback item in feedback.Read())
            {
                feedback.Updtae(item);
                feedbackFromDatabaseLstBx.Items.Add("date: " + item.Date + " feedback: " + item.GivenFeedback);
            }

        }

    }
}
