using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDays;
            string choice;
            string addonCode = "N/A";
            double totalCost;
            // RATE = 75.00;
            // A RATE = 169.00;
            // C RATE = 112.00;
            welcome();

            Console.WriteLine("Enter the number of days for the stay");
            numDays = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Would you like to include an addon code \n (Y)es or (N)o");
            choice=Console.ReadLine();
            if(choice == "N"){
                totalCost = computeRate(numDays);
            }
            else{
                Console.WriteLine("\nEnter the optional addon code \n A for bathing and grooming \n C for bathing only");
                addonCode=Console.ReadLine();
                totalCost = computeRate(numDays, addonCode);
            }

            outputData(numDays, addonCode, totalCost);
            farewell();
        }
        //methods go here
        static double computeRate(int days){
            return 75.00 * days;
        }
        static double computeRate(int days, string code){
            if(code == "A"){
                return 169.00 * days;
            }
            else{
                return 112.00 * days;
            }
        }
        static void welcome(){
            Console.WriteLine("Welcome to MPLS Dog Boarding");
        }
        static void outputData(int days, string code, double cost){
            Console.WriteLine($"For {days} day(s) and using code {code} \nFinal Cost: {cost.ToString("C")}");
        }
        static void farewell(){
            Console.WriteLine("Thank you for using MPLS Dog Boarding");
        }
    }
    
}
