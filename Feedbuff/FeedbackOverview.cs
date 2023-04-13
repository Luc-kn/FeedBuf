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
            feedbackDGV.Columns[0].Visible = false;


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
            //This line of code loads data into the 'feedBufDBDataSet1.FeedbackData' table. You can move, or remove it, as needed.
            this.feedbackDataTableAdapter.Fill(this.feedBufDBDataSet1.FeedbackData);


        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Feedback feedback = new Feedback(Int32.Parse(feedbackDGV.SelectedRows[0].Cells[0].Value.ToString()),DateTime.Now,"a","a","a","a",false);
            feedback.Delete(feedback);
            foreach (DataGridViewRow item in this.feedbackDGV.SelectedRows)
            {
                feedbackDGV.Rows.RemoveAt(item.Index);
            }

        }

        private void FeedbackOverview_Load(object sender, EventArgs e)
        {
            //This line of code loads data into the 'feedBufDBDataSet1.FeedbackData' table. You can move, or remove it, as needed.
            this.feedbackDataTableAdapter.Fill(this.feedBufDBDataSet1.FeedbackData);

        }


      


    }
}
