/*


using System;
namespace Myproject
{
    class Sortnum
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
/*List<string> names = new List<string>();
            names.Add(name);
            List<string> gen = new List<string>();
            gen.Add(gender);
            List<int> totalm = new List<int>();
            totalm.Add(total);
        }
    }
}*/