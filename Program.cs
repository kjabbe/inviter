using System;
using Microsoft.Extensions.Configuration;

namespace inviter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var builder = new ConfigurationBuilder();
                //.SetBasePath(".")
                //.AddJsonFile("appsettings.json", 
                //     optional: false, 
                //     reloadOnChange: true)
                //.AddEnvironmentVariables();

            builder.AddUserSecrets<Program>();

            var Configuration = builder.Build();
            Console.WriteLine(Configuration["SlackBotApiKey"]);
        }
    }
}
