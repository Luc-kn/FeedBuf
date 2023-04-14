using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedbuff
{
    internal class Feedback
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Document { get; set; }
        public string Subject { get; set; }
        public string ForTeacher { get; set; }
        public string GivenFeedback { get; set; }
        public bool Controle { get; set; }
        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
        public Feedup Feedup { get; set; }
        public DAL dal { get; set; }

        public Feedback(int id, DateTime date, string document, string subject, string forteacher, string givenFeedback, bool controle, Feedup feedup)
        {
            Id = id;
            Date = date;
            Document = document;
            Subject = subject;
            ForTeacher = forteacher;
            GivenFeedback = givenFeedback;
            Controle = controle;
            dal = new DAL();
            Feedup = feedup;
        }

        public List<Feedback> Read(Feedup feedup)
        {
            return dal.ReadFeedback(feedup);
        }
        public Feedback Create(Feedback feedback)
        {
            return dal.CreateFeedback(feedback);
        }
        public void Updtae(Feedback feedback)
        {
            dal.UpdateFeedback(feedback);
        }
        public void Delete(Feedback feedback)
        {
            dal.DeleteFeedback(feedback);
        }
    }
}
