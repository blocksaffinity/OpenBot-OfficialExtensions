using OpenBot.API;
using OpenBot.API.Modules;

namespace Permissions;

public class PermissionsExtension : Extension
{
    public PermissionsExtension(ExtensionContext ctx) : base(ctx)
    {
        
    }

    protected override Task OnRegisterAsync()
    {
        this.Logger.Info("HELLO from the registered Permissions extension!");
        return Task.CompletedTask;
    }
}
