using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Discord_Bot.Module
{
    public class Random : ModuleBase<SocketCommandContext>
    {
        [Command("Random")]
        public async Task RandomTake()
        {
            string link = "";
            int ID = 0;

            System.Random rnd = new System.Random();
            ID = rnd.Next(1, 46);

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\scrip\\source\\repos\\Discord_Bot\\Discord_Bot\\Database1.mdf;Integrated Security=True"))
            using (SqlCommand cmd = new SqlCommand("SELECT link FROM [dbo].[Table] WHERE Id='" + ID + "';", connection))
            {
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        link = reader.GetString(reader.GetOrdinal("link"));
                    }
                }

                connection.Close();
            }

            await ReplyAsync(link);
        }
    }
}
