# Adding nugets
dotnet add package Microsoft.Extensions.Configuration --version 2.2.0
dotnet add package Microsoft.Extensions.Configuration.Json
dotnet add package Microsoft.Extensions.Configuration.EnvironmentVariables --version 2.2.4
dotnet add package Microsoft.Extensions.Configuration.UserSecrets --version 2.2.0

# Run command
dotnet user-secrets set "SlackBotApiKey" "<key>"
