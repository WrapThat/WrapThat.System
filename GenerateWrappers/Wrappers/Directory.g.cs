// WrapThat library for System.IO.Directory
  
using System.Collections.Generic;
 
namespace WrapThat.SystemIO {
 
public partial class Directory: IDirectory 
{
public System.IO.DirectoryInfo GetParent(string path)  => System.IO.Directory.GetParent(path);
public System.IO.DirectoryInfo CreateDirectory(string path)  => System.IO.Directory.CreateDirectory(path);
public System.IO.DirectoryInfo CreateDirectory(string path,System.Security.AccessControl.DirectorySecurity directorySecurity)  => System.IO.Directory.CreateDirectory(path,directorySecurity);
public bool Exists(string path)  => System.IO.Directory.Exists(path);
public void SetCreationTime(string path,System.DateTime creationTime)  => System.IO.Directory.SetCreationTime(path,creationTime);
public void SetCreationTimeUtc(string path,System.DateTime creationTimeUtc)  => System.IO.Directory.SetCreationTimeUtc(path,creationTimeUtc);
public System.DateTime GetCreationTime(string path)  => System.IO.Directory.GetCreationTime(path);
public System.DateTime GetCreationTimeUtc(string path)  => System.IO.Directory.GetCreationTimeUtc(path);
public void SetLastWriteTime(string path,System.DateTime lastWriteTime)  => System.IO.Directory.SetLastWriteTime(path,lastWriteTime);
public void SetLastWriteTimeUtc(string path,System.DateTime lastWriteTimeUtc)  => System.IO.Directory.SetLastWriteTimeUtc(path,lastWriteTimeUtc);
public System.DateTime GetLastWriteTime(string path)  => System.IO.Directory.GetLastWriteTime(path);
public System.DateTime GetLastWriteTimeUtc(string path)  => System.IO.Directory.GetLastWriteTimeUtc(path);
public void SetLastAccessTime(string path,System.DateTime lastAccessTime)  => System.IO.Directory.SetLastAccessTime(path,lastAccessTime);
public void SetLastAccessTimeUtc(string path,System.DateTime lastAccessTimeUtc)  => System.IO.Directory.SetLastAccessTimeUtc(path,lastAccessTimeUtc);
public System.DateTime GetLastAccessTime(string path)  => System.IO.Directory.GetLastAccessTime(path);
public System.DateTime GetLastAccessTimeUtc(string path)  => System.IO.Directory.GetLastAccessTimeUtc(path);
public System.Security.AccessControl.DirectorySecurity GetAccessControl(string path)  => System.IO.Directory.GetAccessControl(path);
public System.Security.AccessControl.DirectorySecurity GetAccessControl(string path,System.Security.AccessControl.AccessControlSections includeSections)  => System.IO.Directory.GetAccessControl(path,includeSections);
public void SetAccessControl(string path,System.Security.AccessControl.DirectorySecurity directorySecurity)  => System.IO.Directory.SetAccessControl(path,directorySecurity);
public string[] GetFiles(string path)  => System.IO.Directory.GetFiles(path);
public string[] GetFiles(string path,string searchPattern)  => System.IO.Directory.GetFiles(path,searchPattern);
public string[] GetFiles(string path,string searchPattern,System.IO.SearchOption searchOption)  => System.IO.Directory.GetFiles(path,searchPattern,searchOption);
public string[] GetDirectories(string path)  => System.IO.Directory.GetDirectories(path);
public string[] GetDirectories(string path,string searchPattern)  => System.IO.Directory.GetDirectories(path,searchPattern);
public string[] GetDirectories(string path,string searchPattern,System.IO.SearchOption searchOption)  => System.IO.Directory.GetDirectories(path,searchPattern,searchOption);
public string[] GetFileSystemEntries(string path)  => System.IO.Directory.GetFileSystemEntries(path);
public string[] GetFileSystemEntries(string path,string searchPattern)  => System.IO.Directory.GetFileSystemEntries(path,searchPattern);
public string[] GetFileSystemEntries(string path,string searchPattern,System.IO.SearchOption searchOption)  => System.IO.Directory.GetFileSystemEntries(path,searchPattern,searchOption);
public IEnumerable<string> EnumerateDirectories(string path)  => System.IO.Directory.EnumerateDirectories(path);
public IEnumerable<string> EnumerateDirectories(string path,string searchPattern)  => System.IO.Directory.EnumerateDirectories(path,searchPattern);
public IEnumerable<string> EnumerateDirectories(string path,string searchPattern,System.IO.SearchOption searchOption)  => System.IO.Directory.EnumerateDirectories(path,searchPattern,searchOption);
public IEnumerable<string> EnumerateFiles(string path)  => System.IO.Directory.EnumerateFiles(path);
public IEnumerable<string> EnumerateFiles(string path,string searchPattern)  => System.IO.Directory.EnumerateFiles(path,searchPattern);
public IEnumerable<string> EnumerateFiles(string path,string searchPattern,System.IO.SearchOption searchOption)  => System.IO.Directory.EnumerateFiles(path,searchPattern,searchOption);
public IEnumerable<string> EnumerateFileSystemEntries(string path)  => System.IO.Directory.EnumerateFileSystemEntries(path);
public IEnumerable<string> EnumerateFileSystemEntries(string path,string searchPattern)  => System.IO.Directory.EnumerateFileSystemEntries(path,searchPattern);
public IEnumerable<string> EnumerateFileSystemEntries(string path,string searchPattern,System.IO.SearchOption searchOption)  => System.IO.Directory.EnumerateFileSystemEntries(path,searchPattern,searchOption);
public string[] GetLogicalDrives()  => System.IO.Directory.GetLogicalDrives();
public string GetDirectoryRoot(string path)  => System.IO.Directory.GetDirectoryRoot(path);
public string GetCurrentDirectory()  => System.IO.Directory.GetCurrentDirectory();
public void SetCurrentDirectory(string path)  => System.IO.Directory.SetCurrentDirectory(path);
public void Move(string sourceDirName,string destDirName)  => System.IO.Directory.Move(sourceDirName,destDirName);
public void Delete(string path)  => System.IO.Directory.Delete(path);
public void Delete(string path,bool recursive)  => System.IO.Directory.Delete(path,recursive);
}}
