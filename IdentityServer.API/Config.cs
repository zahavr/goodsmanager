using System.Diagnostics.Contracts;
using System.Security.Claims;
using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;

namespace IdentityServer.Web;

public static class Config
{
    public static IEnumerable<Client> GetClients()
    {
        return new List<Client>()
        {
            new Client()
            {
                ClientId = "goods-manager.identity",
                ClientSecrets = new[] { new Secret("test_secret".Sha512()) },
                AllowedGrantTypes = GrantTypes.ResourceOwnerPasswordAndClientCredentials,
                AllowedScopes = { IdentityServerConstants.StandardScopes.OpenId, "goods-manager.api", "roles" }
            },
            new Client()
            {
                ClientName = "Goods manager UI",
                ClientId = "goods-manager.front-end",
                ClientUri = "http://localhost:3000",
                AllowedGrantTypes = GrantTypes.Implicit,
                RequireClientSecret = false,
                RedirectUris = { "http://localhost:3000/signin-oidc" },
                PostLogoutRedirectUris = {"http://localhost:3000/signout-oidc"},
                AllowedCorsOrigins = { "http://localhost:3000"},
                AllowedScopes = { IdentityServerConstants.StandardScopes.OpenId, IdentityServerConstants.StandardScopes.Profile, "goods-manager.api" },
                AllowAccessTokensViaBrowser = true
            },
        };
    }

    public static List<TestUser> GetTestUsers()
    {
        return new List<TestUser>()
        {
            new TestUser
            {
                SubjectId = "a9ea0f25-b964-409f-bcce-c923266249b4",
                Username = "Mick",
                Password = "MickPassword",
                Claims = new List<Claim>
                {
                    new Claim("given_name", "Mick"),
                    new Claim("family_name", "Mining"),
                    new Claim("address", "Sunny Street 4"),
                    new Claim("role", "Admin")
                }
            },
            new TestUser
            {
                SubjectId = "c95ddb8c-79ec-488a-a485-fe57a1462340",
                Username = "Jane",
                Password = "JanePassword",
                Claims = new List<Claim>
                {
                    new Claim("given_name", "Jane"),
                    new Claim("family_name", "Downing"),
                    new Claim("address", "Sunny Street 3"),
                    new Claim("role", "Visitor")
                }
            }
        };
    }

    public static IEnumerable<IdentityResource> GetIdentityResources()
    {
        return new List<IdentityResource>()
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
            new IdentityResources.Address(),
            new IdentityResource("roles", "User role(s)", new List<string> { "role" })
        };
    }

    public static IEnumerable<ApiScope> GetApiScopes() => new List<ApiScope>()
    {
        new ApiScope("goods-manager.api", "Goods Manager API")
    };

    public static IEnumerable<ApiResource> GetApiResources() => new List<ApiResource>()
    {
        new ApiResource("goods-manager.api", "Goods Manager API")
        {
            Scopes = {"goods-manager.api"}
        }
    };

}