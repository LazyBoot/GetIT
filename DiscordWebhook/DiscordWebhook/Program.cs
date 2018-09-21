using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Webhook;
using Discord.WebSocket;
using Newtonsoft.Json;

namespace DiscordWebhook
{
    class Program
    {
        public static HttpClient Client = new HttpClient();
        private readonly DiscordSocketClient _client = new DiscordSocketClient();
        private static Tokens _tokens;

        public static void Main(string[] args)
        {
            _tokens = JsonConvert.DeserializeObject<Tokens>(File.ReadAllText(".token"));
            //=> new Program().MainAsync().GetAwaiter().GetResult();

            var client = new DiscordWebhookClient(_tokens.WebHookId, _tokens.WebHookToken);
            client.SendMessageAsync("Test", username: "testing");
        }

        public async Task MainAsync()
        {

            _client.Log += Log;

            var token = File.ReadAllText(".token");
            await _client.LoginAsync(TokenType.Bot, token);
            await _client.StartAsync();

            _client.MessageReceived += MessageReceived;

            //await Task.Delay(-1);
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey();
            } while (key.Key != ConsoleKey.Escape);

            await _client.StopAsync();
            await _client.LogoutAsync();
        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }

        private async Task MessageReceived(SocketMessage message)
        {
            switch (message.Content)
            {
                case "!ping":
                    await message.Channel.SendMessageAsync("Pong!");
                    break;
            }
        }

        private static void TestMessage()
        {
            var url =
                $"https://discordapp.com/api/webhooks/{_tokens.WebHookId}/{_tokens.WebHookToken}";

            var webHookJson = new WebhookJson();
            webHookJson.content = "test content";

            var content = new StringContent(JsonConvert.SerializeObject(webHookJson), Encoding.UTF8, "application/json");
            var result = Client.PostAsync(url, content);

            Console.WriteLine(result.Result);
        }
    }
}
