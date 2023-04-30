using System;
using System.Collections;

public class Program
{
    static bool isPossible(int[] arr, int n,int m, int cmin)
    {
        int sReq=1;
        int csum=0;
        for(int i=0; i<n;i++)
        {
            if(arr[i]>cmin)
                return false;
            if(csum+arr[i]>cmin)
            {
                sReq++;
                csum=arr[i];
                if(sReq>m)
                    return false;
            }
            else
                csum+=arr[i];
        }
        return true;
    }
    static int allocate(int[] arr,int n, int m)
    {
        long sum=0;
        if(n<m)
            return -1;
        int mx=arr[0];
        for(int i=0;i<n;i++)
        {
            sum+=arr[i];
            mx=(arr[i]>mx?arr[i]:mx);
        }
        int start=0, end=(int)sum;
        int result=int.MaxValue;
        while(start<=end)
        {
            int mid=(start+end)/2;
            if(isPossible(arr,n,m,mid))
            {
                result=mid;
                end=mid-1;
            }
            else
                start=mid+1;
        }
        return result;
    }
    public static void Main(String[] args)
    {
        int student=2;
        int[] pages={10,20,30,40};
        int n=pages.Length;
        Console.Write("Minimum Pages: "+allocate(pages,n,student));
    }
}