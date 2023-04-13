using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedbuff
{
    internal class Student
    {
        public int Id {get; set;}
        public string FirstName {get; set;}
        public string Infix { get; set;}
        public string LastName {get; set;}
        public int StudentNumber {get; set;}
        public string Email { get; set; }
        public string Password {get; set;}
        public List<Teacher> teachers = new List<Teacher>();
        public List<Feedup> feedups = new List<Feedup>();    
        public List<FeedForward> feedforwards = new List<FeedForward>();
        public List<Feedback> feedbacks = new List<Feedback>();
        public Account Account;
        public DAL dal { get; set; }

        public Student(int id, string firstName,string infix, string lastName, int studentNumber, string email, string password)
        {
            Id = id;
            FirstName = firstName;
            Infix = infix;
            LastName = lastName;
            StudentNumber = studentNumber;
            Email = email;
            Password = password;
            dal = new DAL();

        }
        public string GetEmail()
        {
            return Email;
        }
        public void SetEmail(string email)
        {
            
            Email = email;
            
        }
        public List<Student> Read() 
        {
            return dal.ReadStudent();
        }
    }
}
