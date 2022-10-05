using System.ComponentModel;

class program
{
     static void sortArr(int[] arr)
    {
        int tmp;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j+1])
                {
                    tmp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j + 1] = tmp;
                }


            }

        }


    }

     static void printArr(int[] arr)
    {
        for (int i = 0; i < arr.Length ; i++)
        {
            Console.Write(arr[i] + " " );
           
        }



    }

     static void Main(string[] args)
    {
        int[] arr = {12,5,30,4,1,100,57};
       
   
        sortArr(arr);
        Console.WriteLine("enter your balance");
        int balance;
        balance = Convert.ToInt32(Console.ReadLine());
        Console.Write(arr.Length);
        Console.WriteLine();
        printArr(arr);
        
        int total = 0;
        int i;
        for (i = 0; i < arr.Length; i++)
        {

            if (total <= balance)
            {
                total += arr[i];
                if (total>balance)
                {
                   total-=arr[i];
                    break;
                    
                    
                }
               
                

            }
          
        }
        Console.WriteLine();
        Console.WriteLine(i);
        


    }










}