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
            int max = 0;

            ID = rnd.Next(1, 3);
            logMessage += ID.ToString();

            if(ID == 1)
            {
                table = "[troll]";
                max = 76;
            }
            else if(ID == 2)
            {
                table = "[notsafe]";
                max = 106;
            }

            ID = rnd.Next(1, max);
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

            var embed = new EmbedBuilder();
            embed.WithTitle(table);
            embed.WithColor(0, 0, 255);
            embed.WithImageUrl(link);

            await Context.Channel.SendMessageAsync("", false, embed);
        }

        [Command("random add NSFW")]
        public async Task AddRandomNSFW(string link)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\scrip\\source\\repos\\Discord_Bot\\Discord_Bot\\Database1.mdf;Integrated Security=True"))
            using (SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[notsafe](link) VALUES('" + link + "');", connection))
            {
                connection.Open();
                cmd.BeginExecuteNonQuery();
                Console.WriteLine("Image: " + link + " was added to NSFW table");
                connection.Close();
            }

            await ReplyAsync("J'ai ajouter ton fantasme a ma base de donnée https://media.giphy.com/media/D6sgbbhYjXNni/giphy.gif");
        }

        [Command("random add troll")]
        public async Task AddRandomTroll(string link)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\scrip\\source\\repos\\Discord_Bot\\Discord_Bot\\Database1.mdf;Integrated Security=True"))
            using (SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[troll](link) VALUES('" + link + "');", connection))
            {
                connection.Open();
                cmd.BeginExecuteNonQuery();
                Console.WriteLine("Image: " + link + " was added to troll table");
                connection.Close();
            }

            await ReplyAsync("L'humour de merde, enfin bon... https://media.giphy.com/media/DED69Sdz15FiU/giphy.gif");
        }
    }
}
