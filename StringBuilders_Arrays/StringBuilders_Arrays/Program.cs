using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilders
{
    class Program
    {
        static void Main(string[] args)
        {
           char[] str = {'h', 'e', 'l', 'l', 'o'};

           StringBuilder sb = new StringBuilder();
           foreach (char element in str)
           {
               sb.Append(element);
           }
           Console.WriteLine(sb);
            
           sb.Replace('l', 'o');
           Console.WriteLine(sb);

           sb.Remove(0, 4);
           Console.WriteLine(sb);

           sb.Insert(0, "bo");
           Console.WriteLine(sb);

           Console.ReadLine();
        }
    }
}
