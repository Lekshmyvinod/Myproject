/*using System;
namespace Myproject
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] num = { 1, 12, 7, 9, 5, 8 };
            int temp = 0;
            for(int i=0; i<=num.Length-1;i++)
            {
                for(int j=i+1;j<num.Length; j++)
                {
                    if(num[i]>num[j])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }

                }
            }
            foreach (var sortednum in num)
            {
                Console.WriteLine(sortednum);
            }
        }
    }
}*/
/*using System;
public class Program
{
    public static void Main()
    {
        string strFirst;
        char charCout;
        int Count = 0;

        strFirst = "ghhbpcckeee";
        Console.Write("Enter Count Character:");
        charCout = Convert.ToChar(Console.ReadLine());
        Console.Write("Your Character Count:");
        int len = strFirst.Length;
        Console.Write(len);
        for (int i = 0; i < len; i++)
        {
            foreach (char chr in strFirst)
            {
                Console.Write(chr);
            }
        }
        foreach (char chr in strFirst)
        {
            if (chr == charCout)
            {
                Count++;
            }
            if (Count < 1)
            {
                Console.Write(strFirst);

            }
            else if(Count > 1)
            {
                Console.Write(Count);
            }
            
        }
        Console.Write(Count);


    }
}*/
