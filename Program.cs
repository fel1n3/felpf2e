using DSharpPlus;
using DSharpPlus.Entities;
using DSharpPlus.SlashCommands;
using felpf2e.Models.Spells;
using Newtonsoft.Json;

namespace felpf2e
{
    class Bot
    {
        static void Main()
        {
            
            SpellData phantom_pain = JsonConvert.DeserializeObject<SpellData>(
                File.ReadAllText(@"..\..\..\data\packs\data\spells.db\phantom-pain.json"));
            

            Console.WriteLine(phantom_pain.system.description.value);
            
            
            
            MainAsync().GetAwaiter().GetResult();
        }

        static async Task MainAsync()
        {
            var token = Environment.GetEnvironmentVariable("DISCORD_TOKEN") ?? throw new InvalidOperationException();
            var client = new DiscordClient(new DiscordConfiguration()
            {
                Token = token,
                TokenType = TokenType.Bot,
                Intents = DiscordIntents.AllUnprivileged
            });

            const ulong guildId = 849540125310320640;
            
            var slash = client.UseSlashCommands();
            slash.RegisterCommands<SlashCommands>(guildId);

            await client.ConnectAsync();
            await Task.Delay(-1);
        }
    }

    public class SlashCommands : ApplicationCommandModule
    {
        [SlashCommand("test", "tests a testy test")]
        public async Task TestCommand(InteractionContext ctx, [Option("name", "name to test")] string? name = null)
        {
            var response = "nice test " + (name ?? "dude");

            await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
                new DiscordInteractionResponseBuilder().WithContent(response));
        }
        
    }
}