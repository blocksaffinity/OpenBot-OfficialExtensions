using OpenBot.API;
using OpenBot.API.Modules;

namespace EventLogger;

public class EventLoggerExtension : Extension
{
    public EventLoggerExtension(ExtensionContext ctx) : base(ctx)
    {
        
    }


    protected override async Task OnStartAsync()
    {
        Context.DiscordModule.Client.UserJoined += (user) => 
        {
            Logger.Info($"{user.Username} joined {user.Guild.Name}");
            return Task.CompletedTask;
        };

        Context.DiscordModule.Client.UserJoined += (user) => 
        {
            Logger.Info($"{user.Username} joined {user.Guild.Name}");
            return Task.CompletedTask;
        };
    }
}
