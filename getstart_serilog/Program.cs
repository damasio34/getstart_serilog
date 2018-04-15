using Serilog;
using Serilog.Events;
using Serilog.Formatting.Json;
using System;

namespace getstart_serilog
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var log = new LoggerConfiguration()
            .WriteTo.File(new JsonFormatter(), "../../Log/log_file.json", LogEventLevel.Information)
            .WriteTo.Console()
            .CreateLogger())
            {
                var logObj = new LogObj("Program", "Ops ocorreu um erro");

                log.Information("Hello, Serilog!");
                log.Warning("Goodbye, Serilog.");
                log.Error<LogObj>("{@logObj}", logObj);
            }

            Console.ReadKey();
        }
    }
}
