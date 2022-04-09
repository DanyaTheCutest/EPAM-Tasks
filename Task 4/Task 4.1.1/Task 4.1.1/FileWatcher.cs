using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Task_4._1._1
{
    public class FileWatcher
    {
        public Action<string>? DisplayMessage;
        public delegate string GetInput();
        public GetInput? input;


        //private readonly string _logPath;
        private readonly string _storagePath;
        private readonly string _backupPath;

        public FileWatcher(string storagePath, string backupPath)
        {
            
            _storagePath = storagePath;
            _backupPath = backupPath;
        }

        public void Start()
        {
            DisplayMessage?.Invoke(string.Join(Environment.NewLine,
                "Choose option: ", "1: Track changes", "2: Rollback changes"));

            var flag = true;
            while (flag)
                switch (ReadInt())
                {
                    case 1:
                        flag = false;
                        Watch();

                        break;
                    case 2:
                        flag = false;
                        Rollback();
                        break;
                    default:
                        DisplayMessage?.Invoke("Invalid input");
                        break;
                }
        }

        private async void Watch()
        {
            using var watcher = new FileSystemWatcher(_storagePath);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);
            watcher.Deleted += new FileSystemEventHandler(OnDeleted);
            watcher.Created += new FileSystemEventHandler(OnCreated);
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Filter = "*.txt";
            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;

            DisplayMessage?.Invoke("Tracking has been started");

            while (true)
            {
                DisplayMessage?.Invoke("Type 1 to exit");
                if (ReadInt() == 1)
                    Environment.Exit(0);
                await Task.Delay(1000);
            }
        }

        private async void Rollback()
        {
            DisplayMessage?.Invoke("Enter the date of target stage as yyyy.MM.dd_HH-mm-ss: ");
            var date = input?.Invoke();

            foreach (var item in Directory.GetFiles(_storagePath))
            {
                if (File.Exists(item) & !File.Exists(_backupPath + date))
                    File.Delete(item);
            }

            CopyDirectory(_backupPath + "\\" + date, _storagePath);
            DisplayMessage?.Invoke("Rollback succesful");
            
            DisplayMessage?.Invoke(string.Join(Environment.NewLine, "1: Back to options", "2: Exit"));
            var flag = true;
            while (flag)
            {
                switch (ReadInt())
                {
                    case 1:
                        Start();
                        flag = false;
                        break;
                    case 2:
                        Environment.Exit(0);
                        flag = false;
                        break;
                    default:
                        DisplayMessage?.Invoke(("Invalid input"));
                        break;
                }
            }
            
        }

        private int ReadInt()
        {
            return int.Parse(input?.Invoke());
        }

        private void OnDeleted(object s, FileSystemEventArgs e)
        {
            DisplayMessage?.Invoke($"File {e.FullPath} {e.ChangeType}");
            CreateFoler();
        }

        private void OnCreated(object s, FileSystemEventArgs e)
        {
            DisplayMessage?.Invoke($"File {e.FullPath} {e.ChangeType}");
            CreateFoler();
        }

        private void OnRenamed(object s, RenamedEventArgs e)
        {
            DisplayMessage?.Invoke($"File {e.FullPath} {e.ChangeType}");
            CreateFoler();
        }

        private void OnChanged(object s, FileSystemEventArgs e)
        {
            DisplayMessage?.Invoke($"File {e.FullPath} {e.ChangeType}");
            CreateFoler();
        }

        private void CopyDirectory(string source, string dest)
        {
            Directory.CreateDirectory(source);
            foreach (var s1 in Directory.GetFiles(source))
            {
                var s2 = dest + "\\" + Path.GetFileName(s1);
                File.Copy(s1, s2, true);
            }
            foreach (var s in Directory.GetDirectories(source))
            {
                CopyDirectory(s, dest + "\\" + Path.GetFileName(s));
            }
        }

        private void CreateFoler()
        {
            var dest = Path.Combine(_backupPath, DateTime.Now.ToString("yyyy.MM.dd_HH-mm-ss"));
            if (!Directory.Exists(dest))
                Directory.CreateDirectory(dest);
            CopyDirectory(_storagePath, dest);
        }
    }
}
