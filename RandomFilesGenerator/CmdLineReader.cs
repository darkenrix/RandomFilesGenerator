using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fclp;

namespace RandomFilesGenerator
{
    class CmdLineReader
    {
        public static IFluentCommandLineParser<RandomFilesGeneratorSettings> Init()
        {
            var parser = new FluentCommandLineParser<RandomFilesGeneratorSettings> { IsCaseSensitive = false };

            parser.SetupHelp("h");

            parser.Setup(x => x.FileName)
                  .As('f', "FilePath")
                  .Required()
                  .WithDescription("Path to the file to be created.");

            parser.Setup(x => x.Size)
                  .As('s', "FileSize")
                  .Required()
                  .WithDescription("Size of the file in bytes.");

            return parser;
        }

        public static void PrintHelp()
        {
            Console.WriteLine("RandomFilesGenerator help: -f <pathToFile> -s <FileSize>");            
        }
    }
}
