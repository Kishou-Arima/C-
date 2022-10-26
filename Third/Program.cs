using System;
namespace Third
{
    struct car
    {
        public string? Company;
        public string? Model;
        public int Year;
        public string? Engine_ref;
    }
    public class Cardetails
    {
        public static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter the number of product detail you want to add: ");
            int n= Convert.ToInt32(Console.ReadLine());
            car[] obj=new car[n];
            for(i=0;i<n;i++)
            {
                Console.WriteLine("\t The Details of Car {0}: ",n);
                Console.WriteLine("Company: ");
                obj[i].Company=Console.ReadLine();
                Console.WriteLine("Model: ");
                obj[i].Model=Console.ReadLine();
                Console.WriteLine("Year: ");
                obj[i].Year=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Engine Reference Number: ");
                obj[i].Engine_ref=Console.ReadLine();

            }
            Console.WriteLine("The details are saved...\n Displaying Data...\n\n ");

            for(i=0;i<n;i++)
            {
                Console.WriteLine("\tDetails of Car {0}: ",n);
                Console.WriteLine("Company: "+obj[i].Company);
                Console.WriteLine("Model: "+obj[i].Model);
                Console.WriteLine("Year: "+obj[i].Year);
                Console.WriteLine("Engine Reference Number: "+obj[i].Engine_ref);
            }
            Console.WriteLine("Program exiting...");
        }

    }
}
