using System;
using System.Collections;

namespace TwoSum
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[]{3,2,4};
            foreach (var i in  twoSum(arr,6))
            {
                Console.WriteLine(i);
            }
        }
        public static int[] twoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            Hashtable hashMap = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                if (hashMap[target - num] != null)
                {
                    result[0] = Convert.ToInt32(hashMap[target - num]);
                    result[1] = i;
                }
                hashMap[num] = i;
            }
            return result;
        }
    }
}




