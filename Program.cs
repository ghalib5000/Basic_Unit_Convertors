using Basic_Unit_Convertors.Functions;
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

    //TODO:length convertors
    //TODO:price rates using realtime prices



   
}

