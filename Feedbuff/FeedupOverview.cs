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
            feedupDGV.Columns[0].Visible = false;
            //This line of code loads data into the 'feedBufDBDataSet1.FeedbackData' table. You can move, or remove it, as needed.
            feedupDataTableAdapter.Fill(this.feedBufDBDataSet2.FeedupData);

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
                Feedup feedup = new Feedup(0, DateTime.Today, DateTime.Parse(addDoneDateTxtBx.Text), addDocumentTxtBx.Text, addSubjectTxtBx.Text, addTeacherNameTxtbx.Text, addFeedupTxtBx.Text, true, DateTime.Parse(addDoneDateTxtBx.Text), "");
                Feedup feedupCreate = feedup.Create(feedup);

                foreach (Feedup item in feedup.Read())
                {
                    feedup.Update(item);
                }
            }

           

            private void FeedupOverview_Load(object sender, EventArgs e)
            {
                // TODO: This line of code loads data into the 'feedBufDBDataSet2.FeedupData' table. You can move, or remove it, as needed.
                this.feedupDataTableAdapter.Fill(this.feedBufDBDataSet2.FeedupData);

            }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Feedup feedup = new Feedup(Int32.Parse(feedupDGV.SelectedRows[0].Cells[0].Value.ToString()), DateTime.Now, DateTime.Now, "a", "a", "a","a",false,DateTime.Now,"a");
            feedup.Delete(feedup);
            foreach (DataGridViewRow item in this.feedupDGV.SelectedRows)
            {
                feedupDGV.Rows.RemoveAt(item.Index);
            }
        }

        private void ReturnBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Overview overview = new Overview();
            overview.ShowDialog();
            this.Close();
        }
    }
    } 

