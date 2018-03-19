using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord_Bot.Module
{
    [Group("do")]
    public class ActionMessage : ModuleBase<SocketCommandContext>
    {
        [Command("biffle")]
        public async Task DoBiffle(SocketGuildUser user)
        {
            await ReplyAsync($"{ Context.User.Mention } biffle { user.Mention }");
        }

        [Command("throw")]
        public async Task DoThrow(SocketGuildUser user)
        {
            await ReplyAsync($"{ Context.User.Mention } jette des cacahuetes a { user.Mention }");
        }

        [Command("doigt")]
        public async Task DoDoigt(SocketGuildUser user)
        {
            await ReplyAsync($"{ Context.User.Mention } fait un doigt a { user.Mention }");
        }

        [Command("olive")]
        public async Task Olive()
        {
            await ReplyAsync($"{ Context.User.Mention } fait une olive a Marie-Louise");
        }

        [Command("olive")]
        public async Task DoOlive(SocketGuildUser user)
        {
            await ReplyAsync($"{ Context.User.Mention } fait une olive a { user.Mention }");
        }

        [Command("olive")]
        public async Task DoOliveA(String nom)
        {
            await ReplyAsync($"{ Context.User.Mention } fait une olive a { nom }");
        }
    }
}
