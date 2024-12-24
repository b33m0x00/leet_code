using MediumProblems.RotateArray;

var problem = new RotateArray();

var nums = new int[] { 1, 2, 3, 4, 5 };

foreach (var num in nums)
{
    Console.Write($"{num} ");
}
Console.WriteLine();

problem.Solution(nums, 8);

Console.WriteLine();

foreach (var num in nums)
{
    Console.Write($"{num} ");
}