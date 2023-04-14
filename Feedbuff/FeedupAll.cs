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
            InitializeComponent();
            feedupDGV.Columns[0].Visible = true;
            //This line of code loads data into the 'feedBufDBDataSet1.FeedbackData' table. You can move, or remove it, as needed.
            feedupDataTableAdapter.Fill(this.feedBufDBDataSet3.FeedupData);

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Feedup feedup = new Feedup(0, DateTime.Today, DateTime.Now, "", "", "", "", true, DateTime.Now, "");

            foreach (Feedup item in feedup.Read())
            {
                feedup.Update(item);
            }
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
