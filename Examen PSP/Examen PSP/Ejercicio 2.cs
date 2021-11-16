using System;
using System.Diagnostics;

namespace Examen_PSP
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            Console.Write("Abriendo Notepad...");
            System.Threading.Thread.Sleep(1000);
            Process.Start(@"C:\Windows\system32\notepad.exe");
        }
    }
}
