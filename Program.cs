using System;

namespace modularzation_problem_two
{
    class Program
    {
        public const int FLATRATE = 75;
        public static int reimbursement = 0;
        static void Main(string[] args)
        {
            ConsoleKey choice = ConsoleKey.NumPad0;

            while(choice != ConsoleKey.D3){
                choice = programOptions();

                if(choice == ConsoleKey.D1){
                    reimbursement += reimburse();
                }else if(choice == ConsoleKey.D2){
                    Console.Write("What was the cost of your out-of-state flight? \n$");
                    int cost = Convert.ToInt32(Console.ReadLine());
                    reimbursement += reimburse(cost);
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

        public static ConsoleKey programOptions(){
            Console.WriteLine("Please select an option:");
            Console.WriteLine("[1] In-state");
            Console.WriteLine("[2] Out-of-state");
            Console.WriteLine("[3] End program");

            ConsoleKey choice = Console.ReadKey().Key;
            Console.Clear();

            return choice;
        }
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

        public static int reimburse(){
            return FLATRATE;
        }
        public static int reimburse(int cost){
            return FLATRATE + cost;
        }
        public static void endProgram(){
            Console.WriteLine($"Your total reimbursement is ${reimbursement}");

            Console.WriteLine("\n\nThe program has ended");
        }
    }
}
