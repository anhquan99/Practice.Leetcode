// using System.Diagnostics;
// using System.Reflection;
// using System.Reflection.Metadata;
using Application;

var q = new QueueSolution();
var nums = new int[][] {
    // new int[] { 1,-2,3,-2}, 
    new int[] { 5,-3,5 },
    // new int[] { -3,-2,-3 }, new int[] {1,-2,3,-2,2,2} 
    };
var result = new[] {
    // 3, 
    10,
    // -2, 6 
    };
var test = new QueueSolution.ProductOfNumbers();
for (int i = 0; i < nums.Length; i++)
{
    var actual = q.MaxSubarraySumCircular(nums[i]);
    if (result[i] != (int?)actual)
    {
        Console.WriteLine("Wrong answer!");
        Console.WriteLine($"Actual: {actual}");
        Console.WriteLine($"Expected: {result[i]}");
    }
}
