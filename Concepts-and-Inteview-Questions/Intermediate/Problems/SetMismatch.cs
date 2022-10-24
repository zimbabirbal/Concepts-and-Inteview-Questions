namespace Concepts_and_Interview_Questions.Intermediate.Problems
{
    /// <summary>
    /// 
    /// Problems:
    /// ********This code is from leetcode***********
    /// You have a set of integers s, which originally contains all the numbers from 1 to n. 
    /// Unfortunately, due to some error, one of the numbers in s got duplicated to another number in the set, 
    /// which results in repetition of one number and loss of another number.
    /// You are given an integer array nums representing the data status of this set after the error.
    /// Find the number that occurs twice and the number that is missing and return them in the form of an array.
    ///
    /// Expected outputs:
    /// 
    /// Example 1:
    /// Input: nums = [1,2,2,4]
    /// Output: [2,3]
    ///
    /// Example 2:
    /// Input: nums = [1,1]
    /// Output: [1,2]
    /// </summary>
    public class SetMismatch
    {
        /* This is best solution so far.
         * The most naive solution is to consider each number from 11 to nn, 
         * and traverse over the whole numsnums array to check if the current number occurs twice in numsnums or 
         * doesn't occur at all. We need to set the duplicate number, dupdup and the missing number, missingmissing, 
         * appropriately in such cases respectively.
         */
        public int[] FindErrorNums(int[] nums)
        {
            int dup = -1, missing = -1;
            for (int i = 1; i <= nums.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] == i)
                        count++;
                }
                if (count == 2)
                    dup = i;
                else if (count == 0)
                    missing = i;
            }
            return new int[] { dup, missing };
        }

        //This is not the best solutions but works pefectly
        public int[] FindErrorNumsAlternative(int[] nums)
        {
            int[] tempArray = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {

                int count = 0;
                for (int k = 0; k < nums.Length; k++)
                {
                    if (nums[i] == nums[k])
                    {
                        count++;
                        if (count > 1)
                        {
                            int expected = 1;
                            tempArray[0] = nums[i];

                            for (int j = 0; j < nums.Length;)
                            {
                                if (expected == nums[j])
                                {
                                    expected += 1;
                                    j = 0;
                                    continue;
                                }
                                j++;
                            }
                            tempArray[1] = expected;
                        }
                    }
                }
            }
            return tempArray;
        }
    }
}
