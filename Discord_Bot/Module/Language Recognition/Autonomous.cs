using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord_Bot.Module.Language_Recognition
{
    public class Autonomous : ModuleBase<SocketCommandContext>
    {
        private List<string> message_waiting_file = new List<string>();

        public async Task messageWorking(SocketCommandContext context, SocketMessage msg)
        {
            string[] salutation = { "hello", "salut", "coucou", "bonjour", "yo" };
            string[] insulte = { "enculer", "encule", "connard", "connar", "fuck", "tg", "pute", "salope", "fdp", "puteuh", "pd", "gueule" };
            string[] sentir = { "ca", "comment" };
            string[] aller = { "aller", "vas", "va" };

            string message = msg.Content;

            string[] words = message.Split(' ');

            EmbedBuilder embed = new EmbedBuilder();
            embed.Color = Color.DarkerGrey;

            int word_pos = 0;

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

                if (word_pos == 0)
                {
                    for (int i = 0; i < sentir.Length; i++)
                    {
                        if (String.Compare(word, sentir[i], true) == 0)
                        {
                            word_pos++;
                        }
                    }
                }
                else if (word_pos == 1)
                {
                    for (int i = 0; i < sentir.Length; i++)
                    {
                        if (String.Compare(word, sentir[i], true) == 0)
                        {
                            word_pos++;
                        }
                    }

                    for (int i = 0; i < aller.Length; i++)
                    {
                        if (String.Compare(word, aller[i], true) == 0)
                        {
                            await context.Channel.SendMessageAsync("A merveille!", false, null);
                            return;
                        }
                    }
                }
            }
        }

        public async Task stackMessage(SocketCommandContext context, SocketMessage msg)
        {
            string message = msg.Content;
            message_waiting_file.Add(msg.Content);//add message to file
        }

        public void messagePorcessing()
        {
            if(!message_waiting_file.Any())
            {
                Thread.Sleep(200);//make the thread rest
            }
            else
            {
                //process message in file
            }
        }

    }
}
