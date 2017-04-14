// WrapThat library for System.Console  (Namespace is SystemBase in order to avoid conflicts with using System)
  
namespace WrapThat.SystemBase {
 
public partial class Console: IConsole 
{
public void Beep() => System.Console.Beep();
public void Beep(int frequency,int duration) => System.Console.Beep(frequency,duration);
public void Clear() => System.Console.Clear();
public void MoveBufferArea(int sourceLeft,int sourceTop,int sourceWidth,int sourceHeight,int targetLeft,int targetTop) => System.Console.MoveBufferArea(sourceLeft,sourceTop,sourceWidth,sourceHeight,targetLeft,targetTop);
public void MoveBufferArea(int sourceLeft,int sourceTop,int sourceWidth,int sourceHeight,int targetLeft,int targetTop,char sourceChar,System.ConsoleColor sourceForeColor,System.ConsoleColor sourceBackColor) => System.Console.MoveBufferArea(sourceLeft,sourceTop,sourceWidth,sourceHeight,targetLeft,targetTop,sourceChar,sourceForeColor,sourceBackColor);
public System.IO.Stream OpenStandardError() => System.Console.OpenStandardError();
public System.IO.Stream OpenStandardError(int bufferSize) => System.Console.OpenStandardError(bufferSize);
public System.IO.Stream OpenStandardInput() => System.Console.OpenStandardInput();
public System.IO.Stream OpenStandardInput(int bufferSize) => System.Console.OpenStandardInput(bufferSize);
public System.IO.Stream OpenStandardOutput() => System.Console.OpenStandardOutput();
public System.IO.Stream OpenStandardOutput(int bufferSize) => System.Console.OpenStandardOutput(bufferSize);
public int Read() => System.Console.Read();
public System.ConsoleKeyInfo ReadKey() => System.Console.ReadKey();
public System.ConsoleKeyInfo ReadKey(bool intercept) => System.Console.ReadKey(intercept);
public string ReadLine() => System.Console.ReadLine();
public void ResetColor() => System.Console.ResetColor();
public void SetBufferSize(int width,int height) => System.Console.SetBufferSize(width,height);
public void SetCursorPosition(int left,int top) => System.Console.SetCursorPosition(left,top);
public void SetError(System.IO.TextWriter newError) => System.Console.SetError(newError);
public void SetIn(System.IO.TextReader newIn) => System.Console.SetIn(newIn);
public void SetOut(System.IO.TextWriter newOut) => System.Console.SetOut(newOut);
public void SetWindowPosition(int left,int top) => System.Console.SetWindowPosition(left,top);
public void SetWindowSize(int width,int height) => System.Console.SetWindowSize(width,height);
public void Write(bool value) => System.Console.Write(value);
public void Write(char value) => System.Console.Write(value);
public void Write(char[] buffer) => System.Console.Write(buffer);
public void Write(char[] buffer,int index,int count) => System.Console.Write(buffer,index,count);
public void Write(decimal value) => System.Console.Write(value);
public void Write(double value) => System.Console.Write(value);
public void Write(int value) => System.Console.Write(value);
public void Write(long value) => System.Console.Write(value);
public void Write(object value) => System.Console.Write(value);
public void Write(float value) => System.Console.Write(value);
public void Write(string value) => System.Console.Write(value);
public void Write(string format,object arg0) => System.Console.Write(format,arg0);
public void Write(string format,object arg0,object arg1) => System.Console.Write(format,arg0,arg1);
public void Write(string format,object arg0,object arg1,object arg2) => System.Console.Write(format,arg0,arg1,arg2);
public void Write(string format,object arg0,object arg1,object arg2,object arg3) => System.Console.Write(format,arg0,arg1,arg2,arg3);
public void Write(string format,object[] arg) => System.Console.Write(format,arg);
public void Write(uint value) => System.Console.Write(value);
public void Write(ulong value) => System.Console.Write(value);
public void WriteLine() => System.Console.WriteLine();
public void WriteLine(bool value) => System.Console.WriteLine(value);
public void WriteLine(char value) => System.Console.WriteLine(value);
public void WriteLine(char[] buffer) => System.Console.WriteLine(buffer);
public void WriteLine(char[] buffer,int index,int count) => System.Console.WriteLine(buffer,index,count);
public void WriteLine(decimal value) => System.Console.WriteLine(value);
public void WriteLine(double value) => System.Console.WriteLine(value);
public void WriteLine(int value) => System.Console.WriteLine(value);
public void WriteLine(long value) => System.Console.WriteLine(value);
public void WriteLine(object value) => System.Console.WriteLine(value);
public void WriteLine(float value) => System.Console.WriteLine(value);
public void WriteLine(string value) => System.Console.WriteLine(value);
public void WriteLine(string format,object arg0) => System.Console.WriteLine(format,arg0);
public void WriteLine(string format,object arg0,object arg1) => System.Console.WriteLine(format,arg0,arg1);
public void WriteLine(string format,object arg0,object arg1,object arg2) => System.Console.WriteLine(format,arg0,arg1,arg2);
public void WriteLine(string format,object arg0,object arg1,object arg2,object arg3) => System.Console.WriteLine(format,arg0,arg1,arg2,arg3);
public void WriteLine(string format,object[] arg) => System.Console.WriteLine(format,arg);
public void WriteLine(uint value) => System.Console.WriteLine(value);
public void WriteLine(ulong value) => System.Console.WriteLine(value);
}}
