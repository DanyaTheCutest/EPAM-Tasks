using System;

namespace Task_4._1._1;

public class Program
{
    public static void Main(string[] args)
    {
        string storagePath = @"PATH";
        string backupPath = @"PATH";
        var watcher = new FileWatcher(storagePath, backupPath);
        watcher.DisplayMessage += (string message) => Console.WriteLine(message);
        watcher.input += () => Console.ReadLine();
        watcher.Start();
    }
}


