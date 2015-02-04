using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        double salt = int.Parse(Console.ReadLine());  // CHANGE LATER


        string userText = Console.ReadLine(); // CHANGE LATER


        double charResult = 0;
        double counter = 0; // use this to see if character is in even or odd position

        foreach (var symbol in userText)
        {
            int currentPosition = symbol;

            if (char.IsDigit(symbol))  // if symbol is digit
            {
                charResult = salt + currentPosition + 500;
                
                if (counter % 2 == 0)
                {
                    charResult /= 100;
                    Console.WriteLine("{0:F2}",charResult);
                }
                else if (counter % 2 != 0)
                {
                    charResult *= 100;
                    Console.WriteLine("{0}",charResult);
                }
                counter++;
            }
            else if (char.IsLetter(symbol)) // if symbol is char
            {
                charResult = (salt * currentPosition) + 1000; // if symbolis any other than char and digit

                if (counter % 2 == 0)
                {
                    charResult /= 100;
                    Console.WriteLine("{0:F2}", charResult);
                }
                else if (counter % 2 != 0)
                {
                    charResult *= 100;
                    Console.WriteLine("{0}", charResult);
                }
                counter++;
            }
            else if ( (!char.IsLetter(symbol) && !char.IsDigit(symbol) && !(symbol =='@')) )
            {
                charResult = currentPosition - salt;

                if (counter % 2 == 0)
                {
                    charResult /= 100;
                    Console.WriteLine("{0:F2}", charResult);
                }
                else if (counter % 2 != 0)
                {
                    charResult *= 100;
                    Console.WriteLine("{0}", charResult);
                }
                counter++;
            }
            if (symbol == '@') // stop the proceeding
            {
                break;
            }

        }

    }
}

