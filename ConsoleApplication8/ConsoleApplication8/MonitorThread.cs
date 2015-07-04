using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


public class MonitorThread
{
    int ThreadCount = 0, EvenNumbers = 0;

    public void Monitor()
    {
        while (true)
        {
            ThreadCount = MultiThreadedApplication.DisplayThreadCount;
            EvenNumbers = MultiThreadedApplication.output.Count();
            if (EvenNumbers / ThreadCount > 5)
            {
                Console.WriteLine("New Display Thread Created.");
                ThreadPool.QueueUserWorkItem(new WaitCallback(delegate(object state) { MultiThreadedApplication.obj3.Display(); }), null);
                MultiThreadedApplication.DisplayThreadCount++;

            }
            else if (EvenNumbers / ThreadCount < 5)
            {
                Console.WriteLine("Thread with ID : {0}", System.Threading.Thread.CurrentThread.ManagedThreadId + " is Terminated");
                Thread.CurrentThread.Abort();
                MultiThreadedApplication.DisplayThreadCount--;
            }
        }
    }
}

