// WrapThat library for System.IO.File
  
namespace WrapThat.SystemIO {
 
public partial class File: IFile 
{
public void AppendAllText(string path,string contents) => System.IO.File.AppendAllText(path,contents);
public void AppendAllText(string path,string contents,System.Text.Encoding encoding) => System.IO.File.AppendAllText(path,contents,encoding);
public void AppendText(string path) => System.IO.File.AppendText(path);
public void Copy(string sourceFileName,string destFileName) => System.IO.File.Copy(sourceFileName,destFileName);
public void Copy(string sourceFileName,string destFileName,bool overwrite) => System.IO.File.Copy(sourceFileName,destFileName,overwrite);
public System.IO.FileStream Create(string path) => System.IO.File.Create(path);
public System.IO.FileStream Create(string path,int bufferSize) => System.IO.File.Create(path,bufferSize);
public void Create(string path,int bufferSize,System.IO.FileOptions options) => System.IO.File.Create(path,bufferSize,options);
public void Create(string path,int bufferSize,System.IO.FileOptions options,System.Security.AccessControl.FileSecurity fileSecurity) => System.IO.File.Create(path,bufferSize,options,fileSecurity);
public System.IO.StreamWriter CreateText(string path) => System.IO.File.CreateText(path);
public void Decrypt(string path) => System.IO.File.Decrypt(path);
public void Delete(string path) => System.IO.File.Delete(path);
public void Encrypt(string path) => System.IO.File.Encrypt(path);
public bool Exists(string path) => System.IO.File.Exists(path);
public System.Security.AccessControl.FileSecurity GetAccessControl(string path) => System.IO.File.GetAccessControl(path);
public System.Security.AccessControl.FileSecurity GetAccessControl(string path,System.Security.AccessControl.AccessControlSections includeSections) => System.IO.File.GetAccessControl(path,includeSections);
public System.IO.FileAttributes GetAttributes(string path) => System.IO.File.GetAttributes(path);
public System.DateTime GetCreationTime(string path) => System.IO.File.GetCreationTime(path);
public System.DateTime GetCreationTimeUtc(string path) => System.IO.File.GetCreationTimeUtc(path);
public System.DateTime GetLastAccessTime(string path) => System.IO.File.GetLastAccessTime(path);
public System.DateTime GetLastAccessTimeUtc(string path) => System.IO.File.GetLastAccessTimeUtc(path);
public System.DateTime GetLastWriteTime(string path) => System.IO.File.GetLastWriteTime(path);
public System.DateTime GetLastWriteTimeUtc(string path) => System.IO.File.GetLastWriteTimeUtc(path);
public void Move(string sourceFileName,string destFileName) => System.IO.File.Move(sourceFileName,destFileName);
public System.IO.FileStream Open(string path,System.IO.FileMode mode) => System.IO.File.Open(path,mode);
public System.IO.FileStream Open(string path,System.IO.FileMode mode,System.IO.FileAccess access) => System.IO.File.Open(path,mode,access);
public System.IO.FileStream Open(string path,System.IO.FileMode mode,System.IO.FileAccess access,System.IO.FileShare share) => System.IO.File.Open(path,mode,access,share);
public System.IO.FileStream OpenRead(string path) => System.IO.File.OpenRead(path);
public System.IO.StreamReader OpenText(string path) => System.IO.File.OpenText(path);
public System.IO.FileStream OpenWrite(string path) => System.IO.File.OpenWrite(path);
public void ReadAllBytes(string path) => System.IO.File.ReadAllBytes(path);
public void ReadAllLines(string path) => System.IO.File.ReadAllLines(path);
public void ReadAllLines(string path,System.Text.Encoding encoding) => System.IO.File.ReadAllLines(path,encoding);
public void ReadAllText(string path) => System.IO.File.ReadAllText(path);
public void ReadAllText(string path,System.Text.Encoding encoding) => System.IO.File.ReadAllText(path,encoding);
public void Replace(string sourceFileName,string destinationFileName,string destinationBackupFileName) => System.IO.File.Replace(sourceFileName,destinationFileName,destinationBackupFileName);
public void Replace(string sourceFileName,string destinationFileName,string destinationBackupFileName,bool ignoreMetadataErrors) => System.IO.File.Replace(sourceFileName,destinationFileName,destinationBackupFileName,ignoreMetadataErrors);
public void SetAccessControl(string path,System.Security.AccessControl.FileSecurity fileSecurity) => System.IO.File.SetAccessControl(path,fileSecurity);
public void SetAttributes(string path,System.IO.FileAttributes fileAttributes) => System.IO.File.SetAttributes(path,fileAttributes);
public void SetCreationTime(string path,System.DateTime creationTime) => System.IO.File.SetCreationTime(path,creationTime);
public void SetCreationTimeUtc(string path,System.DateTime creationTimeUtc) => System.IO.File.SetCreationTimeUtc(path,creationTimeUtc);
public void SetLastAccessTime(string path,System.DateTime lastAccessTime) => System.IO.File.SetLastAccessTime(path,lastAccessTime);
public void SetLastAccessTimeUtc(string path,System.DateTime lastAccessTimeUtc) => System.IO.File.SetLastAccessTimeUtc(path,lastAccessTimeUtc);
public void SetLastWriteTime(string path,System.DateTime lastWriteTime) => System.IO.File.SetLastWriteTime(path,lastWriteTime);
public void SetLastWriteTimeUtc(string path,System.DateTime lastWriteTimeUtc) => System.IO.File.SetLastWriteTimeUtc(path,lastWriteTimeUtc);
public void WriteAllBytes(string path,System.Byte[] bytes) => System.IO.File.WriteAllBytes(path,bytes);
public void WriteAllLines(string path,string[] contents) => System.IO.File.WriteAllLines(path,contents);
public void WriteAllLines(string path,string[] contents,System.Text.Encoding encoding) => System.IO.File.WriteAllLines(path,contents,encoding);
public void WriteAllText(string path,string contents) => System.IO.File.WriteAllText(path,contents);
public void WriteAllText(string path,string contents,System.Text.Encoding encoding) => System.IO.File.WriteAllText(path,contents,encoding);
}}
