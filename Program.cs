using System.Diagnostics;

string logPath = Path.Combine(Environment.GetFolderPath(
  Environment.SpecialFolder.DesktopDirectory), "log.txt");

Console.WriteLine($"Writing to {logPath}");

TextWriterTraceListener logFile = new(File.CreateText(logPath));

Trace.Listeners.Add(logFile);

Trace.AutoFlush = true;

Debug.WriteLine("Debug says, I am watching!");
Trace.WriteLine($"Trace says I am watching!");

