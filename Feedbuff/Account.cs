using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedbuff
{
    internal class Account
    {
        public int Id { get; set; }
        public Student Student;
        public Teacher Teacher;

        public Account(int id, Student student, Teacher teacher)
        {
            Id = id;
            Student = student;
            Teacher = teacher;
        }
    }
}
