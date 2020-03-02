using CliFx;
using CliFx.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace Basic_Unit_Convertors.Functions
{
    
    // base command for accesing circle
    [Command("circle")]
    public class Circle : ICommand
    { 
        public ValueTask ExecuteAsync(IConsole console)
        {
            return default;
        }
    }

    //area of circle
    [Command("circle area")]
    public class cArea : ICommand
    {
        [CommandParameter(0, Description = "Radius of circle")]
        public double Radius { get; set; }

        public ValueTask ExecuteAsync(IConsole console)
        {
            console.Output.WriteLine(Math.PI * (Math.Pow(Radius, 2)));
            return default;
        }
    }
    //volume of circle
    [Command("circle volume")]
    public class cVolume : ICommand
    {
        [CommandParameter(0, Description = "Radius of circle")]
        public double Radius { get; set; }

        public ValueTask ExecuteAsync(IConsole console)
        {
            console.Output.WriteLine((4.0/3.0)*Math.PI*(Math.Pow(Radius,3)));
            return default;
        }
    }
}
