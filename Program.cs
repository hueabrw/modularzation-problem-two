/*
    Author: Abe Huerta

    Description: A simple HR travel reimbursement program.

    NOTICE: Sorry Chris if this is a bit overkill. I really wanted to pretty up the program. The overloaded methods are on line 80 and 84.
*/
using System;

namespace modularzation_problem_two
{
    class Program
    {
        public const int FLATRATE = 75;
        public static int reimbursement = 0;
        //Main method with flow control logic in it
        static void Main(string[] args)
        {
            ConsoleKey choice = ConsoleKey.NumPad0;
            Console.Clear();
            welcomeModule();

            while(choice != ConsoleKey.D3){
                choice = programOptions();

                if(choice == ConsoleKey.D1){
                    Console.WriteLine("RIMBERSMENT FOR IN-STATE FLIGHT\n");
                    reimbursement += reimburse();                                       //Here is where the reimburse method is called
                }else if(choice == ConsoleKey.D2){
                    Console.WriteLine("RIMBERSMENT FOR OUT-OF-STATE FLIGHT\n");
                    Console.Write("What was the cost of your out-of-state flight? \n$");
                    int cost = Convert.ToInt32(Console.ReadLine());
                    reimbursement += reimburse(cost);                                   //Here is where the overloaded method is called
                }else if(choice == ConsoleKey.D3){
                    break;
                }else{
                    Console.WriteLine("\ninvalid choice");
                }

                Console.WriteLine($"\nYour reimbursment total is: ${reimbursement}");

                choice = anotherReimbursment();
            }

            endProgram();
        }
        //Gotta be professional :)
        public static void welcomeModule(){
            Console.WriteLine("Welcome to HR's Travel Reimbursement Program!\nCustomer satisfaction is our priority!\n");
        }
        //Here is the method where the customer can select a reimbursment option
        public static ConsoleKey programOptions(){
            Console.WriteLine("MENU\n");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("[1] In-state");
            Console.WriteLine("[2] Out-of-state");
            Console.WriteLine("[3] End program");

            ConsoleKey choice = Console.ReadKey().Key;
            Console.Clear();

            return choice;
        }
        //Flow control method for the program
        public static ConsoleKey anotherReimbursment(){
                Console.WriteLine("\n\nWas there another flight you wanted reimbursed? (Y/N)");

                ConsoleKey again = Console.ReadKey().Key;
                Console.Clear();

                if(again == ConsoleKey.Y){
                    return ConsoleKey.D0;
                }else if(again == ConsoleKey.N){
                    return ConsoleKey.D3;
                }else{
                    Console.WriteLine("Not a valid option\n");

                    return anotherReimbursment();
                }
        }
        //The reimbursement method
        public static int reimburse(){
            return FLATRATE;
        }
        //The OVERLOADED reimbursment method
        public static int reimburse(int cost){
            return FLATRATE + cost;
        }
        //an ending module
        public static void endProgram(){
            Console.WriteLine("A reimbursment ticket has been sumbited!\n");
            Console.WriteLine($"Here is the total of your reimbursement request: ${reimbursement}");

            Console.WriteLine("\n\nThe program has ended");
        }
    }
}
