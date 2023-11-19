﻿using IdentityServer4;
using IdentityServer4.Models;

namespace IdentityServer
{
    public class Config
    {
        public static IEnumerable<ApiScope> ApiScopes =>
           new List<ApiScope>
           {
                new ApiScope("WeatherCheckApi", "My API")
           };

        public static IEnumerable<Client> Clients =>
            new List<Client>
            {


                 new Client
                {
                    ClientId = "client",

                    // no interactive user, use the clientid/secret for authentication
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,

                    // secret for authentication
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },

                    // scopes that client has access to
                    AllowedScopes = { 
                         "WeatherCheckApi", 
                         IdentityServerConstants.StandardScopes.OpenId, 
                         IdentityServerConstants.StandardScopes.Profile, 
                         IdentityServerConstants.StandardScopes.Email 
                     }

                },
            };

        public static IEnumerable<IdentityResource> IdentityResource =>
            new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email(),
            };

        public static IEnumerable<ApiResource> ApiResources => new List<ApiResource>
        {
            new ApiResource("WeatherCheckApi", "Check the weather API")
            {
                // Additional configuration if needed
                // Scopes, UserClaims, etc.
               Scopes = { "WeatherCheckApi" }
            }
        };
    }
}
