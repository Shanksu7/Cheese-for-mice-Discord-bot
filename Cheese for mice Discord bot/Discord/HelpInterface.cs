using Discord;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cheese_for_mice_Discord_bot.Discord
{
    public class HelpInterface
    {
        public static Embed Embed { get; set; }
        
        public static IEmote diamond = new Emoji("🔹");

        public static void Initialize()
        {
            //registering commands
            var dic = new Dictionary<string, List<string>>();
            var emoji = diamond;

            foreach (var module in Program.Client.Commands.Modules)
            {
                var sum = module.Summary; //Summary of the group
                if (!dic.ContainsKey(sum)) //We are grouping by Summary
                    dic.Add(sum, new List<string>());
                foreach (var _cmd in module.Commands)
                {
                    var cmd_to_add = (module.Group ?? "") + " " + _cmd.Name;
                    if (!dic[sum].Contains(cmd_to_add)) //if the group have already a command with the name, skip it
                        dic[sum].Add(cmd_to_add);
                }
            }

            var eb = new EmbedBuilder()
            .WithColor(Color.Green)
            .WithAuthor(Program.Client.Client.CurrentUser);
            foreach (var group in dic)            
                eb.AddField(group.Key, Indexing(group.Value, emoji));
            Embed = eb.Build();
        }
     
        static string Indexing(List<string> cmds, IEmote emote)
        {
            string result = "";
            foreach (var cmd in cmds)
                result += $"{(emote)} {cmd}\n";
            return result;
        }
    }
}