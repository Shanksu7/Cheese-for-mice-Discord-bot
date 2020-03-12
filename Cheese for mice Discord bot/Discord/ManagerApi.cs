using API_Library.Manager;
using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheese_for_mice_Discord_bot.Discord
{
    class ManagerApi
    {
        static Color color = Color.Orange;

        internal static async Task GetMouseInformation(SocketCommandContext context, string username)
        {
            var user = await MouseManager.GetMouse(username);
            var _embed = new EmbedBuilder()
                .WithAuthor(context.User)
                .WithColor(color)
                .AddField("User", user.Name)
                .AddField("Tribe", user.Tribe_Name)
                .AddField("Cheese Gathered", user.Cheese_Gathered)
                .WithCurrentTimestamp()
                .Build();
            await context.Channel.SendMessageAsync(embed: _embed);
        }

        internal static async Task SearchMouse(SocketCommandContext context, string filter)
        {
            var max = 10;
            var users = await MouseManager.SearchMice(filter);
            var builder = new EmbedBuilder()
               .WithAuthor(context.User)
               .WithColor(color)
               .WithCurrentTimestamp();
            var result = "";
            foreach (var username in users.Take(max))
                result += $"{username}\n";
            builder.WithDescription(result);
            await context.Channel.SendMessageAsync(embed: builder.Build());
        }

        internal static async Task GetTribe(SocketCommandContext context, string tribename)
        {
            var tribe = await TribeManager.GetTribe(tribename);
            var users = tribe.Members.Select(x => $"**{x.Name}**");
            var desc = string.Join('\n', users);
            var _embed = new EmbedBuilder()
               .WithAuthor(context.User)
               .WithColor(color)
               .WithTitle(tribe.Name)
               .AddField("Users", desc)
               .WithCurrentTimestamp()
               .Build();
            await context.Channel.SendMessageAsync(embed: _embed);
        }

        internal static async Task GetTribeByUser(SocketCommandContext context, string username)
        {
            var tribe = await TribeManager.GetTribeByUser(username);
            var users = tribe.Members.Select(x => $"**{x.Name}**");
            var desc = string.Join('\n', users);
            var _embed = new EmbedBuilder()
               .WithAuthor(context.User)
               .WithColor(color)
               .WithTitle(tribe.Name)
               .AddField("Users", desc)
               .WithCurrentTimestamp()
               .Build();
            await context.Channel.SendMessageAsync(embed: _embed);
        }

        internal static async Task SearchTribes(SocketCommandContext context, string username)
        {
            var tribe = await TribeManager.SearchTribe(username);            
            var users = tribe.Take(10).Select(x => x.Name);
            var desc = string.Join('\n', users);
            var _embed = new EmbedBuilder()
               .WithAuthor(context.User)
               .WithColor(color)
               .AddField("Tribes", desc)
               .WithCurrentTimestamp()
               .Build();
            await context.Channel.SendMessageAsync(embed: _embed);
        }

    }
}
