using System;

namespace Second
{
    class Armstrong
    {
        private int n;
        private int result;
        public void input()
        {
            Console.WriteLine("Enter a number: ");
            n=Convert.ToInt32(Console.ReadLine());
        }
        public void process()
        {
            result=0;
            int ogn;
            int rem;
            int i=0;
            ogn=n;
            for(;ogn!=0;ogn/=10,++i);
            ogn=n;
            for(;ogn!=0;ogn/=10)
            {
                rem=ogn%10;
                result+=Convert.ToInt32(Math.Pow(rem,i));
            }
        }
        public void output()
        {
            process();
            if(result==n)
                Console.WriteLine("Armstrong number");
            else
                Console.WriteLine("Not an Armstrong Number");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Armstrong obj= new Armstrong();
            obj.input();
            obj.output();
            Console.ReadKey();        
        } 
    }
}
