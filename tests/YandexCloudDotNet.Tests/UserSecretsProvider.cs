using Microsoft.Extensions.Configuration;

namespace YandexCloudDotNet.Tests
{
    public class UserSecretsProvider
    {
        private readonly IConfiguration configuration;

        public UserSecretsProvider()
        {
            configuration = new ConfigurationBuilder()
                            .AddUserSecrets<UserSecretsProvider>()
                            .Build();
        }

        public string Get(string key)
        {
            return configuration[key];
        }
    }
}
