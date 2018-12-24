using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;
using Discord_Bot.Module;



namespace Discord_Bot.Module
{
    [Group("Image")]
    public class Random : ModuleBase<SocketCommandContext>
    {
        const string db_log = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\scrip\\source\\repos\\Discord_Bot\\Discord_Bot\\Database.mdf;Integrated Security=True";

        [Command ("troll")]
        public async Task getTrollImage()
        {
            string link = "";

            System.Random rnd = new System.Random(DateTime.Now.Millisecond);
            int ID = rnd.Next(1, 77);

            string logMessage = "image troll n°" + ID;
            Console.WriteLine("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + logMessage);

            using (SqlConnection connection = new SqlConnection(db_log))
            using (SqlCommand cmd = new SqlCommand("EXECUTE getTroll " + ID + ";", connection))
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
            embed.WithTitle("Troll");
            embed.WithColor(0, 0, 255);
            embed.WithImageUrl(link);

            await Context.Channel.SendMessageAsync("", false, embed);
        }

        [Command("nsfw")]
        public async Task getNSFWImage()
        {
            if (!Context.Channel.IsNsfw)
            {
                await ReplyAsync("Pas ici, on va nous voir :kissing_heart:");
                return;
            }

            string link = "";

            System.Random rnd = new System.Random(DateTime.Now.Millisecond);
            int ID = rnd.Next(1, 125);

            string logMessage = "image nsfw n°" + ID;
            Console.WriteLine("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + logMessage);

            using (SqlConnection connection = new SqlConnection(db_log))
            using (SqlCommand cmd = new SqlCommand("EXECUTE getNSFW " + ID + ";", connection))
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
            embed.WithTitle("NSFW");
            embed.WithColor(0, 0, 255);
            embed.WithImageUrl(link);

            await Context.Channel.SendMessageAsync("", false, embed);
        }

        [Command("random")]
        public async Task RandomTake()
        {
            if (!Context.Channel.IsNsfw)
            {
                await ReplyAsync("Pas ici, on va nous voir :kissing_heart:");
                return;
            }

            string link = "";

            System.Random rnd = new System.Random(DateTime.Now.Millisecond);
            int ID = rnd.Next(1, 200);

            string logMessage = "image bank n°" + ID;
            Console.WriteLine("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + logMessage);
            using (SqlConnection connection = new SqlConnection(db_log))
            using (SqlCommand cmd = new SqlCommand("EXECUTE getRandom " + ID + ";", connection))
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
            embed.WithTitle("Bank");
            embed.WithColor(0, 0, 255);
            embed.WithImageUrl(link);

            await Context.Channel.SendMessageAsync("", false, embed);
        }

        [Command("add NSFW")]
        public async Task AddRandomNSFW(string link)
        {
            if(link == "" || link == " ")
            {
                return;
            }

            using (SqlConnection connection = new SqlConnection(db_log))
            using (SqlCommand cmd = new SqlCommand("EXECUTE addNSFW " + link, connection))
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + "Image: " + link + " was added to NSFW");
                connection.Close();
            }

            await ReplyAsync("J'ai ajouter ton fantasme a ma base de donnée https://media.giphy.com/media/D6sgbbhYjXNni/giphy.gif");
        }

        [Command("add troll")]
        public async Task AddRandomTroll(string link)
        {
            if (link == "" || link == " ")
            {
                return;
            }

            using (SqlConnection connection = new SqlConnection(db_log))
            using (SqlCommand cmd = new SqlCommand("EXECUTE addTroll " + link, connection))
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("[" + DateTime.Now.ToString("HH:mm:ss") + "]" + "Image: " + link + " was added to trolls");
                connection.Close();
            }

            await ReplyAsync("L'humour de merde, enfin bon... https://media.giphy.com/media/DED69Sdz15FiU/giphy.gif");
        }
    }
}
