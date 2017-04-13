// WrapThat library for System.IO.Directory
  
namespace WrapThat.SystemIO {
 
public partial class Directory: IDirectory 
{
public System.IO.DirectoryInfo CreateDirectory(string path) => System.IO.Directory.CreateDirectory(path);
public System.IO.DirectoryInfo CreateDirectory(string path,System.Security.AccessControl.DirectorySecurity directorySecurity) => System.IO.Directory.CreateDirectory(path,directorySecurity);
public void Delete(string path) => System.IO.Directory.Delete(path);
public void Delete(string path,System.Boolean recursive) => System.IO.Directory.Delete(path,recursive);
public void Exists(string path) => System.IO.Directory.Exists(path);
public System.Security.AccessControl.DirectorySecurity GetAccessControl(string path) => System.IO.Directory.GetAccessControl(path);
public System.Security.AccessControl.DirectorySecurity GetAccessControl(string path,System.Security.AccessControl.AccessControlSections includeSections) => System.IO.Directory.GetAccessControl(path,includeSections);
public System.DateTime GetCreationTime(string path) => System.IO.Directory.GetCreationTime(path);
public System.DateTime GetCreationTimeUtc(string path) => System.IO.Directory.GetCreationTimeUtc(path);
public void GetCurrentDirectory() => System.IO.Directory.GetCurrentDirectory();
public void GetDirectories(string path) => System.IO.Directory.GetDirectories(path);
public void GetDirectories(string path,string searchPattern) => System.IO.Directory.GetDirectories(path,searchPattern);
public void GetDirectories(string path,string searchPattern,System.IO.SearchOption searchOption) => System.IO.Directory.GetDirectories(path,searchPattern,searchOption);
public void GetDirectoryRoot(string path) => System.IO.Directory.GetDirectoryRoot(path);
public void GetFiles(string path) => System.IO.Directory.GetFiles(path);
public void GetFiles(string path,string searchPattern) => System.IO.Directory.GetFiles(path,searchPattern);
public void GetFiles(string path,string searchPattern,System.IO.SearchOption searchOption) => System.IO.Directory.GetFiles(path,searchPattern,searchOption);
public void GetFileSystemEntries(string path) => System.IO.Directory.GetFileSystemEntries(path);
public void GetFileSystemEntries(string path,string searchPattern) => System.IO.Directory.GetFileSystemEntries(path,searchPattern);
public System.DateTime GetLastAccessTime(string path) => System.IO.Directory.GetLastAccessTime(path);
public System.DateTime GetLastAccessTimeUtc(string path) => System.IO.Directory.GetLastAccessTimeUtc(path);
public System.DateTime GetLastWriteTime(string path) => System.IO.Directory.GetLastWriteTime(path);
public System.DateTime GetLastWriteTimeUtc(string path) => System.IO.Directory.GetLastWriteTimeUtc(path);
public void GetLogicalDrives() => System.IO.Directory.GetLogicalDrives();
public void GetParent(string path) => System.IO.Directory.GetParent(path);
public void Move(string sourceDirName,string destDirName) => System.IO.Directory.Move(sourceDirName,destDirName);
public void SetAccessControl(string path,System.Security.AccessControl.DirectorySecurity directorySecurity) => System.IO.Directory.SetAccessControl(path,directorySecurity);
public void SetCreationTime(string path,System.DateTime creationTime) => System.IO.Directory.SetCreationTime(path,creationTime);
public void SetCreationTimeUtc(string path,System.DateTime creationTimeUtc) => System.IO.Directory.SetCreationTimeUtc(path,creationTimeUtc);
public void SetCurrentDirectory(string path) => System.IO.Directory.SetCurrentDirectory(path);
public void SetLastAccessTime(string path,System.DateTime lastAccessTime) => System.IO.Directory.SetLastAccessTime(path,lastAccessTime);
public void SetLastAccessTimeUtc(string path,System.DateTime lastAccessTimeUtc) => System.IO.Directory.SetLastAccessTimeUtc(path,lastAccessTimeUtc);
public void SetLastWriteTime(string path,System.DateTime lastWriteTime) => System.IO.Directory.SetLastWriteTime(path,lastWriteTime);
public void SetLastWriteTimeUtc(string path,System.DateTime lastWriteTimeUtc) => System.IO.Directory.SetLastWriteTimeUtc(path,lastWriteTimeUtc);
}}
