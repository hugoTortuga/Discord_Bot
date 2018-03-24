using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord_Bot.Module
{
    public class Music : ModuleBase<SocketCommandContext>
    {
        [Command("music")]
        public async Task music(String type)
        {
            if(type == "futurehouse")
            {
                string[] link = new string[3];

                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\scrip\\source\\repos\\Discord_Bot\\Discord_Bot\\Database1.mdf;Integrated Security=True"))
                using (SqlCommand cmd = new SqlCommand("SELECT link FROM [dbo].[music] WHERE type LIKE 'Future House';", connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int i = 0;
                        while (reader.Read())
                        {
                            link[i] = reader.GetString(reader.GetOrdinal("link"));
                            i++;
                        }
                    }

                    connection.Close();
                }

                System.Random rnd = new System.Random(DateTime.Now.Millisecond);
                int song = rnd.Next(0, 3);
                await ReplyAsync(link[song]);
            }
            else if(type == "trap")
            {
                string[] link = new string[3];

                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\scrip\\source\\repos\\Discord_Bot\\Discord_Bot\\Database1.mdf;Integrated Security=True"))
                using (SqlCommand cmd = new SqlCommand("SELECT link FROM [dbo].[music] WHERE type LIKE 'Trap';", connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int i = 0;
                        while (reader.Read())
                        {
                            link[i] = reader.GetString(reader.GetOrdinal("link"));
                            i++;
                        }
                    }

                    connection.Close();
                }

                System.Random rnd = new System.Random(DateTime.Now.Millisecond);
                int song = rnd.Next(0, 3);
                await ReplyAsync(link[song]);
            }
            else if(type == "proghouse")
            {
                string[] link = new string[3];

                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\scrip\\source\\repos\\Discord_Bot\\Discord_Bot\\Database1.mdf;Integrated Security=True"))
                using (SqlCommand cmd = new SqlCommand("SELECT link FROM [dbo].[music] WHERE type LIKE 'Prog House';", connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int i = 0;
                        while (reader.Read())
                        {
                            link[i] = reader.GetString(reader.GetOrdinal("link"));
                            i++;
                        }
                    }

                    connection.Close();
                }

                System.Random rnd = new System.Random(DateTime.Now.Millisecond);
                int song = rnd.Next(0, 3);
                await ReplyAsync(link[song]);
            }
            else if(type == "house")
            {
                string[] link = new string[3];

                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\scrip\\source\\repos\\Discord_Bot\\Discord_Bot\\Database1.mdf;Integrated Security=True"))
                using (SqlCommand cmd = new SqlCommand("SELECT link FROM [dbo].[music] WHERE type LIKE 'House';", connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int i = 0;
                        while (reader.Read())
                        {
                            link[i] = reader.GetString(reader.GetOrdinal("link"));
                            i++;
                        }
                    }

                    connection.Close();
                }

                System.Random rnd = new System.Random(DateTime.Now.Millisecond);
                int song = rnd.Next(0, 3);
                await ReplyAsync(link[song]);
            }
            else if(type == "dubstep")
            {
                string[] link = new string[3];

                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\scrip\\source\\repos\\Discord_Bot\\Discord_Bot\\Database1.mdf;Integrated Security=True"))
                using (SqlCommand cmd = new SqlCommand("SELECT link FROM [dbo].[music] WHERE type LIKE 'dubstep';", connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int i = 0;
                        while (reader.Read())
                        {
                            link[i] = reader.GetString(reader.GetOrdinal("link"));
                            i++;
                        }
                    }

                    connection.Close();
                }

                System.Random rnd = new System.Random(DateTime.Now.Millisecond);
                int song = rnd.Next(0, 3);
                await ReplyAsync(link[song]);
            }
            else if(type == "glitchhop")
            {
                string[] link = new string[3];

                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\scrip\\source\\repos\\Discord_Bot\\Discord_Bot\\Database1.mdf;Integrated Security=True"))
                using (SqlCommand cmd = new SqlCommand("SELECT link FROM [dbo].[music] WHERE type LIKE 'Glitch Hop';", connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int i = 0;
                        while (reader.Read())
                        {
                            link[i] = reader.GetString(reader.GetOrdinal("link"));
                            i++;
                        }
                    }

                    connection.Close();
                }

                System.Random rnd = new System.Random(DateTime.Now.Millisecond);
                int song = rnd.Next(0, 3);
                await ReplyAsync(link[song]);
            }
            else
            {
                await ReplyAsync($"Désolé, je n'ecoute pas ce genre de musique. https://media0.giphy.com/media/lkYTniLelesrC/giphy.gif");
            }
        }
    }
}
