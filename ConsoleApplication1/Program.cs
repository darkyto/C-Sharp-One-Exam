using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    static void Main(string[] args)
    {


        long n = 0;
        bool parseOK = true;

        long currentDigit = 0;

        long productResultN = 1; // product of the digits inside the numbe

        long finalProduct = 1; // final calculation product of each odd number

        int counter = 0; // counter for odd even

        long counterTemp = 0;



        do
        {
            bool internalParse = long.TryParse(Console.ReadLine(), out n);
            parseOK = internalParse;

            string parsedNum = Convert.ToString(n);

            counterTemp = counter;

            for (long z = counterTemp; z < counterTemp+10; z++)
            {
                if (counter % 2 != 0)  // ODD check - ok using the counter inside the do-while to check the position of each N number
                {
                    for (int i = 0; i < parsedNum.Length; i++)  // using n lenght (as a string) to loop its digits and
                    {
                        currentDigit = n % 10;
                        n /= 10;

                        if (currentDigit != 0)
                        {
                            productResultN *= currentDigit;
                            finalProduct = productResultN;
                        }
                    }

                }
            }
            


                counter++; // increasing the coubnter after each lopp to know Odds and Evens

            if (counter == 10)
            {
                counter = 0;
            }


        } while (parseOK);


        Console.WriteLine(finalProduct);
        




    }
}