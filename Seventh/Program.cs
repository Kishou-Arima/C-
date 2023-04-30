namespace Solution
{
    public class Program{
    private int r,sum=0,t;
    public void IsPalindrome(int x) 
    {
        t=x;
        while(t>0)
        {
            r=t%10;
            sum=(sum*10)+r;
            t=t/10;
        }
        if(x==sum)
            Console.WriteLine("true");
        else
            Console.WriteLine("false");
    }
    public static void Main(string[] args)
    {
        Console.Write("Enter a number ");
        int n= Convert.ToInt16(Console.ReadLine());
        Program obj= new Program();
        obj.IsPalindrome(n);
    }
}
}
