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
            int[] reading = new int[100];

			for(int i = 0; i < reading.Length; ++i)
			{
				reading[i] = i+1; // i begin with 0
			}

           for (int b = 0; b < reading.Length; b++)
			{              
               Console.WriteLine(reading[b]); 
			}

               
        }
    }
}
  
