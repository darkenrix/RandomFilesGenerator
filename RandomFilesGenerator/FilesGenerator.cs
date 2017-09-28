using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomFilesGenerator
{
    class FilesGenerator
    {
        private string _path;
        private int _sizeBytes;
        public FilesGenerator(string path, int sizeBytes)
        {
            _path = path;
            _sizeBytes = sizeBytes;
        }

        public void GenerateRandomFile()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(_path, FileMode.Create)))
            {
                var content = new byte[_sizeBytes];
                Random r = new Random();
                int rInt = r.Next(0, 100);
                r.NextBytes(content);
                writer.Write(content);
            }
        }
    }
}
