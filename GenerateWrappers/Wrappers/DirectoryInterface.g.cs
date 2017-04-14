// WrapThat library for System.IO.Directory
  using System.Collections.Generic;

namespace WrapThat.SystemIO {
 
public partial interface IDirectory
{
System.IO.DirectoryInfo GetParent(string path);
System.IO.DirectoryInfo CreateDirectory(string path);
System.IO.DirectoryInfo CreateDirectory(string path,System.Security.AccessControl.DirectorySecurity directorySecurity);
bool Exists(string path);
void SetCreationTime(string path,System.DateTime creationTime);
void SetCreationTimeUtc(string path,System.DateTime creationTimeUtc);
System.DateTime GetCreationTime(string path);
System.DateTime GetCreationTimeUtc(string path);
void SetLastWriteTime(string path,System.DateTime lastWriteTime);
void SetLastWriteTimeUtc(string path,System.DateTime lastWriteTimeUtc);
System.DateTime GetLastWriteTime(string path);
System.DateTime GetLastWriteTimeUtc(string path);
void SetLastAccessTime(string path,System.DateTime lastAccessTime);
void SetLastAccessTimeUtc(string path,System.DateTime lastAccessTimeUtc);
System.DateTime GetLastAccessTime(string path);
System.DateTime GetLastAccessTimeUtc(string path);
System.Security.AccessControl.DirectorySecurity GetAccessControl(string path);
System.Security.AccessControl.DirectorySecurity GetAccessControl(string path,System.Security.AccessControl.AccessControlSections includeSections);
void SetAccessControl(string path,System.Security.AccessControl.DirectorySecurity directorySecurity);
string[] GetFiles(string path);
string[] GetFiles(string path,string searchPattern);
string[] GetFiles(string path,string searchPattern,System.IO.SearchOption searchOption);
string[] GetDirectories(string path);
string[] GetDirectories(string path,string searchPattern);
string[] GetDirectories(string path,string searchPattern,System.IO.SearchOption searchOption);
string[] GetFileSystemEntries(string path);
string[] GetFileSystemEntries(string path,string searchPattern);
string[] GetFileSystemEntries(string path,string searchPattern,System.IO.SearchOption searchOption);
IEnumerable<System.String> EnumerateDirectories(string path);
IEnumerable<System.String> EnumerateDirectories(string path,string searchPattern);
IEnumerable<System.String> EnumerateDirectories(string path,string searchPattern,System.IO.SearchOption searchOption);
IEnumerable<System.String> EnumerateFiles(string path);
IEnumerable<System.String> EnumerateFiles(string path,string searchPattern);
IEnumerable<System.String> EnumerateFiles(string path,string searchPattern,System.IO.SearchOption searchOption);
IEnumerable<System.String> EnumerateFileSystemEntries(string path);
IEnumerable<System.String> EnumerateFileSystemEntries(string path,string searchPattern);
IEnumerable<System.String> EnumerateFileSystemEntries(string path,string searchPattern,System.IO.SearchOption searchOption);
string[] GetLogicalDrives();
string GetDirectoryRoot(string path);
string GetCurrentDirectory();
void SetCurrentDirectory(string path);
void Move(string sourceDirName,string destDirName);
void Delete(string path);
void Delete(string path,bool recursive);
}}
