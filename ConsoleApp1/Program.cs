
using System;

namespace AccessArray
{
    class Program
    {
        static void Main(string[] args)
        {


            int a = 0;
            int b = 0;
            int result = 0;

            int[] arr = { 73, 67, 38, 33,85};
           

            for (int i = 0; i < arr.Length; i++)
            {
                a = arr[i] % 5;
                if(3 >= a)
                {
                    b = 5 - a;
                    if(b < 3)
                    {
                        result = b + arr[i];
                        if(result < 40 )
                        {
                            Console.WriteLine(arr[i]);

                            continue;
                        }
                        Console.WriteLine(result);
                    }
                    else
                    {
                        Console.WriteLine(arr[i]);
                    }
                    
                }
               
            }

        }
    }
}
