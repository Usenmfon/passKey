using System;

namespace passKey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==Simple code to authenticate user==\n");
            string password = "";
            
            while(password != "free")
            {
                Console.Write("***Welcome to Ozum\n\n"+
                        "***Please enter password: ");
                password = Console.ReadLine();

            }
            Console.WriteLine("\nACCESS GRANTED+++ENJOY YOUR STAY");
        }
    }
}
