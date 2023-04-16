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
        public FeedbackOverview()
        {
            //Loads feedbackOverview window.
            InitializeComponent();
            feedbackDGV.Columns[0].Visible = false;
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            //Returns user to previous overview window.
            this.Hide();
            Overview overview = new Overview();
            overview.ShowDialog();
            this.Close();
        }

        private void addFeedbackToDataBaseBtn_Click(object sender, EventArgs e)
        {
            //Adds created feedback to datatable and updates to database.
            Feedup dummyFeedup = new Feedup(0, DateTime.Now, DateTime.Now, "a", "a", "a", "A", true, DateTime.Now, "o");
            foreach (Feedup item in dummyFeedup.Read())
            {
                if (item.FeedUp == feedupCbBx.GetItemText(feedupCbBx.SelectedItem))
                {
                    Feedup feedup = item;
                    deleteBtn.Text = feedup.Id.ToString();
                    Feedback feedback = new Feedback(0, DateTime.Now, addDocumentTxtBx.Text, addSubjectTxtBx.Text, addTeacherNameTxtbx.Text, addFeedbackTxtBx.Text, true, feedup);
                    feedback.Create(feedback);
                }
            }
            // TODO: This line of code loads data into the 'feedBufDBDataSet4.FeedbackData' table. You can move, or remove it, as needed.
            this.feedbackDataTableAdapter1.Fill(this.feedBufDBDataSet4.FeedbackData);
            // TODO: This line of code loads data into the 'justfeedup.FeedupData' table. You can move, or remove it, as needed.
            this.feedupDataTableAdapter2.Fill(this.justfeedup.FeedupData);



        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            //Deletes entire selected row from datatable and database.
            Feedup dummyFeedup = new Feedup(0, DateTime.Now, DateTime.Now, "a", "a", "a", "A", true, DateTime.Now, "o");
            Feedback feedback = new Feedback(Int32.Parse(feedbackDGV.SelectedRows[0].Cells[0].Value.ToString()), DateTime.Now, "a", "a", "a", "a", false, dummyFeedup);
            feedback.Delete(feedback);
            foreach (DataGridViewRow item in this.feedbackDGV.SelectedRows)
            {
                feedbackDGV.Rows.RemoveAt(item.Index);
            }
        }

        private void FeedbackOverview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'feedBufDBDataSet4.FeedbackData' table. You can move, or remove it, as needed.
            this.feedbackDataTableAdapter1.Fill(this.feedBufDBDataSet4.FeedbackData);
            // TODO: This line of code loads data into the 'justfeedup.FeedupData' table. You can move, or remove it, as needed.
            this.feedupDataTableAdapter2.Fill(this.justfeedup.FeedupData);
        }
    }
}
