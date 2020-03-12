using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cheese_for_mice_Discord_bot.Discord
{
    [Summary("Cmds")]
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("help")]
        public async Task Help() => await ReplyAsync(embed: HelpInterface.Embed);
        

        [Command("user")]
        public async Task GetMouse(params string[] username)            
            => await ManagerApi.GetMouseInformation(Context, string.Join(' ', username));

        [Command("suser")]
        public async Task SearchMouse(params string[] username)
            => await ManagerApi.SearchMouse(Context, string.Join(' ', username));

        [Command("tribe")]
        public async Task GetTribeByUser(params string[] tribename)
            => await ManagerApi.GetTribe(Context, string.Join(' ', tribename));

        [Command("tribeuser")]
        public async Task GetTribe(params string[] tribename)
            => await ManagerApi.GetTribeByUser(Context, string.Join(' ', tribename));

        [Command("stribe")]
        public async Task SearchTribeUser(params string[] tribename)
            => await ManagerApi.SearchTribes(Context, string.Join(' ', tribename));

    }
}
