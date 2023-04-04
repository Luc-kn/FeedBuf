using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feedbuff
{
    internal class Feedup
    {
        public int Id{ get; set; }
        public DateTime InitiateDate { get; set; }
        public DateTime Deadline { get; set; }
        public string Document { get; set; }
        public string Subject { get; set; }
        public string Teacher { get; set; }
        public string FeedUp { get; set; }
        public bool Achieved { get; set; } = false;
        public DateTime DoneDate { get; set; }
        public string SideNote { get; set; }
        public DAL dal { get; set; }

        public Feedup(int id, DateTime initiateDate, DateTime deadline, string document, string subject, string teacher, string feedUp, bool achieved, DateTime doneDate, string sideNote)
        {
            Id = id;
            InitiateDate = initiateDate;
            Deadline = deadline;
            Document = document;
            Subject = subject;
            Teacher = teacher;
            FeedUp = feedUp;
            Achieved = achieved;
            DoneDate = doneDate;
            SideNote = sideNote;
            dal = new DAL();

        }
        public List<Feedup> Read()
        {
            return dal.ReadFeedup();
        }
    }
}
