using System.Diagnostics;

Trace.Listeners.Add(
new TextWriterTraceListener("log.txt"));

Trace.AutoFlush = true;

Trace.WriteLine("Application Started");