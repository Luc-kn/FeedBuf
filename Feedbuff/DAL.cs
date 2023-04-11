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
        string connectionString = "Server=tcp:feedbuf.database.windows.net,1433;Initial Catalog=FeedBufDB;Persist Security Info=False;User ID=CloudSAa8987ecc;Password=DisconnectedZuyd123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public List<Feedup> feedups = new List<Feedup>();
        public List<FeedForward> feedForwards = new List<FeedForward>();
        public List<Feedback> feedbacks = new List<Feedback>();

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
                    command.CommandText = "SELECT Id, Date, Documentback, Subject, TeacherName, GivenFeedback, Controle from FeedbackData ORDER BY ID";

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
                    command.CommandText = "SELECT Id, InitiateDate , Deadline, Documentup, Subject, Teacher, FeedUp, Achieved, DoneDate, SideNote from FeedupData ORDER BY ID";

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
                                    , DateTime.Parse(reader[8].ToString())
                                    , reader[9].ToString()
                                    ));
                            
                        }
                    }

                }
            }
            return feedups;
        }
        public List<FeedForward> ReadFeedForward()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT Id, Date, Documentforward, Subject, TeacherName, GivenFeedForward, Controle from FeedForwardData ORDER BY ID";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            feedForwards.Add(new FeedForward(Int32.Parse(reader[0].ToString())
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
            return feedForwards;
        }
        public Feedback CreateFeedback(Feedback feedback)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "INSERT INTO FeedbackData (Date, DocumentBack, Subject, TeacherName, GivenFeedback, Controle) VALUES (@Date, @DocumentBack, @Subject, @TeacherName, @GivenFeedback, @Controle)";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Date", feedback.Date);
                        command.Parameters.AddWithValue("@DocumentBack", feedback.Document);
                        command.Parameters.AddWithValue("@Subject", feedback.Subject);
                        command.Parameters.AddWithValue("@TeacherName", feedback.ForTeacher);
                        command.Parameters.AddWithValue("@GivenFeedback", feedback.GivenFeedback);
                        command.Parameters.AddWithValue("@Controle", feedback.Controle);
                        command.ExecuteNonQuery();
                        command.CommandText = "SELECT CAST(@@Identity AS INT);";
                        int id = (int)command.ExecuteScalar();
                        feedback.Id = id;
                    }
                }
            }

            catch (SqlException ex) { throw ex; }
            return feedback;
        }
        public Feedup CreateFeedup(Feedup feedup)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "INSERT INTO FeedupData (InitiateDate, Deadline, DocumentUp, Subject, Teacher, FeedUp, Achieved, DoneDate, SideNote) VALUES (@InitiateDate, @Deadline, @DocumentUp, @Subject, @Teacher, @FeedUp, @Achieved, @DoneDate, @SideNote)";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@InitiateDate", feedup.InitiateDate);
                        command.Parameters.AddWithValue("@Deadline", feedup.Deadline);
                        command.Parameters.AddWithValue("@DocumentUp", feedup.DocumentUp);
                        command.Parameters.AddWithValue("@Subject", feedup.Subject);
                        command.Parameters.AddWithValue("@Teacher", feedup.Teacher);
                        command.Parameters.AddWithValue("@FeedUp", feedup.FeedUp);
                        command.Parameters.AddWithValue("@Achieved", feedup.Achieved);
                        command.Parameters.AddWithValue("@DoneDate", feedup.DoneDate);
                        command.Parameters.AddWithValue("@SideNote", feedup.SideNote);
                        command.ExecuteNonQuery();
                        command.CommandText = "SELECT CAST(@@Identity AS INT);";
                        int id = (int)command.ExecuteScalar();
                        feedup.Id = id;
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
            return feedup;
        }
        public FeedForward CreateFeedForward(FeedForward feedforward)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "INSERT INTO FeedForwardData (Date, Documentforward, Subject, TeacherName, GivenFeedForward, Controle) VALUES (@Date, @Documentforward, @Subject, @TeacherName, @GivenFeedForward, @Controle)";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Date", feedforward.Date);
                        command.Parameters.AddWithValue("@Documentforward", feedforward.Documentforward);
                        command.Parameters.AddWithValue("@Subject", feedforward.Subject);
                        command.Parameters.AddWithValue("@TeacherName", feedforward.ForTeacher);
                        command.Parameters.AddWithValue("@GivenFeedforward", feedforward.GivenFeedForward);
                        command.Parameters.AddWithValue("@Controle", feedforward.Controle);
                        command.ExecuteNonQuery();
                        command.CommandText = "SELECT CAST(@@Identity AS INT);";
                        int id = (int)command.ExecuteScalar();
                        feedforward.Id = id;
                    }
                }
            }

            catch (SqlException ex) { throw ex; }
            return feedforward;
        }
        public void UpdateFeedup(Feedup feedup)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "UPDATE FeedupData SET InitiateDate = @InitiateDate, Deadline = @Deadline, DocumentUp = @DocumentUp, Subject = @Subject, Teacher = @Teacher, FeedUp = @FeedUp, Achieved = @Achieved, DoneDate = @DoneDate, SideNote = @SideNote WHERE Id = @Id";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", feedup.Id);
                        command.Parameters.AddWithValue("@InitiateDate", feedup.InitiateDate);
                        command.Parameters.AddWithValue("@Deadline", feedup.Deadline);
                        command.Parameters.AddWithValue("@DocumentUp", feedup.DocumentUp);
                        command.Parameters.AddWithValue("@Subject", feedup.Subject);
                        command.Parameters.AddWithValue("@Teacher", feedup.Teacher);
                        command.Parameters.AddWithValue("@FeedUp", feedup.FeedUp);
                        command.Parameters.AddWithValue("@Achieved", feedup.Achieved);
                        command.Parameters.AddWithValue("@DoneDate", feedup.DoneDate);
                        command.Parameters.AddWithValue("@SideNote", feedup.SideNote);
                        command.ExecuteNonQuery();

                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        public void UpdateFeedback(Feedback feedback)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "UPDATE FeedbackData SET Date = @Date, DocumentBack = @DocumentBack, Subject = @Subject, TeacherName = @TeacherName, GivenFeedback = @GivenFeedback, Controle = @Controle WHERE Id = @Id";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", feedback.Id);
                        command.Parameters.AddWithValue("@Date", feedback.Date);
                        command.Parameters.AddWithValue("@DocumentBack", feedback.Document);
                        command.Parameters.AddWithValue("@Subject", feedback.Subject);
                        command.Parameters.AddWithValue("@TeacherName", feedback.ForTeacher);
                        command.Parameters.AddWithValue("@GivenFeedback", feedback.GivenFeedback);
                        command.Parameters.AddWithValue("@Controle", feedback.Controle);
                        command.ExecuteNonQuery();

                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        public void UpdateFeedforward(FeedForward feedforward)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "UPDATE FeedForwardData SET Date = @Date, Documentforward = @Documentforward, Subject = @Subject, TeacherName = @TeacherName, GivenFeedforward = @GivenFeedforward, Controle = @Controle WHERE Id = @Id";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", feedforward.Id);
                        command.Parameters.AddWithValue("@Date", feedforward.Date);
                        command.Parameters.AddWithValue("@Documentforward", feedforward.Documentforward);
                        command.Parameters.AddWithValue("@Subject", feedforward.Subject);
                        command.Parameters.AddWithValue("@TeacherName", feedforward.ForTeacher);
                        command.Parameters.AddWithValue("@GivenFeedforward", feedforward.GivenFeedForward);
                        command.Parameters.AddWithValue("@Controle", feedforward.Controle);
                        command.ExecuteNonQuery();

                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
    }


}
