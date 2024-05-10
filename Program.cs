// using System.Diagnostics;
// using System.Reflection;
// using System.Reflection.Metadata;
using Application;

var q = new QueueSolution();
var nums = new int[][] {
    new int[] { 8, 2, 4, 7 }, new int[] { 10, 1, 2, 4, 7, 2 },
    new int[] { 4, 2, 2, 2, 4, 4, 2, 2 } };
var lmits = new int[] {
    4, 5,
    0 };
var result = new[] {
    2, 4,
    3 };
var test = new QueueSolution.ProductOfNumbers();
for (int i = 0; i < lmits.Length; i++)
{
    var actual = q.LongestSubarray(nums[i], lmits[i]);
    if (result[i] != (int?)actual)
    {
        Console.WriteLine("Wrong answer!");
        Console.WriteLine($"Actual: {actual}");
        Console.WriteLine($"Expected: {result[i]}");
    }
}