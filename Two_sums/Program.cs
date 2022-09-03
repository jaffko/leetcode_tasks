// Given an nums of integers nums and an integer target, return indices of the two numbers such that they add up to target.
// You may assume that each input would have exactly one solution, and you may not use the same element twice.
// You can return the answer in any order

int[] TwoSum(int[] nums, int target)
{
    int[] res = {-1, -1};
    int i = 0;
    while (i < nums.Length)
    {
        if (nums[i] > target)
        {
            i++;
            break;
        }
        else 
        {
            int k = i + 1;
            while(k < nums.Length)
            {
                if (nums[i]+nums[k]==target) 
                {
                    res[0] = i;
                    res[1] = k;
                    return res;
                }
                k++;
            }
        }
        i++;
    }
    return res;
}

int[] num = new int[] {-1, -2, -3, -4, -5};
int tar = -8;
Console.WriteLine(string.Join(",", TwoSum(num, tar)));
