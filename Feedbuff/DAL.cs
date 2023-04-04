using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Feedbuff
{
    internal class DAL
    {
        string connectionString = "zet hier de conectionstring";
        public List<Feedback> feedbacks = new List<Feedback>();
        public List<Feedup> feedups = new List<Feedup>();


        public DAL()
        {
            
        }
        public List<Feedback> ReadFeedback()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT Id, Date, Documentback, Subject, TeacherName, GivenFeedback, Controle from Feedback ORDER BY ID";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            feedbacks.Add(new Feedback(Int32.Parse(reader[0].ToString())
                                    , DateTime.Parse(reader[1].ToString())
                                    , reader[2].ToString()
                                    , reader[3].ToString()
                                    , reader[4].ToString()
                                    , reader[5].ToString()
                                    , bool.Parse(reader[6].ToString())
                                    ));
                          
                        }
                    }

                }
            }
            return feedbacks;
        }
        public List<Feedup> ReadFeedup()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT Id, InitiateDate , Deadline, Documentup, Subject, Teacher, FeedUp, Achieved, DoneDate, SideNote from Feedup ORDER BY ID";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            feedups.Add(new Feedup(Int32.Parse(reader[0].ToString())
                                    , DateTime.Parse(reader[1].ToString())
                                    , DateTime.Parse(reader[2].ToString())
                                    , reader[3].ToString()
                                    , reader[4].ToString()
                                    , reader[5].ToString()
                                    , reader[6].ToString()
                                    , bool.Parse(reader[7].ToString())
                                    , DateTime.Parse(reader[6].ToString())
                                    , reader[6].ToString()
                                    ));
                            
                        }
                    }

                }
            }
            return feedups;
        }    }
}
