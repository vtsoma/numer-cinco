List<int> nums = new List<int> { 1, 1 };

for (int i = 0; i < 40; i++)
{
    int numberOne = nums[nums.Count - 1];
    int numberTwo = nums[nums.Count - 2];

    nums.Add(numberOne + numberTwo);

    Console.WriteLine(nums[i]);
}