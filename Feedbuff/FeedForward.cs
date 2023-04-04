using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedbuff
{
    internal class FeedForward
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Document { get; set; }
        public string Subject { get; set; }
        public string ForTeacher { get; set; }
        public string GivenFeedForward { get; set; }
        public bool Controle { get; set; }
        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
        public DAL dal { get; set; }

        public FeedForward(int id, DateTime date, string document, string subject, string forteacher, string givenFeedForward, bool controle)
        {
            Id = id;
            Date = date;
            Document = document;
            Subject = subject;
            ForTeacher = forteacher;
            GivenFeedForward = givenFeedForward;
            Controle = controle;
            dal = new DAL();
        }

        public List<FeedForward> Read()
        {
            return dal.ReadFeedForward();
        }
    }
}