using Serilog;
using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Configure Serilog
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console()
            .CreateLogger();

        while (true)
        {
            // Example logging
            Log.Information("Hello, Serilog! The current time is {Time}", DateTime.Now);

            // Wait for 1 second
            Thread.Sleep(1000);
        }

        // Ensure to flush and close the logger at the end of the program (this line will not be reached due to the infinite loop)
        // Log.CloseAndFlush();
    }
}
