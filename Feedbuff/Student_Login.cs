using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feedbuff
{
    public partial class Student_Login : Form
    {
        public Student_Login()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentLoginRegister StudentRg = new StudentLoginRegister();
            StudentRg.ShowDialog();
            this.Close();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            Overview StudentOv = new Overview();

            Student dummyStudent = new Student(0,"A","a","a",0,"a","a");
            foreach (Student item in dummyStudent.Read()) 
             {
                if (fillInEmailTxtBx.Text == item.Email)
                {
                    wrongLoginLbl.Text = "";
                    if (fillInPasswordTxtBx.Text == item.Password)
                    {
                        wrongLoginLbl.Text = "";
                        this.Hide();
                        StudentOv.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        wrongLoginLbl.Text = "FOUT";
                    }
                }
                else
                {
                    wrongLoginLbl.Text = "FOUT";
                }
            }
            
        }

        
    }
}
