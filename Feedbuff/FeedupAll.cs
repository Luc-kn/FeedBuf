using Feedbuff.FeedBufDBDataSet2TableAdapters;
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
    public partial class FeedupAll: Form
    {
        public FeedupAll()
        {
            //Loads FeedupAll window and loads datatable from database.
            InitializeComponent();
            feedupDGV.Columns[0].Visible = true;
            //This line of code loads data into the 'feedBufDBDataSet1.FeedbackData' table. You can move, or remove it, as needed.
            feedupDataTableAdapter.Fill(this.feedBufDBDataSet3.FeedupData);

        }
        public static bool achviedData;
        public static int Id;

        private void BackBtn_Click(object sender, EventArgs e)
        {
            //Returns user back to previous FeedupOverview window and updates changes in de "Achieved" section in database.
            Feedup dummyFeedup = new Feedup(0, DateTime.Today, DateTime.Now, "", "", "", "", true, DateTime.Now, "");
            foreach(DataGridViewRow item in feedupDGV.SelectedRows)
            {
                foreach(Feedup i in dummyFeedup.Read())
                {
                    if (Int32.Parse(item.Cells[0].Value.ToString()) == i.Id)
                    {
                        Id = i.Id;
                        dummyFeedup = i;
                    }
                }
                achviedData = bool.Parse(item.Cells[7].Value.ToString());
            }
            Feedup feedup1 = new Feedup(Id, dummyFeedup.InitiateDate, dummyFeedup.Deadline, dummyFeedup.DocumentUp, dummyFeedup.Subject, dummyFeedup.Teacher, dummyFeedup.FeedUp, achviedData, dummyFeedup.DoneDate, dummyFeedup.SideNote);
            dummyFeedup.Update(feedup1);

            feedupDataTableAdapter.Fill(this.feedBufDBDataSet3.FeedupData);
            FeedupOverview feedupOverview = new FeedupOverview();
            feedupOverview.ShowDialog();
            this.Close();
        }

        private void FeedupAll_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'feedBufDBDataSet3.FeedupData' table. You can move, or remove it, as needed.
            this.feedupDataTableAdapter.Fill(this.feedBufDBDataSet3.FeedupData);

        }
    }
}
