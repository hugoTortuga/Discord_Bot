using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord_Bot.Module.Bot_Admin
{
    public class Username : ModuleBase<SocketCommandContext>
    {
        [Command("username")]
        public async Task resetUsername(String mdp)
        {
            if(mdp == "BHL")
            {
                await Context.Client.CurrentUser.ModifyAsync(bot =>
                {
                    bot.Username = "Elise";
                });
            }
            else
            {
                await ReplyAsync("mdp erroné");
            }
        }
    }
}
