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
            //Loads FeedforwardOverview window and loads datatable from database.
            InitializeComponent();
            feedforwadDVG.Columns[0].Visible = false;
            //This line of code loads data into the 'feedBufDBDataSet1.FeedbackData' table. You can move, or remove it, as needed.
            this.feedForwardDataTableAdapter.Fill(this.feedBufDBDataSet.FeedForwardData);
        }

        private void addFeedbackToDataBaseBtn_Click(object sender, EventArgs e)
        {
            //Adds created feedforward to datatable and updates to database. (Method is named wrong)
            FeedForward feedforward = new FeedForward(0, DateTime.Now, addDocumentTxtBx.Text, addSubjectTxtBx.Text, addTeacherNameTxtbx.Text, addFeedbackTxtBx.Text, false);
            FeedForward feedbackCreate = feedforward.Create(feedforward);
            foreach(FeedForward item in feedforward.Read())
            {
                feedforward.Update(item);

            }
            this.feedForwardDataTableAdapter.Fill(this.feedBufDBDataSet.FeedForwardData);
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            //Returns user to overview window.
            this.Hide();
            Overview overview = new Overview();
            overview.ShowDialog();
            this.Close();
        }

        private void FeedforwardOverview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'feedBufDBDataSet4.FeedbackData' table. You can move, or remove it, as needed.
            this.feedbackDataTableAdapter.Fill(this.feedBufDBDataSet4.FeedbackData);
            // TODO: This line of code loads data into the 'justfeedup.FeedupData' table. You can move, or remove it, as needed.
            this.feedupDataTableAdapter.Fill(this.justfeedup.FeedupData);
            // TODO: This line of code loads data into the 'feedBufDBDataSet.FeedForwardData' table. You can move, or remove it, as needed.
            this.feedForwardDataTableAdapter.Fill(this.feedBufDBDataSet.FeedForwardData);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            //Deletes entire selected row from datatable and database.
            FeedForward feedforward = new FeedForward(Int32.Parse(feedforwadDVG.SelectedRows[0].Cells[0].Value.ToString()), DateTime.Now, "a", "a", "a", "a",false);
            feedforward.Delete(feedforward);
            foreach (DataGridViewRow item in this.feedforwadDVG.SelectedRows)
            {
                feedforwadDVG.Rows.RemoveAt(item.Index);
            }
        }
    }
}
