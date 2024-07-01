public class Solution
{
    public bool ThreeConsecutiveOdds(int[] arr)
    {
        int count = 0;
        for (int x = 0; x < arr.Length; x++)
        {
            if (arr[x] % 2 != 0)
            {
                count++;
                if (count == 3)
                {
                    return true;
                }
            }
            else
            {
                count = 0;
            }
        }
        return false;
    }
}

sealed partial class Program
{
    static void Main()
    {
        Solution solution = new Solution();
        int[] arr1 = { 2, 6, 4, 1 };
        int[] arr2 = { 1, 2, 34, 3, 4, 5, 7, 23, 12 };
        System.Console.WriteLine(solution.ThreeConsecutiveOdds(arr1));
        System.Console.WriteLine(solution.ThreeConsecutiveOdds(arr2));
    }
}