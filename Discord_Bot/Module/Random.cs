﻿using Discord;
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
        [Command("random")]
        public async Task RandomTake()
        {
            System.Random rnd = new System.Random(DateTime.Now.Millisecond);
            string logMessage = "random ";

            if(!Context.Channel.IsNsfw)
            {
                await ReplyAsync("Pas ici, on va nous voir :kissing_heart:");
                return;
            }

            string table = "";
            string link = "";
            int ID = 2;

            ID = rnd.Next(1, 3);
            logMessage += ID.ToString();

            if(ID == 1)
            {
                table = "[troll]";
            }
            else if(ID == 2)
            {
                table = "[notsafe]";
            }

            ID = rnd.Next(1, 76);
            Console.WriteLine(logMessage + " " + ID);

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\scrip\\source\\repos\\Discord_Bot\\Discord_Bot\\Database1.mdf;Integrated Security=True"))
            using (SqlCommand cmd = new SqlCommand("SELECT link FROM [dbo]." + table + "WHERE Id='" + ID + "';", connection))
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
