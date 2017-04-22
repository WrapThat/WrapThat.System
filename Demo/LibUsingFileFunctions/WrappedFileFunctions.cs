using System.Collections.Generic;
using System.IO;
using System.Linq;
using WrapThat.SystemBase;
using WrapThat.SystemIO;
using Directory = WrapThat.SystemIO.Directory;
using File = WrapThat.SystemIO.File;

namespace LibUsingFileFunctions.Wrapped
{

    public class FileHandling
    {
        // Add the two properties
        public IDirectory Directory { get; }
        public IFile File { get; }


        // Initialize it in the ctor

        public FileHandling(ISystemIO systemIo = null)
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

        public bool FileExist(string path)
        {
            return File.Exists(path);
        }

    }

    public class ConcoleBasedLib
    {
        private readonly WrapThat.SystemBase.IConsole Console;
        public ConcoleBasedLib(WrapThat.SystemBase.IConsole console)
        {
            Console = console ?? new Console();
        }

        public void WeWrite()
        {
            Console.WriteLine("Whatever");
        }

        public void WeRead()
        {
            var txt = Console.ReadLine();
            Console.WriteLine(txt+" indeed!");
        }

    }

}
