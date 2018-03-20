using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;
using Discord;

namespace Discord_Bot.Module
{
    public class Random : ModuleBase<SocketCommandContext>
    {
        System.Random rnd = new System.Random();

        [Command("random")]
        public async Task RandomTake()
        {
            if(!Context.Channel.IsNsfw)
            {
                await ReplyAsync("Pas ici, on va nous voir :kissing_heart:");
                return;
            }

            string link = "";
            int ID = 0;

            ID = rnd.Next(1, 84);
            Console.WriteLine(ID);

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
