using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ICT3101_Calculator
{
    public class FileReader : IFileReader
    {
        public string[] Read(string path) => File.ReadAllLines(path);
    }
}
