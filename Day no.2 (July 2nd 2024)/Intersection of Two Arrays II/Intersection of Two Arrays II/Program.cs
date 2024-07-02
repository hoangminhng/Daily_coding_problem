//Given two integer arrays nums1 and nums2, return an array of their intersection.
//Each element in the result must appear as many times as it shows in both arrays and you may return the result in any order.

 

//Example 1:

//Input: nums1 = [1, 2, 2, 1], nums2 = [2, 2]
//Output: [2,2]
//Example 2:

//Input: nums1 = [4, 9, 5], nums2 = [9, 4, 9, 8, 4]
//Output: [4,9]
//Explanation: [9, 4] is also accepted.

using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        int[] nums1 = { 1, 2, 2, 1 };
        int[] nums2 = { 2, 2 };
        int[] result = Intersect(nums1, nums2);
        foreach (var item in result)
        {
            Console.Write(item + " ");
        }
    }
    static int[] Intersect(int[] nums1, int[] nums2)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        List<int> result = new List<int>();
        foreach (var item in nums1)
        {
            if (dict.ContainsKey(item))
            {
                dict[item]++;
            }
            else
            {
                dict.Add(item, 1);
            }
        }
        foreach (var item in nums2)
        {
            if (dict.ContainsKey(item) && dict[item] > 0)
            {
                result.Add(item);
                dict[item]--;
            }
        }
        return result.ToArray();
    }
}