using Application;

var s = new HashTableSolution();
var exmple = new[] {
    "23",
    "",
    "2"
    };
foreach (var item in exmple)
{
    var result = s.LetterCombinations(item).ToList();
    result.ForEach(x => Console.Write($"{x} - "));
    Console.WriteLine();
}