using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LabAssignment9
{
  public class ThreadDemo
    {
        public static void Main(string[] args)
        {
            Thread t = new Thread(Boom);
            t.Start(5);
        }

        public static void Boom(Object o)
        {
            int m = (int)o;

            while (m > 0)
            {
                m--;
                int s = 59;
                while (s >= 0)
                {
                    Console.WriteLine(m.ToString("D2") + ":" + s.ToString("D2"));
                    s--;
                    Thread.Sleep(1000);
                }
            }
            Console.WriteLine("Bum Bum....");
        }

        public static void Main2(string[] args)
        {

            Thread t = new Thread(ShowMessage);
            t.Start("CHUC MUNG....!!!");


        }

        public static void ShowMessage(Object o)
        {
            String s = (String)o;
            while (true)
            {
                for (int i = 10; i > 0; i--)
                {
                    Console.WriteLine("Time: " + i + "s");
                    Thread.Sleep(1000);
                }
                Console.WriteLine(s);
            }

        }
    }

}
