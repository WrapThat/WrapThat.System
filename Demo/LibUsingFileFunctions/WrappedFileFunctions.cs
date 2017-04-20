using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WrapThat.SystemIO;
using Directory = WrapThat.SystemIO.Directory;
using File = WrapThat.SystemIO.File;

namespace LibUsingFileFunctions
{

    public class WrappedFileFunctions
    {
        // Add the two properties
        public IDirectory Directory { get;  }
        public IFile File { get; }

        
        // Initialize it in the ctor

        public WrappedFileFunctions(ISystemIO systemIo=null)
        {
            Directory = systemIo?.Directory ?? new Directory();
            File = systemIo?.File ?? new File();
        }

        // No changes needed below here

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
