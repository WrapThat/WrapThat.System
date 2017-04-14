using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WrapThat.SystemIO
{
    public partial interface IDirectory
    {
        IEnumerable<string> EnumerateFileSystemEntries(string path);

        IEnumerable<string> EnumerateFileSystemEntries(string path,string searchPattern);

        IEnumerable<string> EnumerateFileSystemEntries(string path,string searchPattern,SearchOption searchOption);

    }
}
