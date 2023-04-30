using System;
using System.Collections;

class Program
{
    public static void Paritysort(int[] arr,int n)
    {
        int j=n-1,i=0;
        while(i<j)
        {
            if(arr[i]%2==0)
                i++;
            else
            {
                int t=arr[i];
                arr[i]=arr[j];
                arr[j]=t;
                j--;
            }
        }
        for(i=0;i<n;i++)
        {
            Console.Write(arr[i]+" ");
        }
    }
    public static void Main(string[] args)
    {
        int[] arr =new int[]{4,2,5,1,7,3};
        int n = arr.Length;
        Paritysort(arr,n);
    }
}