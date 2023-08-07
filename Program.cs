using System.Linq;

List<int> temp = new List<int> { 1, 2, 3, 4, 5, 6 };
var max = temp.Max();
var min = temp.Min();

Console.WriteLine("max: {0} -- min: {1}", max, min);