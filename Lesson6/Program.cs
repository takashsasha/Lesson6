using System;
using System.Diagnostics;

namespace Lesson6
{
    internal class Program
    {
        static int Main(string[] args)
        {
            int a = 0;
            Process[] processes = Process.GetProcesses();
            for (int i = 0; i < processes.Length; i++)
            {
                Process current = processes[i];
                Console.WriteLine($"\n{current.ProcessName}, ID Процесса: {current.Id}");
            }

            Console.WriteLine("Введите 1 для выбора процесса по имени, либо 2 для выбора по id");
            a = Int32.Parse(Console.ReadLine());
            if (a == 1)
            {
                Console.WriteLine("Введите Имя процесса который нужно завершить -");
                string killProcess = Console.ReadLine();
                for (int i = 0; i < processes.Length; i++)
                {
                    Process current = processes[i];
                    if (current.ProcessName == killProcess)
                    {
                        current.Kill();
                        Console.WriteLine($"Процесс -{current.ProcessName} был завершен");
                    }
                }
            }
            else
            {
                Console.WriteLine("Или введите  ID процесса который нужно завершить -");
                int killIdProcess = Int32.Parse(Console.ReadLine());
                for (int i = 0; i < processes.Length; i++)
                {
                    Process current = processes[i];
                    if (current.Id == killIdProcess)
                    {
                        current.Kill();
                        Console.WriteLine($"Процесс -{current.Id} был завершен");
                    }
                }
            }

            
            return 0;

        }
    }
}