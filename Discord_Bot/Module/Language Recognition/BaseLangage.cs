using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord_Bot.Module.Language_Recognition
{
    public class BaseLangage : ModuleBase<SocketCommandContext>
    {
        [Command("Salut")]
        [Alias("slt", "bonjour", "bjr", "cc", "coucou")]
        public async Task Salutation()
        {
            int choice = 0;
            string salutation = "";

            System.Random rnd = new System.Random(DateTime.Now.Millisecond);
            choice = rnd.Next(0, 3);

            switch (choice)
            {
                case 0:
                    salutation = "Coucou!";
                    break;
                case 1:
                    salutation = "Salut!";
                    break;
                case 2:
                    salutation = "Hi!";
                    break;
                default:
                    System.Console.WriteLine("Invalid number: f:Saluation c:BaseLangage");
                    break;
            }

            await ReplyAsync(salutation);
        }

        [Command("ca va")]
        [Alias("ca va?", "ca va ?", "sa va", "sa va?", "sa va ?", "comment vas?", "comment vas ?", "comment va")]
        public async Task Etat()
        {
            if(Context.User.Id.ToString() == "261920234980507658")
            {
                await ReplyAsync("Oui Monsieur! Et vous ?");
                return;
            }

            int choice = 0;
            string etat = "";

            System.Random rnd = new System.Random(DateTime.Now.Millisecond);
            choice = rnd.Next(0, 3);

            switch (choice)
            {
                case 0:
                    etat = "Ca va et toi?";
                    break;
                case 1:
                    etat = "Ca va, ca va!";
                    break;
                case 2:
                    etat = "Super bien!";
                    break;
                default:
                    System.Console.WriteLine("Invalid number: f:Etat c:BaseLangage");
                    break;
            }

            await ReplyAsync(etat);
        }

        [Command("tes")]
        [Alias("t\'es", "tu es")]
        public async Task AnalysePhrase(String msg)
        {
            EmbedBuilder embed = new EmbedBuilder();
            embed.Color = Color.DarkerGrey;

            string[] words = msg.Split(' ');
            foreach (string word in words)
            {
                if (word == "grosse" || word == "gros")
                {
                    embed.ImageUrl = "https://media.giphy.com/media/rxQLAgddHL1tu/giphy.gif";

                    await Context.Channel.SendMessageAsync("T'essayerais pas de compenser quelque chose toi?", false, embed);
                    return;
                }
                else if (word == "pd" || word == "gay")
                { 
                    embed.ImageUrl = " https://media.giphy.com/media/QJK9T76qoUPba/giphy.gif";

                    await Context.Channel.SendMessageAsync("Je connais quelqu'un qui a des fantasmes! :kiss:", false, embed);
                    return;
                }
                else if (word == "homophobe")
                {
                    await ReplyAsync("Monsieur le cuck aurait-il besoin d'aide pour se viriliser?");
                    return;
                }
            }
        }

        [Command("Laisse mon Maitre")]
        public async Task LaisseMonMaitre()
        {
            await ReplyAsync($"{ Context.User.Mention } La ferme le frigidaire, c'est les mêmes règles pour tous !");
        }
    }
}
