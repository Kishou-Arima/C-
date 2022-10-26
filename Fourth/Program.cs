using System;
using System.IO;

namespace Fourth
{
    class InputFunc
    {
        private string? Text="";
        private string? name="";
        public void fname()
        {
            Console.WriteLine("Enter the File name");
            name=Console.ReadLine();
        }
        public void input()
        {
            Console.WriteLine("Enter the text you want to save in the File");
            Text=Console.ReadLine();
        }  
        public void run()
        {
            fname();
            input();
            File.WriteAllText(name+".txt",Text);
            Console.WriteLine("\n\n\nThe text in the file is: ");
            string? print= File.ReadAllText(name+".txt");
            Console.WriteLine(print);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            var obj =new InputFunc();
            obj.run(); 
        }
    }
}