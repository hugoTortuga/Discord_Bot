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
                }
                else if (word == "pd" || word == "gay")
                {
                    await ReplyAsync("Je connais quelqu'un qui a des fantasme! :kiss: https://media.giphy.com/media/QJK9T76qoUPba/giphy.gif");
                }
            }
        }
    }
}
