using System.Text;

namespace Application;
public partial class HashTableSolution
{
    Dictionary<char, string> dic = new Dictionary<char, string>() { { '1', string.Empty }, { '2', "abc" }, { '3', "def" }, { '4', "ghi" }, { '5', "jkl" }, { '6', "mno" }, { '7', "pqrs" }, { '8', "tuv" }, { '9', "wxyz" } };
    List<char> key;
    List<int> value;
    public IList<string> LetterCombinations(string digits)
    {
        var result = new HashSet<string>();
        key = new List<char>();
        value = new List<int>();
        foreach (char c in digits)
        {
            key.Add(c);
            value.Add(-1);
        }
        Permute(result, 0);
        return result.ToList();
    }
    private void Permute(HashSet<string> result, int index)
    {
        if (index == key.Count)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < index; i++)
            {
                sb.Append(dic[key[i]][value[i]]);
            }
            result.Add(sb.ToString());
            return;
        }
        value[index]++;
        while (value[index] < dic[key[index]].Length - 2)
        {
            Permute(result, index + 1);
        }
        Permute(result, index);

    }
}