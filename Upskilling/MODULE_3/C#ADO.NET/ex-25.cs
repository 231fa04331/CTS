using System.IO;

using(FileStream fs =
    new FileStream("sample.txt",FileMode.Open))
{
    StreamReader sr = new StreamReader(fs);
    Console.WriteLine(sr.ReadToEnd());
}

using MemoryStream ms = new();

byte[] data =
System.Text.Encoding.UTF8.GetBytes("Hello");

ms.Write(data);

Console.WriteLine(ms.Length);