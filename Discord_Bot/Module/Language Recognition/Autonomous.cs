using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord_Bot.Module.Language_Recognition
{
    public class Autonomous : ModuleBase<SocketCommandContext>
    {
        public async Task messageWorking(SocketCommandContext context, SocketMessage msg)
        {
            string[] salutation = { "hello", "salut", "coucou", "bonjour", "yo" };
            string[] insulte = { "enculer", "encule", "connard", "connar", "fuck", "tg", "pute", "salope", "fdp", "puteuh" }; 

            string message = msg.Content;

            string[] words = message.Split(' ');

            EmbedBuilder embed = new EmbedBuilder();
            embed.Color = Color.DarkerGrey;

            foreach (string word in words)
            {
                for(int i = 0; i < salutation.Length; i++)
                {
                    if (String.Compare(word, salutation[i], true) == 0)
                    {
                        await context.Channel.SendMessageAsync("Coucou!", false, null);
                        return;
                    }
                }

                for (int i = 0; i < insulte.Length; i++)
                {
                    if (String.Compare(word, insulte[i], true) == 0)
                    {
                        embed.ImageUrl = "https://media.giphy.com/media/lcETiveMjEKGdacthw/giphy.gif";//a changer

                        await context.Channel.SendMessageAsync("Le langage petit fdp malpolie!", false, embed);
                        return;
                    }
                }
            }
        }
    }
}
