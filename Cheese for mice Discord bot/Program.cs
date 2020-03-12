using Cheese_for_mice_Discord_bot.Discord;
using System;
using System.Threading.Tasks;

namespace Cheese_for_mice_Discord_bot
{
    class Program
    {
        public static DiscordClient Client = new DiscordClient(".", "Njg3NTA1Nzk5Mjc0MTY4MzQz.Xmmw-Q.a3dfSjAmXnogUeHqdWVhRYYuf7U");
        static async Task Main(string[] args) => await Client.Run();
    }
}
