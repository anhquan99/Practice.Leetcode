using System.Linq;
using Application;

List<List<int>> cases = new List<List<int>>
{
    new List<int>() { 3, 6 },
    new List<int>() { 1, 5 },
    new List<int>() { 4, 7 }
};


HashTableSolution s = new HashTableSolution();
s.NumberOfPoints(cases);