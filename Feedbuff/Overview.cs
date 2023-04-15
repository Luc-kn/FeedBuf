using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            recentFeedbackLstBx.Text = "Meest recente feedback.";
            recentFeedforwardLstBx.Text = "Meest recente Feedforward.";
            goalsLstBx.Text = "Leerdoelen van deze week.";
            Feedup DummyFeedup = new Feedup(0, DateTime.Now, DateTime.Now, "a", "a", "a", "A", true, DateTime.Now, "o");
            Feedback DummyFeedback = new Feedback(0,DateTime.Now,"a","a","a","a",false,DummyFeedup);
            FeedForward DummyFeedforward = new FeedForward(0, DateTime.Now, "a", "a", "a", "a", true);
            recentFeedbackLstBx.Items.Add(DummyFeedback.Read(DummyFeedup).Last().GivenFeedback.ToString());
            recentFeedforwardLstBx.Items.Add(DummyFeedforward.Read().Last().GivenFeedForward.ToString());
            foreach (Feedup item in DummyFeedup.Read())
            {
                if(ReturnWeeknum(item.DoneDate) == ReturnWeeknum(DateTime.Now))
                {
                    goalsLstBx.Items.Add(item.FeedUp);

                }
            }
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

        private void feedForwardBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FeedforwardOverview feedforwardOverview = new FeedforwardOverview();
            feedforwardOverview.ShowDialog();
            this.Close();
        }

        private void FeedupBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FeedupOverview feedforwardOverview = new FeedupOverview();
            feedforwardOverview.ShowDialog();
            this.Close();
        }

        public int ReturnWeeknum(DateTime date) 
        {
            DateTime inputDate = date;

            CultureInfo currentCulture = CultureInfo.CurrentCulture;

            var weekNum = currentCulture.Calendar.GetWeekOfYear(inputDate, CalendarWeekRule.FirstDay, DayOfWeek.Monday) - 1;
            return weekNum;
        }

        private void toProgressOverviewBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProgressOverview progressOverview = new ProgressOverview();
            progressOverview.ShowDialog();
            this.Close();
        }
    }
}
