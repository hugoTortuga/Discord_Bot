using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord_Bot.Module
{
    public class Prank : ModuleBase<SocketCommandContext>
    {
        [Command("yoga")]
        public async Task yoga()
        {
            IMessageChannel message = Context.Channel;
            await message.SendFileAsync("C:\\Users\\scrip\\Pictures\\botRessource\\yoga.jpg");
        }

        [Command("teen")]
        public async Task teen()
        {
            IMessageChannel message = Context.Channel;
            await message.SendFileAsync("C:\\Users\\scrip\\Pictures\\Image\\Les 4 dans la merde\\18834669_1928170464065798_972043687_n.png");
        }
    }
}
