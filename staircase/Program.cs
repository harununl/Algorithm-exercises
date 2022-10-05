

class program
{

    public static void StairCase(int n)
    {
        for (int i = 1; i <= n ;  i++)
        {
            
            for (int j = 1; j <= n ; j++)
            {
                if (j <= n - i)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("#");
                }

            }
            Console.WriteLine();
        }
        
    }
    
    static void Main(string[] args)
    {
        StairCase(6);
        
        

    }


}