// WrapThat library for System.IO.Directory
  
namespace WrapThat.SystemIO {
 
public partial interface IDirectory
{
System.IO.DirectoryInfo CreateDirectory(string path);
System.IO.DirectoryInfo CreateDirectory(string path,System.Security.AccessControl.DirectorySecurity directorySecurity);
void Delete(string path);
void Delete(string path,bool recursive);
bool Exists(string path);
System.Security.AccessControl.DirectorySecurity GetAccessControl(string path);
System.Security.AccessControl.DirectorySecurity GetAccessControl(string path,System.Security.AccessControl.AccessControlSections includeSections);
System.DateTime GetCreationTime(string path);
System.DateTime GetCreationTimeUtc(string path);
void GetCurrentDirectory();
void GetDirectories(string path);
void GetDirectories(string path,string searchPattern);
void GetDirectories(string path,string searchPattern,System.IO.SearchOption searchOption);
void GetDirectoryRoot(string path);
void GetFiles(string path);
void GetFiles(string path,string searchPattern);
void GetFiles(string path,string searchPattern,System.IO.SearchOption searchOption);
void GetFileSystemEntries(string path);
void GetFileSystemEntries(string path,string searchPattern);
System.DateTime GetLastAccessTime(string path);
System.DateTime GetLastAccessTimeUtc(string path);
System.DateTime GetLastWriteTime(string path);
System.DateTime GetLastWriteTimeUtc(string path);
void GetLogicalDrives();
void GetParent(string path);
void Move(string sourceDirName,string destDirName);
void SetAccessControl(string path,System.Security.AccessControl.DirectorySecurity directorySecurity);
void SetCreationTime(string path,System.DateTime creationTime);
void SetCreationTimeUtc(string path,System.DateTime creationTimeUtc);
void SetCurrentDirectory(string path);
void SetLastAccessTime(string path,System.DateTime lastAccessTime);
void SetLastAccessTimeUtc(string path,System.DateTime lastAccessTimeUtc);
void SetLastWriteTime(string path,System.DateTime lastWriteTime);
void SetLastWriteTimeUtc(string path,System.DateTime lastWriteTimeUtc);
}}
