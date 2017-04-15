// WrapThat library for System.Console
  
using System.Collections.Generic;
 
namespace WrapThat.SystemBase {
 
public partial interface IConsole
{
void Beep();
void Beep(int frequency,int duration);
void Clear();
void ResetColor();
void MoveBufferArea(int sourceLeft,int sourceTop,int sourceWidth,int sourceHeight,int targetLeft,int targetTop);
void MoveBufferArea(int sourceLeft,int sourceTop,int sourceWidth,int sourceHeight,int targetLeft,int targetTop,char sourceChar,System.ConsoleColor sourceForeColor,System.ConsoleColor sourceBackColor);
void SetBufferSize(int width,int height);
void SetWindowSize(int width,int height);
void SetWindowPosition(int left,int top);
void SetCursorPosition(int left,int top);
System.ConsoleKeyInfo ReadKey();
System.ConsoleKeyInfo ReadKey(bool intercept);
System.IO.Stream OpenStandardError();
System.IO.Stream OpenStandardError(int bufferSize);
System.IO.Stream OpenStandardInput();
System.IO.Stream OpenStandardInput(int bufferSize);
System.IO.Stream OpenStandardOutput();
System.IO.Stream OpenStandardOutput(int bufferSize);
void SetIn(System.IO.TextReader newIn);
void SetOut(System.IO.TextWriter newOut);
void SetError(System.IO.TextWriter newError);
int Read();
string ReadLine();
void WriteLine();
void WriteLine(bool value);
void WriteLine(char value);
void WriteLine(char[] buffer);
void WriteLine(char[] buffer,int index,int count);
void WriteLine(decimal value);
void WriteLine(double value);
void WriteLine(float value);
void WriteLine(int value);
void WriteLine(uint value);
void WriteLine(long value);
void WriteLine(ulong value);
void WriteLine(object value);
void WriteLine(string value);
void WriteLine(string format,object arg0);
void WriteLine(string format,object arg0,object arg1);
void WriteLine(string format,object arg0,object arg1,object arg2);
void WriteLine(string format,object arg0,object arg1,object arg2,object arg3);
void WriteLine(string format,object[] arg);
void Write(string format,object arg0);
void Write(string format,object arg0,object arg1);
void Write(string format,object arg0,object arg1,object arg2);
void Write(string format,object arg0,object arg1,object arg2,object arg3);
void Write(string format,object[] arg);
void Write(bool value);
void Write(char value);
void Write(char[] buffer);
void Write(char[] buffer,int index,int count);
void Write(double value);
void Write(decimal value);
void Write(float value);
void Write(int value);
void Write(uint value);
void Write(long value);
void Write(ulong value);
void Write(object value);
void Write(string value);
}}
