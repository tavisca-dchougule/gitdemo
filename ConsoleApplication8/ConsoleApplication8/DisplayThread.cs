using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DisplayThread
{

    public void Display()
    {


        while (true)
        {
            lock (this)
            {
                if (MultiThreadedApplication.output.Count() != 0)
                {
                    Console.WriteLine(MultiThreadedApplication.output.ElementAt(0));
                    Console.WriteLine("Thread ID : {0}", System.Threading.Thread.CurrentThread.ManagedThreadId);
                    MultiThreadedApplication.output.RemoveAt(0);
                }


                else
                {
                    if (MultiThreadedApplication.output.Count() == 0)
                    {
                        if (MultiThreadedApplication.gflg == 1 && MultiThreadedApplication.eflg == 1)
                        {
                            break;
                        }
                    }

                }
            }

        }

    }
}

