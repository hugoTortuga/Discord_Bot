using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord_Bot.Module
{
    [Group("Ask")]
    public class Ask : ModuleBase<SocketCommandContext>
    {
        [Command("vierge")]
        public async Task vierge()
        {
            await ReplyAsync($"@Kougnaman est vierge! C'est evident");
        }
    }
}
