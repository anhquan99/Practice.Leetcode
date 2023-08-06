using System.Linq;

var temp = "1,2,3,4";
var arr = temp.ToArray();
Array.Reverse(arr);
var newStr = new string(arr);
Console.WriteLine(newStr);