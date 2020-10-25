using Microsoft.Extensions.Configuration;

namespace YandexCloudDotNet.Tests
{
    public class SecretsProvider
    {
        private readonly IConfiguration configuration;

        public SecretsProvider()
        {
            configuration = new ConfigurationBuilder()
                            .AddEnvironmentVariables("YANDEX_CLOUD_")
                            .Build();
        }

        public Secrets Get()
        {
            var env = configuration.Get<Env>();
            return new Secrets
                   {
                       ServiceAccountId = env.SERVICE_ACCOUNT_ID,
                       ApiKeyId = env.API_KEY_ID,
                       ApiKey = env.API_KEY,
                       AuthorizationKeyId = env.AUTHORIZATION_KEY_ID,
                       AuthorizationKeyPrivateKey = FormatPrivateKey(env.AUTHORIZATION_KEY_PRIVATE_KEY),
                       FolderId = env.FOLDER_ID,
                       AccessKeyId = env.ACCESS_KEY_ID,
                       AccessKey = env.ACCESS_KEY
                   };
        }

        private static string FormatPrivateKey(string key)
        {
            if (key.Contains('\n'))
            {
                return key;
            }

            const string begin = "-----BEGIN PRIVATE KEY-----";
            const string end = "-----END PRIVATE KEY-----";
            key = key.Replace(begin, "");
            key = key.Replace(end, "");
            key = key.Replace(" ", "\n");
            return begin + key + end;
        }

        public class Secrets
        {
            public string ServiceAccountId { get; set; }
            public string ApiKeyId { get; set; }
            public string ApiKey { get; set; }
            public string AuthorizationKeyId { get; set; }
            public string AuthorizationKeyPrivateKey { get; set; }
            public string FolderId { get; set; }
            public string AccessKeyId { get; set; }
            public string AccessKey { get; set; }
        }

        private class Env
        {
            public string SERVICE_ACCOUNT_ID { get; set; }
            public string API_KEY_ID { get; set; }
            public string API_KEY { get; set; }
            public string AUTHORIZATION_KEY_ID { get; set; }
            public string AUTHORIZATION_KEY_PRIVATE_KEY { get; set; }
            public string FOLDER_ID { get; set; }
            public string ACCESS_KEY_ID { get; set; }
            public string ACCESS_KEY { get; set; }
        }
    }
}
