using Application;

var s = new Solution();
var exmple = new[] {
    1,
    // 9 
    };
foreach (var item in exmple)
{
    var result = s.ReadBinaryWatch(item).ToList();
    result.ForEach(x => Console.Write($"{x} - "));
    Console.WriteLine();
}