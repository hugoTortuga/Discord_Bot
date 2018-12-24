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
            var embed = new EmbedBuilder();
            embed.WithColor(0, 0, 0);
            embed.WithImageUrl("https://media2.giphy.com/media/afqT2ykIlYcVi/200w.gif");

            await Context.Channel.SendMessageAsync($"{ Context.User.Mention } fait le signe de Jul...Petite merde !!!", false, embed);
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
            string[] link = new string[3]
            {
                "https://media1.tenor.com/images/506aa95bbb0a71351bcaa753eaa2a45c/tenor.gif?itemid=7552075",
                "https://media1.tenor.com/images/11889c4c994c0634cfcedc8adba9dd6c/tenor.gif?itemid=5634578",
                "https://media1.tenor.com/images/d6510db0a868cfbff697d7279aa89b61/tenor.gif?itemid=10989534"
            };

            int i = 0;
            System.Random rnd = new System.Random(DateTime.Now.Millisecond);
            i = rnd.Next(0, 5);

            var embed = new EmbedBuilder();
            embed.WithColor(0, 0, 0);
            embed.WithImageUrl(link[i]);

            await Context.Channel.SendMessageAsync($"{ Context.User.Mention } me fait un calin! C'est mignon!", false, embed);
        }

        [Command("calin")]
        public async Task DoCalinA(SocketGuildUser user)
        {
            await ReplyAsync($"{ Context.User.Mention } fait un calin a { user.Mention }!");
        }

        [Command("ping")]
        public async Task TestCommand()
        {
            await ReplyAsync("ping");
        }
    }
}
