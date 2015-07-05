using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Reflection;
using System.IO;


class Logger 
{
    // as soon as sound methos is invooked from vehicle class, our custom attribute LogAttribute logs the data to file.
    public static void Main()
    {
        Vehicle Vehicle = new Vehicle();//here Vehicle object is created
        
        
        Type type = typeof(Vehicle);

        for (int i = 0; i < 5; i++) // display is called 5 times
        {
            Vehicle.Sound();
            Thread.Sleep(1000);
            foreach (MethodInfo m in type.GetMethods())
            {
                foreach (Attribute a in m.GetCustomAttributes(true))
                {
                    LogAttribute log = (a as LogAttribute);
                    if (null != log)
                    {
                        //print on console
                        Console.Write("" + log.Description);
                        Console.Write(". By user: " + log.CurrentUser);
                        Console.WriteLine(". At Time: " + log.AccessTime);

                        //logging into file log.txt
                        using (StreamWriter w = File.AppendText("log.txt"))
                        {
                            w.Write("" + log.Description);
                            w.Write(". By user: " + log.CurrentUser);
                            w.WriteLine(". At Time: " + log.AccessTime);
                        }
                    }
                }
            }
        }

        Console.ReadLine();
      
    }
    
}
