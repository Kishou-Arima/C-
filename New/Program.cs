using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Calculator");

        Console.WriteLine("Enter 1st number: ");
        double a=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter 2nd number: ");
        double b=Convert.ToDouble(Console.ReadLine());

        double ans;

        Console.WriteLine("1.ADD \n2.SUBTRACT \n3.MULTIPLY \n4.DIVIDE ");
        Console.WriteLine("Enter the number(1-4) for your choice: ");
        char choice = Convert.ToChar(Console.Read());
        
        switch(choice)
        {
            case '1':
                ans=a+b;
                Console.WriteLine("The answer for your problem is: {0}", ans);
                break;
            case '2':
                ans=a-b;
                Console.WriteLine("The answer for your problem is: {0}", ans);
                break;       
            case '3':
                ans=a*b;
                Console.WriteLine("The answer for your problem is: {0}", ans);
                break;
            case'4':
                if(b==0)
                    Console.WriteLine("Invalid Operation!");
                else
                {
                    ans=a/b;
                    Console.WriteLine("The answer for your problem is: {0}", ans);
                }
                break;
            default:
                Console.WriteLine("Invalid Choice!");
                break;
        }

        
        Console.ReadKey();
    }
}