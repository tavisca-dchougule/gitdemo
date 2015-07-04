using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FindEvenThread
{


    public void FindEven()
    {
        int cnt2 = 0;
        while (cnt2 != MultiThreadedApplication.no)
        {
            if (MultiThreadedApplication.random.Count() != 0)
            {
                if (MultiThreadedApplication.random.ElementAt(0) % 2 == 0)
                    MultiThreadedApplication.output.Add(MultiThreadedApplication.random.ElementAt(0));
                MultiThreadedApplication.random.RemoveAt(0);
                cnt2++;
            }
            else
                while (MultiThreadedApplication.random.Count() == 0) ;
        }
        MultiThreadedApplication.eflg = 1;
        Console.WriteLine("FindEven cmplt.");

    }

}
