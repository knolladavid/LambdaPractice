using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LambdaPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>() {"Basketball", "Baseball", "Tennis Raquet", "Running Shoes", "Wrestling Shoes", 
                "Soccer Ball", "Football", "Shoulder Pads", 
                "Trail Running Shoes", "Cycling Shoes", "Kayak", "Kayak Paddles"};


            //declare a variable kayakProducts and set it equal to all products that contain the word "Kayak"
            List<string> kayakProducts = products.Where(x => x.ToLower().Contains("kayak")).ToList<string>();
            //print the kayakProducts to the console using a foreach loop.
            
            foreach (string waterBorn in kayakProducts)
            {
                Console.WriteLine(waterBorn);
            }
            
            //declare a variable shoeProducts and set it equal to all products that contain the word "Shoes"
            List<string> shoeProducts = products.Where(x => x.ToLower().Contains("shoes")).ToList<string>();
            //print the shoeProducts to the console using a foreach loop or string.Join().
            foreach (string walker in shoeProducts)
            {
                Console.WriteLine(walker);
            }
            

            //declare a variable ballProducts and set it equal to all the products that have ball in the name.
            List<string> ballProducts = products.Where(x => x.ToLower().ToLower().Contains("ball")).ToList<string>();
            //print the ballProducts to the console using a foreach loop or string.Join().
            foreach   (string bounce in ballProducts)
            {
                Console.WriteLine(bounce);
            }
            
            //sort ballProducts alphabetically and print them to the console.
            foreach   (string baller in ballProducts.OrderBy(x => x))
            {
                Console.WriteLine(baller);
            }

            //print the product with the longest name to the console using the .First() extension.
            Console.WriteLine(products.OrderByDescending(x => x.Length).First());

            
                
         
            //print the product with the shortest name to the console using the .First() extension.
            Console.WriteLine(products.OrderBy(x => x.Length).First());
            

            //print the product with the 3rd shortest name to the console using an index or Skip/Take (you must convert the results to a list using .ToList()).  
            string thirdShortestName = products.OrderBy(x => x.Length).ToList()[2];
            Console.WriteLine(thirdShortestName); 
            //print the ballProduct with the 2nd longest name to the console using an index or Skip/Take (you must convert the results to a list using .ToList()). 
            string secondLongest = products.OrderByDescending(x => x.Length).ToList()[1];
            Console.WriteLine(secondLongest);
            //declare a variable reversedProducts and set it equal to all products ordered by the longest word first. (use the OrderByDescending() extension).
            string reversedProducts = products.OrderByDescending(x => x.Length).First();
                Console.WriteLine(reversedProducts);
            //print out the reversedProducts to the console using a foreach loop.
                foreach (char item in reversedProducts)
                {
                    Console.WriteLine(item);
                }
            //print out all the products ordered by the longest word first using the OrderByDecending() extension and a foreach loop.  
            //Note: you will not use a variable to store your list
                string longestWord = products.OrderByDescending(x => x.Length).First();
                foreach (char item in longestWord)
                {
                    Console.WriteLine(item);
                }
            //FILL IN THE FUNCTIONS BELOW TO MAKE THE TESTS PASS

            Console.ReadKey();
        }

        public static string LongestName(List<string> inputList)
        {
          string LongestName = inputList.OrderByDescending(x => x.Length).First();
                //with the input list, return the item with the longest name
          return LongestName;
          
        }
        

        public static string ShortestName(List<string> inputList)
        {
            string ShortestName = inputList.OrderBy(x => x.Length).First();
            //with the input list, return the item with the shortest name
            return ShortestName;
        }

        public static string SecondLongestName(List<string> inputList)
        {
            string SecondLongestName = inputList.OrderByDescending(x => x.Length).ToList()[1];
            //with the input list, return the item with the second longest name
            return SecondLongestName;
        }

        public static string ThirdShortestName(List<string> inputList)
        {
            string thirdShortestName = inputList.OrderBy(x => x.Length).ToList()[2];
            //with the input list, return the item with the third shortest name
            return thirdShortestName;
        }

        public static List<string> BallProducts(List<string> inputList)
        {
            List<string> BallProducts = inputList.Where(x => x.ToLower().ToLower().Contains("ball")).ToList<string>();  
            //with the input list, return a list with only the the products that contain the word ball
            return BallProducts;
        }
        public static List<string> EndInS(List<string> inputList)
        {
            List<string> EndInS = inputList.Where(x => x.ToLower().Contains('s')).ToList<string>();
            //with the input list, return a list with only the the products that end with the letter s
            return EndInS;
        
        }
   
    }

}
