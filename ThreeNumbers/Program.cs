using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



 class Program
 {
     static void Main(string[] args)
     {
         decimal a = decimal.Parse(Console.ReadLine());
         decimal b = decimal.Parse(Console.ReadLine());
         decimal c = decimal.Parse(Console.ReadLine());

         decimal arithmetic = (a + b + c) / 3;

         if (a == b & b== c) // start check the largest
         {
             Console.WriteLine(a);
         }
         else 
         {
             if (a >= b && a >= c)
             {
                 Console.WriteLine(a);
             }
             else if (b >= a && b >= c)
             {
                 Console.WriteLine(b);
             }
             else if (c >= a && c >= b)
             {
                 Console.WriteLine(c);
             }
         } // end check the largest


         if (a == b & b == c)  // start check the smallest
         {
             Console.WriteLine(a);
         }
         else 
         {
             if (a <= b && a <= c)
             {
                 Console.WriteLine(a);
             }
             else if (b <= a && b <= c)
             {
                 Console.WriteLine(b);
             }
             else if (c <= a && c <= b)
             {
                 Console.WriteLine(c);
             }
         } // end check the smaleest
         Console.WriteLine("{0:F2}",arithmetic);



     }
 }

