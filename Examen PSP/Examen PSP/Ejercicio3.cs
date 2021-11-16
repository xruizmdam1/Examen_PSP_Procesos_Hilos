using System;
using System.Threading;
using System.Threading.Tasks;

namespace Examen_PSP
{
    class Ejercicio3
    {
        static void Main(String[] args)
        {
            // Objeto de clase PriorityTest
            PriorityTest pt = new PriorityTest();

            // Hilo 1
            Thread hilo1 = new Thread(pt.ThreadMethod);
            hilo1.Name = "Hilo Nº1";
            Thread.Sleep(1000);
            hilo1.Start();
            Console.WriteLine(hilo1.Name + " iniciado");

            // Hilo 2
            Thread hilo2 = new Thread(pt.ThreadMethod);
            hilo2.Name = "Hilo Nº2";
            hilo2.Priority = ThreadPriority.Lowest;
            Thread.Sleep(2000);
            hilo2.Start();
            Console.WriteLine(hilo2.Name + " iniciado");

            // Hilo 3
            Thread hilo3 = new Thread(pt.ThreadMethod);
            hilo3.Name = "Hilo Nº3";
            hilo3.Priority = ThreadPriority.Normal;
            Thread.Sleep(3000);
            hilo3.Start();
            Console.WriteLine(hilo3.Name + " iniciado");

            // Hilo 4
            Thread hilo4 = new Thread(pt.ThreadMethod);
            hilo4.Name = "Hilo Nº4";
            hilo4.Priority = ThreadPriority.Normal;
            Thread.Sleep(4000);
            hilo4.Start();
            Console.WriteLine(hilo4.Name + " iniciado");

            // Hilo 5
            Thread hilo5 = new Thread(pt.ThreadMethod);
            hilo5.Name = "Hilo Nº5";
            hilo5.Priority = ThreadPriority.Highest;
            Thread.Sleep(5000);
            hilo5.Start();
            Console.WriteLine(hilo5.Name + " iniciado");

            pt.LoopSwitch = false;
        }
    }

    class PriorityTest
    {
        static volatile bool loopSwitch;
        [ThreadStatic] static long threadCount = 0;

        public PriorityTest()
        {
            loopSwitch = true;
        }

        public bool LoopSwitch
        {
            set { loopSwitch = value; }
        }

        public void ThreadMethod()
        {
            while (loopSwitch)
            {
                threadCount++;
            }
            Console.WriteLine("{0,-11} with {1,11} priority " +
                "has a count = {2,13}", Thread.CurrentThread.Name,
                Thread.CurrentThread.Priority.ToString(),
                threadCount.ToString("N0"));
        }
    }
}
