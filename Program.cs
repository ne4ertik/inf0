using System.Diagnostics;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process[] processes = Process.GetProcesses();
            Console.WriteLine("PID\tName");
            foreach (Process process in processes)
            {
                Console.WriteLine($"{process.Id}\t{process.ProcessName}");
            }
        }
    }
}
