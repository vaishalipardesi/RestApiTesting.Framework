using Microsoft.Extensions.Configuration;
using System.IO;

namespace RestApiTesting.Framework.Helpers
{
    public class ConfigurationHelper
    {
        public static string TestApiUrl => ConfigurationRoot[nameof(TestApiUrl)];

        public static   IConfigurationRoot ConfigurationRoot { get; private set; }

        public static void BuildConfiguration()
        {
            if (ConfigurationRoot != null)
            {
                return;
            }

            IConfigurationBuilder builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("config.json", false).AddEnvironmentVariables();
            ConfigurationRoot = builder.Build();
        }
    }
}