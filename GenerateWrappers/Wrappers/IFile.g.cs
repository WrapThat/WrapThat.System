// WrapThat library for System.IO.File
  
using System.Collections.Generic;
 
namespace WrapThat.SystemIO {
 
public partial interface IFile
{
System.IO.StreamReader OpenText(string path);
System.IO.StreamWriter CreateText(string path);
System.IO.StreamWriter AppendText(string path);
void Copy(string sourceFileName,string destFileName);
void Copy(string sourceFileName,string destFileName,bool overwrite);
System.IO.FileStream Create(string path);
System.IO.FileStream Create(string path,int bufferSize);
System.IO.FileStream Create(string path,int bufferSize,System.IO.FileOptions options);
// System.IO.FileStream Create(string path,int bufferSize,System.IO.FileOptions options,System.Security.AccessControl.FileSecurity fileSecurity);
void Delete(string path);
void Decrypt(string path);
void Encrypt(string path);
bool Exists(string path);
System.IO.FileStream Open(string path,System.IO.FileMode mode);
System.IO.FileStream Open(string path,System.IO.FileMode mode,System.IO.FileAccess access);
System.IO.FileStream Open(string path,System.IO.FileMode mode,System.IO.FileAccess access,System.IO.FileShare share);
void SetCreationTime(string path,System.DateTime creationTime);
void SetCreationTimeUtc(string path,System.DateTime creationTimeUtc);
System.DateTime GetCreationTime(string path);
System.DateTime GetCreationTimeUtc(string path);
void SetLastAccessTime(string path,System.DateTime lastAccessTime);
void SetLastAccessTimeUtc(string path,System.DateTime lastAccessTimeUtc);
System.DateTime GetLastAccessTime(string path);
System.DateTime GetLastAccessTimeUtc(string path);
void SetLastWriteTime(string path,System.DateTime lastWriteTime);
void SetLastWriteTimeUtc(string path,System.DateTime lastWriteTimeUtc);
System.DateTime GetLastWriteTime(string path);
System.DateTime GetLastWriteTimeUtc(string path);
System.IO.FileAttributes GetAttributes(string path);
void SetAttributes(string path,System.IO.FileAttributes fileAttributes);
// System.Security.AccessControl.FileSecurity GetAccessControl(string path);
// System.Security.AccessControl.FileSecurity GetAccessControl(string path,System.Security.AccessControl.AccessControlSections includeSections);
// void SetAccessControl(string path,System.Security.AccessControl.FileSecurity fileSecurity);
System.IO.FileStream OpenRead(string path);
System.IO.FileStream OpenWrite(string path);
string ReadAllText(string path);
string ReadAllText(string path,System.Text.Encoding encoding);
void WriteAllText(string path,string contents);
void WriteAllText(string path,string contents,System.Text.Encoding encoding);
System.Byte[] ReadAllBytes(string path);
void WriteAllBytes(string path,System.Byte[] bytes);
string[] ReadAllLines(string path);
string[] ReadAllLines(string path,System.Text.Encoding encoding);
IEnumerable<string> ReadLines(string path);
IEnumerable<string> ReadLines(string path,System.Text.Encoding encoding);
void WriteAllLines(string path,string[] contents);
void WriteAllLines(string path,string[] contents,System.Text.Encoding encoding);
void WriteAllLines(string path,IEnumerable<string> contents);
void WriteAllLines(string path,IEnumerable<string> contents,System.Text.Encoding encoding);
void AppendAllText(string path,string contents);
void AppendAllText(string path,string contents,System.Text.Encoding encoding);
void AppendAllLines(string path,IEnumerable<string> contents);
void AppendAllLines(string path,IEnumerable<string> contents,System.Text.Encoding encoding);
void Move(string sourceFileName,string destFileName);
void Replace(string sourceFileName,string destinationFileName,string destinationBackupFileName);
void Replace(string sourceFileName,string destinationFileName,string destinationBackupFileName,bool ignoreMetadataErrors);
}}
