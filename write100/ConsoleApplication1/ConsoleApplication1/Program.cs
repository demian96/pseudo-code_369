using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 0;
            int a = b + 1;
                        
            int[] reading = new int[]{a} ;

           for (int b = 0; b < reading.Length; b++)
              
               if (b == 100) break;
               Console.WriteLine(reading[a]); 
            

               
        }
    }
}
  