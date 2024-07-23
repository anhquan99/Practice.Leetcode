using System.Security;
using System.Text;

namespace Application;
public partial class HashTableSolution
{
    Dictionary<char, string> dic = new Dictionary<char, string>() { { '2', "abc" }, { '3', "def" }, { '4', "ghi" }, { '5', "jkl" }, { '6', "mno" }, { '7', "pqrs" }, { '8', "tuv" }, { '9', "wxyz" } };

    public IList<string> LetterCombinations(string digits)
    {
        if (string.IsNullOrEmpty(digits)) return new List<string>();
        // var result = new HashSet<string>();
        // key = new List<char>();
        // foreach (char c in digits)
        // {
        //     key.Add(c);
        // }
        // char[] subResult = new char[digits.Length];
        // Permute(result, subResult, 0, 0);
        var result = new List<string>();
        Permute(0, new List<char>(), digits, result);
        return result;
    }
    // private void Permute(HashSet<string> result, char[] subResult, int index, int value)
    // {
    //     if (index >= key.Count || value >= dic[key[index]].Length)
    //     {
    //         return;
    //     }
    //     subResult[index] = dic[key[index]][value];
    //     if (index == key.Count - 1)
    //     {
    //         result.Add(new string(subResult));
    //     }
    //     for (int i = index; i < key.Count; i++)
    //     {
    //         Permute(result, subResult, i + 1, 0);
    //     }
    //     Permute(result, subResult, index, value + 1);
    // }
    void Permute(int index, List<char> subResult, string digits, List<string> result)
    {
        if (index == digits.Length)
        {
            result.Add(new string(subResult.ToArray()));
            return;
        }
        string possibleLetters = dic[digits[index]];
        foreach (var i in possibleLetters)
        {
            subResult.Add(i);
            Permute(index + 1, subResult, digits, result);
            subResult.RemoveAt(subResult.Count - 1);
        }
    }
}