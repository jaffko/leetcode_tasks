int SearchBin(int[] nums, int target)
{
    int i = nums.Length / 2;
    if (nums[i] == target) return i;
    else if (nums[i] > target)
    {
        while (i >= 0)
        {
            if (target == nums[i]) return i;
            i--;
        }
        return -1;
    }
    else if (nums[i] < target)
    {
        while (i < nums.Length)
        {
            if (target == nums[i]) 
            {
                return i;
            }
            i++;
        }
        return -1;
    }
    return -1;    
}

int[] nums = new int[] { -1, 0, 3, 5, 9, 12 };
int target = 12;
System.Console.WriteLine(SearchBin(nums, target));
