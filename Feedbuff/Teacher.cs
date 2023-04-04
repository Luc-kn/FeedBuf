using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedbuff
{
    internal class Teacher
    {
        public int Id {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public int TeacherNumber {get; set;}
        public string Email;
        public string Wachtwoord {get; set;}
        public List<Student> students = new List<Student>();
        public List<Feedup> feedups = new List<Feedup>();    
        public List<FeedForward> feedforwards = new List<FeedForward>();
        public List<Feedback> feedbacks = new List<Feedback>();
        public Account Account;

        public Teacher(int id, string firstName, string lastName, int teacherNumber, string email, string wachtwoord, Account account)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            TeacherNumber = teacherNumber;
            Email = email;
            Wachtwoord = wachtwoord;
            Account = account;
        }

        public string GetEmail()
        {
            return Email;
        }
        public void SetEmail(string email)
        {
            
            Email = email;
            
        }
    }
}
