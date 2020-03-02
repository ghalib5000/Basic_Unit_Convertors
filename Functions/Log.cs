using CliFx;
using CliFx.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Unit_Convertors.Functions
{

    [Command("log")]
    public class LogCommand : ICommand
    {
        [CommandParameter(0, Description = "Value whose logarithm is to be found.")]
        public double Value { get; set; }

        [CommandOption("base", 'b', Description = "Logarithm base.")]
        public double Base { get; set; } = 10;

        public ValueTask ExecuteAsync(IConsole console)
        {
            console.Output.WriteLine(Math.Log(Value, Base));
            return default;
        }
    }
}
