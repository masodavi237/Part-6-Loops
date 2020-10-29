using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_6_Loops
{
    class Program
    {   

        static void Prompter()
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

        static void PercentPassing()
        {
            int NumOfInputs;

            string currentInput;
            int currentNumber;
            int userChoice;
            bool runInput;
            double aboveSeventy;
            double percentAboveSeventy;

            runInput = true;
            aboveSeventy = 0;
            NumOfInputs = 0;
            percentAboveSeventy = 0;


            while (runInput)
            {
                Console.WriteLine("Would you like to input a grade?");
                Console.WriteLine($"You have inputted: [{NumOfInputs}] grades");
                Console.WriteLine("1 ---> Yes");
                Console.WriteLine("2 ---> No");
                if (Int32.TryParse(Console.ReadLine(), out userChoice))
                {
                    switch (userChoice)
                    {

                        case 1:
                            Console.WriteLine("Please enter a grade in form 'XXX' % ");
                            currentInput = Console.ReadLine();
                            NumOfInputs += 1;

                            if (Int32.TryParse(currentInput, out currentNumber))
                            {
                                if (currentNumber > 70)
                                {
                                    aboveSeventy += 1;
                                }

                            }
                            else
                            {
                                Console.WriteLine("Unable to process input.");
                                Console.WriteLine("Your tally will be reset to 0");
                                Console.WriteLine("Make sure inputs are integers");
                                Console.WriteLine("Please press ENTER to try again");
                                aboveSeventy = 0;
                                NumOfInputs = 0;
                                Console.ReadLine();
                            }
                            break;

                        case 2:
                            percentAboveSeventy = aboveSeventy / NumOfInputs;

                            switch (percentAboveSeventy)
                            {
                                case 0:
                                    Console.WriteLine($"The percentage of scores over 70% is: 0");
                                    Console.WriteLine("Complete");
                                    Console.ReadLine();
                                    runInput = false;
                                    break;

                                default:
                                    Console.WriteLine($"The percentage of scores over 70% is: {percentAboveSeventy}");
                                    Console.WriteLine("Complete");
                                    Console.ReadLine();
                                    runInput = false;
                                    break;
                            }

                            break;

                        default:
                            Console.WriteLine("Unable to process input.");
                            Console.WriteLine("Your tally will be reset to 0");
                            Console.WriteLine("Make sure inputs are integers");
                            Console.WriteLine("Please press ENTER to try again");
                            aboveSeventy = 0;

                            NumOfInputs = 0;
                            Console.ReadLine();
                            break;


                    }

                }
                else
                {
                    Console.WriteLine("Unable to process input.");
                    Console.WriteLine("Your tally will be reset to 0");
                    Console.WriteLine("Make sure inputs are integers");
                    Console.WriteLine("Please press ENTER to try again");
                    aboveSeventy = 0;

                    NumOfInputs = 0;
                    Console.ReadLine();
                }


            }
        }

        static void OddSum()
        {
            int userInput;
            bool run;
            int tally;

            run = true;
            tally = 0;

            while (run)
            {
                Console.WriteLine("Enter a number");
                if (Int32.TryParse(Console.ReadLine(), out userInput) && (userInput > 1))
                {
                    for (int i = 1; i <= userInput; i += 2)
                    {
                        tally += i;
                    }

                    Console.WriteLine($"The sum of all of the odd integers bewteen 1 and {userInput} is {tally}");
                    Console.WriteLine("Press ENTER to continue");
                    Console.ReadLine();
                    run = false;
                }
                else
                {
                    Console.WriteLine("Unable to process input.");
                    Console.WriteLine("Make sure inputs are integers");
                    Console.WriteLine("Please press ENTER to try again");
                    Console.ReadLine();
                }
            }
        }

        static void RandomNumbers()
        {
            Random generator = new Random();
            int min;
            int max;
            int random;
            bool run;

            run = true;

            while (run)
            {
                Console.WriteLine("Please enter a minimum number and then a maximum number.");
                if (Int32.TryParse(Console.ReadLine(), out min) && (Int32.TryParse(Console.ReadLine(), out max)))
                {
                    if (min < max)
                    {
                        Console.WriteLine($"Here are 25 random numbers inbetween {min} and {max} inclusive");
                        for (int i = 0; i < 25; i++)
                        {
                            random = generator.Next(min, max + 1);
                            Console.WriteLine(random);

                        }
                        Console.WriteLine("Please press ENTER to continue");
                        Console.ReadLine();
                        run = false;
                    }

                    else
                    {
                        Console.WriteLine("Unable to process input.");
                        Console.WriteLine("Make sure inputs are integers AND the minimum is LESS than the maximum");
                        Console.WriteLine("Please press ENTER to try again");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Unable to process input.");
                    Console.WriteLine("Make sure inputs are integers");
                    Console.WriteLine("Please press ENTER to try again");
                    Console.ReadLine();
                }
            }
        }

        static void Choice()
        {
            int userChoise;
            bool run;

            run = true;


            while (run)
            {
                Console.WriteLine("1 ---> Prompter");
                Console.WriteLine("2 ---> PercentPassing");
                Console.WriteLine("3 ---> OddSum");
                Console.WriteLine("4 ---> RandomNumbers");
                Console.WriteLine("9 ---> Quit");

                if (Int32.TryParse(Console.ReadLine(), out userChoise))
                {
                    switch (userChoise)
                    {
                        case 1:
                            Prompter();
                            break;
                        case 2:
                            PercentPassing();
                            break;
                        case 3:
                            OddSum();
                            break;
                        case 4:
                            RandomNumbers();
                            break;
                        case 9:
                            run = false;
                            break;

                        default:
                            Console.WriteLine("Unable to process input.");
                            Console.WriteLine("Make sure inputs are integers AND are do not conflict with choices");
                            Console.WriteLine("Please press ENTER to try again");
                            Console.ReadLine();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Unable to process input.");
                    Console.WriteLine("Make sure inputs are integers AND are do not conflict with choices");
                    Console.WriteLine("Please press ENTER to try again");
                    Console.ReadLine();
                    break;
                }
            }
        }

        static void Main(string[] args)
        {

            Choice();

        }
    }
}
