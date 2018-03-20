using Discord;
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
        //biffle command
        [Command("biffle")]
        public async Task DoAutoBiffle()
        {
            await ReplyAsync($"{ Context.User.Mention } se biffle!");
        }

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


        //doigt command
        [Command("doigt")]
        public async Task DoJul()
        {
            await ReplyAsync($"{ Context.User.Mention } fait le signe de Jul...Quel merde https://media2.giphy.com/media/afqT2ykIlYcVi/200w.gif");
        }

        [Command("doigt")]
        public async Task DoDoigt(SocketGuildUser user)
        {
            await ReplyAsync($"{ Context.User.Mention } fait un doigt a { user.Mention }");
        }


        //olive command
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

        //calin command
        [Command("calin")]
        public async Task DoCalin()
        {
            await ReplyAsync($"{ Context.User.Mention } me fait un calin! C'est mignon https://media3.giphy.com/media/7hW7hXXri33NK/200w.gif");
        }

        [Command("calin")]
        public async Task DoCalinA(SocketGuildUser user)
        {
            await ReplyAsync($"{ Context.User.Mention } fait un calin a { user.Mention }!");
        }

        [Command("test")]
        public async Task TestCommand()
        {
            
        }
    }
}
