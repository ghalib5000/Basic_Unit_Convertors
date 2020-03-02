using CliFx;
using CliFx.Attributes;
using System;
using System.Threading.Tasks;

namespace Cli_Interface_Test
{

    class Program
    {
        public static async Task<int> Main() =>
         await new CliApplicationBuilder()
             .AddCommandsFromThisAssembly()
             .Build()
             .RunAsync();
    }

    //TODO:area
    //TODO:volume
    //TODO:length convertors
    //TODO:price rates using realtime prices

    [Command("log")]
    public class LogCommand : ICommand
    {
        [CommandParameter(0, Description = "Value whose logarithm is to be found.")]
        public double Value { get; set; }

        [CommandOption("base", 'b', Description = "Logarithm base.")]
        public double Base { get; set; } = 10;

        public ValueTask ExecuteAsync(IConsole console)
        {
            var result = Math.Log(Value, Base);
            console.Output.WriteLine(result);
            return default;
        }
    }

    [Command("pow")]
    public class PowCommand : ICommand
    {
        
        [CommandParameter(0, Description = "value of which to find the power of")]
        public double val1 { get; set; }

        [CommandOption("power", 'p', Description = "power of")]
        public double pow { get; set; } = 2;

        public ValueTask ExecuteAsync(IConsole console)
        {
            
            var res2 = Math.Pow(val1, pow);

            console.Output.WriteLine(res2);

            return default;
        }
    }
}

