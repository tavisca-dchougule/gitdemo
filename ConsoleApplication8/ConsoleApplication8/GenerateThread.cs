using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 public class GenerateThread
  {
     
         public void GenerateNumber()
         {
             Random r = new Random();
             for (int i = 0; i < MultiThreadedApplication.no; i++)
             {

                 int number = r.Next(1, MultiThreadedApplication.no);
                 MultiThreadedApplication.random.Add(number);

                 Console.WriteLine("GenNo:" + number);
             }
             MultiThreadedApplication.gflg = 1;
             Console.WriteLine("GenNo cmplt.");


         }

     
  }
