using CliFx;
using CliFx.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Unit_Convertors.Functions
{
   
    // base command for accesing rectangle
  [Command("rectangle")]
    public class rectangle : ICommand
    {
        public ValueTask ExecuteAsync(IConsole console)
        {
            return default;
        }
    }

    //area of rectangle
    [Command("rectangle area")]
    public class sArea : ICommand
    {
        [CommandParameter(0, Description = "Wigdth of rectangle")]
        public double width { get; set; }

        [CommandParameter(1,Description = "Height of rectangle")]
        public double height { get; set; }
        public ValueTask ExecuteAsync(IConsole console)
        {
            console.Output.WriteLine(width * height);
            return default;
        }
    }
    //volume of rectangle
    [Command("rectangle volume")]
    public class sVolume : ICommand
    {
        [CommandParameter(0, Description = "Wigdth of rectangle")]
        public double width { get; set; }

        [CommandParameter(1, Description = "Height of rectangle")]
        public double height { get; set; }
        [CommandParameter(2, Description = "Length of rectangle")]
            public double length { get; set; }
        public ValueTask ExecuteAsync(IConsole console)
        {
            console.Output.WriteLine(width * height*length);
            return default;
        }
    }
}
