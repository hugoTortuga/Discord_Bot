using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using Discord;

namespace Discord_Bot.Module.Bot_Admin
{
    [Group("help")]
    public class Help : ModuleBase<SocketCommandContext>
    {
        [Command("")]
        public async Task HelpGlobal()
        {
            await ReplyAsync("Je vous offre de nombreuses possibilités, grâce à la commande help [command], accedez au info detailler.");
            await ReplyAsync("Voici les commandes : \n" +
                "- random\n" +
                "- action\n");

            var embed = new EmbedBuilder();
            embed.WithColor(0, 0, 255);
            embed.WithImageUrl("https://media.giphy.com/media/j98SQB5Y7WqnC/giphy.gif");
            await ReplyAsync("Amuses-toi bien", false, embed);
        }

        [Command("random")]
        public async Task HelpRandom()
        {
            await ReplyAsync("- random : je posterais une image au hasard, a tes risques et periles.\n" +
                "- random add NSFW [link] : J'ajouterais ton fantasme dans ma mémoire.\n" +
                "- random add troll [link] : J'ajouterais ta blague, même si elle est nul.");
        }

        [Command("action")]
        public async Task HelpAction()
        {
            await ReplyAsync("- do biffle [-optional user] : Permet de biffler quelqu'un!\n" +
                "- do doigt [-optional user] : Qui sait ce que ca fait^^\n" +
                "- do olive [-optional user] : Assez explicite je pense\n" +
                "- do calin [-optional user] : Que c'est mignon! Un petit calin.");
        }
    }
}
