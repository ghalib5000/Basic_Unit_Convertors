using CliFx;
using CliFx.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Unit_Convertors.Functions
{
    [Command("pow")]
    public class PowCommand : ICommand
    {

        [CommandParameter(0, Description = "value of which to find the power of")]
        public double Value { get; set; }

        [CommandOption("power", 'p', Description = "power of")]
        public double pow { get; set; } = 2;

        public ValueTask ExecuteAsync(IConsole console)
        {

            var res2 = Math.Pow(Value, pow);

            console.Output.WriteLine(res2);

            return default;
        }
    }
}
