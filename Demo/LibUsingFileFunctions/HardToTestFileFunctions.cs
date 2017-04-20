using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibUsingFileFunctions.HardToTest
{
    public class FileHandling
    {
        public FileHandling()
        {
            
        }

        public IEnumerable<string> CheckFilesInSomeDirectory(string path)
        {
            var current = Directory.GetCurrentDirectory();
            var filesHereAndBelow = Directory.GetFiles(current, "*.*", SearchOption.AllDirectories).ToList();
            return filesHereAndBelow;
        }

        public string ReadAllLinesFromAFile(string path)
        {
            if (!File.Exists(path))
                return "";
            var txt = File.ReadAllText(path);
            return txt;
        }

    }
}
