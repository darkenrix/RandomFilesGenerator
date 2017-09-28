using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomFilesGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var parser = CmdLineReader.Init();
            var config = parser.Parse(args);

            if (config.HasErrors)
            {
                CmdLineReader.PrintHelp();
                return;
            }

            (new FilesGenerator(parser.Object.FileName, parser.Object.Size)).GenerateRandomFile();
        }
    }
}
