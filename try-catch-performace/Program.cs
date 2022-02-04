using System;
using System.Diagnostics;

namespace try_catch_performace
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stopwatch sw = Stopwatch.StartNew();
            string email = null;
            string emailbody = string.Empty;
            Console.WriteLine("try catch start");
            for (int i = 0; i < 100; i++)
            {
                try
                {
                    emailbody = email.ToString();
                }
                catch (Exception ex)
                {
                    string msg = ex.ToString();
                }
            }
            
            Console.WriteLine(sw.Elapsed.ToString());
            Console.WriteLine("try catch end");
            sw.Restart();
            Console.WriteLine("if start");
            for (int i = 0; i < 100; i++)
            {
                if (email != null)
                {
                    emailbody = email.ToString();
                }
            }
            
            Console.WriteLine(sw.Elapsed.ToString());
            Console.WriteLine("if end");
            Console.ReadLine();
        }
    }
}
