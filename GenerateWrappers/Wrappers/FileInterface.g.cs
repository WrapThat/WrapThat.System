// WrapThat library for System.IO.File
  
namespace WrapThat.SystemIO {
 
public partial interface IFile
{
void AppendAllText(string path,string contents);
void AppendAllText(string path,string contents,System.Text.Encoding encoding);
void AppendText(string path);
void Copy(string sourceFileName,string destFileName);
void Copy(string sourceFileName,string destFileName,bool overwrite);
System.IO.FileStream Create(string path);
System.IO.FileStream Create(string path,int bufferSize);
void Create(string path,int bufferSize,System.IO.FileOptions options);
void Create(string path,int bufferSize,System.IO.FileOptions options,System.Security.AccessControl.FileSecurity fileSecurity);
System.IO.StreamWriter CreateText(string path);
void Decrypt(string path);
void Delete(string path);
void Encrypt(string path);
bool Exists(string path);
System.Security.AccessControl.FileSecurity GetAccessControl(string path);
System.Security.AccessControl.FileSecurity GetAccessControl(string path,System.Security.AccessControl.AccessControlSections includeSections);
System.IO.FileAttributes GetAttributes(string path);
System.DateTime GetCreationTime(string path);
System.DateTime GetCreationTimeUtc(string path);
System.DateTime GetLastAccessTime(string path);
System.DateTime GetLastAccessTimeUtc(string path);
System.DateTime GetLastWriteTime(string path);
System.DateTime GetLastWriteTimeUtc(string path);
void Move(string sourceFileName,string destFileName);
System.IO.FileStream Open(string path,System.IO.FileMode mode);
System.IO.FileStream Open(string path,System.IO.FileMode mode,System.IO.FileAccess access);
System.IO.FileStream Open(string path,System.IO.FileMode mode,System.IO.FileAccess access,System.IO.FileShare share);
System.IO.FileStream OpenRead(string path);
System.IO.StreamReader OpenText(string path);
System.IO.FileStream OpenWrite(string path);
void ReadAllBytes(string path);
void ReadAllLines(string path);
void ReadAllLines(string path,System.Text.Encoding encoding);
void ReadAllText(string path);
void ReadAllText(string path,System.Text.Encoding encoding);
void Replace(string sourceFileName,string destinationFileName,string destinationBackupFileName);
void Replace(string sourceFileName,string destinationFileName,string destinationBackupFileName,bool ignoreMetadataErrors);
void SetAccessControl(string path,System.Security.AccessControl.FileSecurity fileSecurity);
void SetAttributes(string path,System.IO.FileAttributes fileAttributes);
void SetCreationTime(string path,System.DateTime creationTime);
void SetCreationTimeUtc(string path,System.DateTime creationTimeUtc);
void SetLastAccessTime(string path,System.DateTime lastAccessTime);
void SetLastAccessTimeUtc(string path,System.DateTime lastAccessTimeUtc);
void SetLastWriteTime(string path,System.DateTime lastWriteTime);
void SetLastWriteTimeUtc(string path,System.DateTime lastWriteTimeUtc);
void WriteAllBytes(string path,System.Byte[] bytes);
void WriteAllLines(string path,string[] contents);
void WriteAllLines(string path,string[] contents,System.Text.Encoding encoding);
void WriteAllText(string path,string contents);
void WriteAllText(string path,string contents,System.Text.Encoding encoding);
}}
