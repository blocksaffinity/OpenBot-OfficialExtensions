using Discord.WebSocket;
using OpenBot.API;
using OpenBot.API.Modules;

namespace Welcomer;

public class WelcomerExtension : Extension
{
    private IDiscordModule? discord;
    public WelcomerExtension(ExtensionContext ctx) : base(ctx)
    {
        
    }

    protected override async Task OnRegisterAsync()
    {
        discord = Context.Modules.Get<IDiscordModule>();
        if (discord is null)
        {
            Logger.Error("Failed to get Discord module, cannot register events.");
        }
        else
        {
            Logger.Info("Hooked into Discord module.");
        }
    }

    protected override async Task OnStartAsync()
    {
        discord?.Client.UserJoined += OnUserJoined;
    }

    private Task OnUserJoined(SocketGuildUser user)
    {
        Logger.Info($"{user.Username} joined {user.Guild.Name}");
        return Task.CompletedTask;
    }
}
