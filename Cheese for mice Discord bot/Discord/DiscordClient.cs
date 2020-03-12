using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Cheese_for_mice_Discord_bot.Discord
{
    public class DiscordClient
    {
        public string Prefix { get; set; }
        private string Token { get; set; }
        public DiscordSocketClient Client { get; set; }
        public CommandService Commands { get; set; }
        private IServiceProvider Services { get; set; }

        public DiscordClient(string prefix, string token)
        {
            Client = new DiscordSocketClient();
            Commands = new CommandService();
            Services = new ServiceCollection().AddSingleton(Client).AddSingleton(Commands).BuildServiceProvider();
            Prefix = prefix;
            Token = token;
            Client.Log += Log;
            Client.Ready += OnReady;
        }

       
        public async Task Run()
        {
            Client.MessageReceived += HandleCommandAsync;
            await Commands.AddModulesAsync(Assembly.GetEntryAssembly(), Services);
            await Client.LoginAsync(TokenType.Bot, Token);
            await Client.StartAsync();
            await Task.Delay(-1);
        }

        private async Task OnReady()
        {
            Console.WriteLine($"{Client.CurrentUser} is ready");
            HelpInterface.Initialize();
            await Task.CompletedTask;
        }
        

        private async Task Log(LogMessage arg)
        {
            Console.WriteLine(arg);
            await Task.CompletedTask;
        }

        private async Task HandleCommandAsync(SocketMessage arg)
        {
            var message = arg as SocketUserMessage;
            if (message is null || message.Author.IsBot || message.Author.IsWebhook)
                return;
            int argPos = 0;
            if (message.HasStringPrefix(Prefix, ref argPos) || message.HasMentionPrefix(Client.CurrentUser, ref argPos))
            {
                var context = new SocketCommandContext(Client, message);
                await Commands.ExecuteAsync(context, argPos, Services);
                return;
            }
        }     
    }

}
