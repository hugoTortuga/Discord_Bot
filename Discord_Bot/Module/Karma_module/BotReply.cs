using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord_Bot.Module.Karma_module
{
    class BotReply : ModuleBase<SocketCommandContext>
    {
        [Command("")]
        public async Task AnalyseMessage(String msg)
        {
            string[] words = msg.Split(' ');
            foreach (string word in words)
            {
                if (word == "grosse" || word == "gros")
                {
                    await ReplyAsync("T'essayerais pas de compenser quelque chose toi? https://media.giphy.com/media/rxQLAgddHL1tu/giphy.gif");
                    return;
                }
                else if (word == "pd" || word == "gay")
                {
                    await ReplyAsync("Je connais quelqu'un qui a des fantasmes! :kiss: https://media.giphy.com/media/QJK9T76qoUPba/giphy.gif");
                    return;
                }
                else if (word == "homophobe")
                {
                    await ReplyAsync("Monsieur le cuck aurait-il besoin d'aide pour se viriliser?");
                    return;
                }
            }
        }

        [Command("elise")]
        public async Task talkToElise(String msg)
        {
            int layer = 0;

            string[] words = msg.Split(' ');
            foreach (string word in words)
            {
                if(word == "es" || word == "est")
                {
                    layer++;
                }
                else if (layer == 1)
                {
                    if(word == "moche" || word == "thon")
                    {
                        await ReplyAsync("Ah ouais ? Ta vue ta mère et t'ose parler");
                        return;
                    }
                    else if(word == "tchoin" || word == "pute" || word == "salope")
                    {
                        await ReplyAsync("Je suis choquer, du haut de ma pureté, qu'un sac a foutre comme toi ose me parler!");
                        return;
                    }
                }
            }
        }

        [Command("Elise")]
        public async Task talkToEliseRedirect(String msg)
        {
            await talkToElise(msg);
        }
    }
}
