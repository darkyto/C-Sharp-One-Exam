using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



 class Program
 {
     static void Main(string[] args)
     {
         int n = int.Parse(Console.ReadLine());  // always within 2 and 100
         int d = int.Parse(Console.ReadLine());  // always witihn 0 nad 100
         int width = 2 * n + 1;
         int height = width;

         //if (d > n)
         //{
         //    d = d - n -1;
         //}


         for (int x = 0; x < width; x++)
         {
             for (int y = 0; y < width; y++)
             {

                 if (x == width/2 && y == width/2) // X mark OK
                 {
                     Console.Write('X');
                 }
                 else if (x + y == width - 1)   // diagonal line OK   THIS is IMPORTANT FOR D
                 {
                     Console.Write('/');
                 }
                 else if (x - y == 0)  // diagonal line OK      THIS IS IMPORTANT for D
                 {
                     Console.Write('\\');
                 }


                     // SMALL TRAINGLE  UPPER
                 else if (x + y == width - 2 - d && x <= 1 && n - d > 2 && d < n)  // small tirangle Upper- roght - OK?
                 {
                     Console.Write('/');
                 }
                 else if (x - y == -1 - d && x <= 1 && n - d > 2 && d < n)  // this will take the D - t OKKKK
                 {
                     Console.Write('\\');
                 }
                 else if (x + y < width - 2 - d && x - y < -1 - d && x <= 1 && n - d > 2 && d < n) //
                 {
                     Console.Write('.');
                 }

                 //====================================================================
                     // second time UPPEr small stringagle for n-d <=2
                 else if (x + y == width - 2 - d && x <= 0 && n - d == 2  && d < n)  // small tirangle Upper- roght - OK?
                 {
                     Console.Write('/');
                 }
                 else if (x - y == -1 - d && x <= 0 && n - d == 2 && d < n)  // this will take the D - t OKKKK
                 {
                     Console.Write('\\');
                 }
                 else if (x + y < width - 2 - d && x - y < -1 - d && x <= 0 && n - d == 2 && d < n) //
                 {
                     Console.Write('.');
                 }
                 //====================================================================

                                      //====================================================================
                 // THIRD time UPPEr small stringagle for n-d <=2
                 else if (x + y == width - 2 - d && x <= 0 && n - d <= 1 && d < n)  // small tirangle Upper- roght - OK?
                 {
                     Console.Write(' ');
                 }
                 else if (x - y == -1 - d && x <= 0 && n - d <= 1 && d < n)  // this will take the D - t OKKKK
                 {
                     Console.Write(' ');
                 }
                 else if (x + y < width - 2 - d && x - y < -1 - d && x <= 0 && n - d <= 1 && d < n) //
                 {
                     Console.Write('.');
                 }
                 //====================================================================

                 #region SmallTriangle Down
                 // SMALL TRAINGLE DOWN
                 else if (x + y == width + d && x >= width - 2 && n-d > 2 && d < n)  // this will take the D - the small triangle DOWN-LEFT OKKK
                 {
                     Console.Write('/');
                 }
                 else if (x - y == 1 + d && x >= width - 2 && n - d > 2 && d < n)  // this will take the D - the small triangle DOWN-RIGHT OKKKKK
                 {
                     Console.Write('\\');
                 }
                 else if ((x + y > width + d && x - y > 1 + d) && x >= width - 2 && n - d > 2 && d < n)  // dots inside the small triangel DOWN - OKKKKKK
                 {
                     Console.Write('.');
                 }

                     // small triangel DOWN - second variantont when  n -d > 2
                 //====================================================================
                 else if (x + y == width + d && x >= width - 1 && n - d == 2 && d < n)  // this will take the D - the small triangle DOWN-LEFT OKKK
                 {
                     Console.Write('/');
                 }
                 else if (x - y == 1 + d && x >= width - 1 && n - d == 2  && d < n)  // this will take the D - the small triangle DOWN-RIGHT OKKKKK
                 {
                     Console.Write('\\');
                 }
                 else if ((x + y > width + d && x - y > 1 + d) && x >= width - 1 && n - d == 2 &&  d < n)  // dots inside the small triangel DOWN - OKKKKKK
                 {
                     Console.Write('.');
                 }
                 //====================================================================


                                          // small triangel DOWN - THIRD variantont when  n -d > 1
                 //====================================================================
                 else if (x + y == width + d && x >= width - 1 && n - d <= 1 && d < n)  // this will take the D - the small triangle DOWN-LEFT OKKK
                 {
                     Console.Write(' ');
                 }
                 else if (x - y == 1 + d && x >= width - 1 && n - d <= 1 && d < n)  // this will take the D - the small triangle DOWN-RIGHT OKKKKK
                 {
                     Console.Write(' ');
                 }
                 else if ((x + y > width + d && x - y > 1 + d) && x >= width - 1 && n - d <= 1 && d < n)  // dots inside the small triangel DOWN - OKKKKKK
                 {
                     Console.Write('.');
                 }
                 //====================================================================
                 #endregion

                 #region emptySpaces
                 else if ((y > width / 2 - 1) && x + y < width) // empty UP - LEFT OK
                 {
                     Console.Write(' ');
                 }
                 else if ((y - x >= 0) && y < width / 2)  // empty UP -RIGHT OK
                 {
                     Console.Write(' ');
                 }
                 else if ((y < width / 2 +1) && x + y > width -1) // emptry DOWN - LEFT  - OKKKK
                 {
                     Console.Write(' ');
                 }
                 else if ((y - x <= 0) && y > width / 2) // empty down-right  - OKKKKKK
                 {
                     Console.Write(' ');
                 }
                 else  // everywhere else we want this symbol
                 {
                     Console.Write('#');
                 }
                 #endregion
             }
             Console.WriteLine();
         }
         
     }
 }

