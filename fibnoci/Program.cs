using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibnoci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int n2 = 1;
            int next;
            for(int i = 0; i < 10; i++)
            {
                Console.Write(n);
                next = n + n2;
                n = n2;
                n2 = next;  
                   
            }

        }
    }
}
