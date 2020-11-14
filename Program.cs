using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_arrayCheck
{
    /*
     #``1  Print the number of integers in an array 
        that are above the given input and the number that are below, 
        e.g. for the array [1, 5, 2, 1, 10] with input 6, print “above: 1, below: 4”.
     */
    class Program
    {
        static void Main(string[] args)
        {
            checkArrayVal();
        }

        private static void checkArrayVal()
        {
            //get user input 
            string userInput = string.Empty;
            Console.Write("User input: ");
            userInput = Console.ReadLine();
            Console.WriteLine("\n");

            //create list for random, greater, and less than arrays
            List<int> compareArray = new List<int>();
            List<int> greaterThanArray = new List<int>();
            List<int> lessThanArray = new List<int>();

            //create new random num variable and add to correct list
            Random rnd = new Random();

            //convert user input to int and compare it to random num list. store vals in correct list. 
            int convertUserVal = Convert.ToInt32(userInput);

            for (int i = 0; i < 5; i++)
            {
                compareArray.Add(rnd.Next(50)); //get random between 0 and 50. Could use the supplied array, but did some dynamic approach here

                int val = compareArray[i]; // create var to compare for ease in the if logic

                if (convertUserVal > val)
                {
                    lessThanArray.Add(val);
                }
                else if (convertUserVal < val)
                {
                    greaterThanArray.Add(val);
                }
            }
            //send lists to print function
            printResults(compareArray, greaterThanArray, lessThanArray);
        }

        private static void printResults(List<int> rndArray, List<int> greaterArray, List<int> lesserArray)
        {
            Console.WriteLine("Randomly created array - ");
            foreach (var item in rndArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nNumbers above -  ");
            foreach (var item in greaterArray)
            {
                Console.WriteLine("Above: " + item);
            }

            Console.WriteLine("\nNumbers below -  ");
            foreach (var item in lesserArray)
            {
                Console.WriteLine("Below: " + item);
            }
        }
    }
}
