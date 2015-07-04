using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public class MultiThreadedApplication
{
    public static int no = 0;
    public static List<int> random = new List<int>();
    public static List<int> output = new List<int>();
    public static int gflg = 0;
    public static int eflg = 0;
    public static int DisplayThreadCount=0;
    public static DisplayThread obj3 = new DisplayThread();

    public static void Main()
    {
        string str = Console.ReadLine();
        no = int.Parse(str);
        Console.WriteLine("Before start thread");

        GenerateThread obj1 = new GenerateThread();
        FindEvenThread obj2 = new FindEvenThread();
       

        Thread tid1 = new Thread(new ThreadStart(obj1.GenerateNumber));
        Thread tid2 = new Thread(new ThreadStart(obj2.FindEven));
       
        tid1.Start();
        tid2.Start();
          
        ThreadPool.QueueUserWorkItem(new WaitCallback(delegate(object state) { obj3.Display(); }), null);
        DisplayThreadCount=1;
        MonitorThread obj = new MonitorThread();
        Thread  Monitor= new Thread(new ThreadStart(obj.Monitor));
        Monitor.Start();

        Console.ReadLine();
    }
}