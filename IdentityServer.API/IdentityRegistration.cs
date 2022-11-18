namespace IdentityServer.Web;

public static class IdentityRegistration
{
    public static WebApplicationBuilder AddIdentityServices(this WebApplicationBuilder services)
    {
        services.Services.AddIdentityServer()
            .AddInMemoryApiResources(Config.GetApiResources())
            .AddInMemoryApiScopes(Config.GetApiScopes())
            .AddInMemoryClients(Config.GetClients())
            .AddInMemoryIdentityResources(Config.GetIdentityResources())
            .AddTestUsers(Config.GetTestUsers())
            .AddDeveloperSigningCredential();

        return services;
    }
}