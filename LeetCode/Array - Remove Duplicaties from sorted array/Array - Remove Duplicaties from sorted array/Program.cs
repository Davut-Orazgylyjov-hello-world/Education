using System;

namespace Array___Remove_Duplicaties_from_sorted_array
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            RemoveDuplicates(new[] {1, 1, 2});
            Console.WriteLine(    RemoveDuplicates(new[] {1, 2, }).ToString());
            
            int RemoveDuplicates(int[] nums) 
            {
                int j = 1;
                for(int i = 1; i < nums.Length; i++)
                {
                    if(nums[i] != nums[i-1])
                    {
                        nums[j] = nums[i];
                        j++;
                    }
                }
                return j;
            }
        }
    }
}