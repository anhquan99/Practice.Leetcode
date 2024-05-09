using System.Diagnostics;
using Application;

var q = new QueueSolution();
var testCase = new[] {
    // "RD",
    // "RDD",
    // "RDRDRDRD", "DRDRDRR",
    // "DDRRRR",
    // "DRRDRDRDRDDRDRDRD",
    "DRRD"
    };
var result = new[] {
    // "Radiant",
    // "Dire",
    // "Radiant", "Dire",
    // "Radiant",
    // "Dire",
    "Dire"
    };
for (int i = 0; i < testCase.Length; i++)
{
    // Console.WriteLine(q.PredictPartyVictory(testCase[i]));
    Debug.Assert(q.PredictPartyVictory(testCase[i]) == result[i]);
}