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
    public partial class ProgressOverview : Form
    {
        public ProgressOverview()
        {
            InitializeComponent();
            Feedup feedup = new Feedup(0,DateTime.Now,DateTime.Now,"a","a","a","a",false,DateTime.Now,"a");
            foreach(Feedup item in feedup.Read())
            {
                if (item.Achieved)
                {
                    yesFinishedFeedupLstBx.Items.Add(item.FeedUp + "   sidenote:" +  item.SideNote);
                }
                else { notFinishedFeedupLstBx.Items.Add(item.FeedUp + "    sidenote:" + item.SideNote); }
            }
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Overview overview = new Overview();
            overview.ShowDialog();
            this.Close();
        }

        
    }
}
