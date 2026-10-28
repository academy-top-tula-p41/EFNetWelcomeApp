using Microsoft.Extensions.Configuration;

var config = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .Build();
string? connectionString = config.GetConnectionString("DefaultConnection");

