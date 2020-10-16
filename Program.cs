using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_6_Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            string minInput;
            string maxInput;
            int min;
            int max;
            int user;
            bool run;
            bool sequence;

            run = true;
            sequence = true; 
            
            

    
            while (sequence)
            {
                Console.WriteLine("Please enter a minimum number");
                minInput = Console.ReadLine();
                Console.WriteLine("Please enter a maximum number");
                maxInput = Console.ReadLine();

                if (Int32.TryParse(minInput, out min) && (Int32.TryParse(maxInput, out max)))
                {

                    if (min < max)
                    {

                        while (run)
                        {

                            Console.WriteLine($"Please enter a number betweeen {min} and {max}");
                            user = Convert.ToInt32(Console.ReadLine());

                            if ((user <= max) && (min <= user))
                            {
                                Console.WriteLine($"You inputted {user}, which is inbetween {min} and {max} (inclusive)");
                                run = false;
                                sequence = false;

                            }

                            else
                            {

                                Console.WriteLine($"You inputted {user}, which is NOT inbetween {min} and {max} (inclusive)");
                                Console.WriteLine("Please press ENTER to try again");
                                Console.ReadLine();

                            }
                        }
                    }
                    else
                    {

                        Console.WriteLine("You have inputted conflicting minimum and maximum numbers");
                        Console.WriteLine("Please press ENTER to try again");
                        Console.ReadLine();

                    }
                }

                else
                {
                    Console.WriteLine("Unable to process inputs");
                    Console.WriteLine("Make sure inputs are integers");
                    Console.WriteLine("Please press ENTER to try again");
                    Console.ReadLine();

                }
            }

            Console.WriteLine("Complete");
            Console.ReadLine();
        }
    }
}
