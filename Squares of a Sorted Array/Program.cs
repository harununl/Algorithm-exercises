

public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        int[] result = new int[nums.Length];
        List<int> list = new List<int>();
        
        int tmp = 0;
       

        for (int i = 0; i < nums.Length; i++)
        {
            list.Add(nums[i] * nums[i]);

        }
        nums = list.ToArray();


        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length - i - 1; j++)
            {
                if (nums[j] > nums[j + 1])
                {
                    tmp = nums[j];
                    nums[j] = nums[j + 1];
                    nums[j + 1] = tmp;
                }

            }


        }

        return nums;
       

    }

    public static void Main(string[] args)
    {
        Solution sl = new Solution();

        int[] nums = { -5, -3, -2, -1 };
        

      Array.ForEach(sl.SortedSquares(nums), Console.WriteLine);

    }
}