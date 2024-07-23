using System.Collections;

namespace Application;
public partial class HashTableSolution
{
    public string ReplaceWords(IList<string> dictionary, string sentence)
    {
        var dic = new Dictionary<string, List<string>>();
        for (char i = 'a'; i <= 'z'; i++)
        {
            dic.Add(i.ToString(), new List<string>());
        }
        foreach (var word in dictionary)
        {
            dic[word[0].ToString()].Add(word);
        }
        foreach (var i in dic)
        {
            i.Value.Sort(new StringLengthComparer());
        }
        var sentenceArr = sentence.Split(' ');
        for (int i = 0; i < sentenceArr.Length; i++)
        {
            var firstCharOfWord = sentenceArr[i][0].ToString();
            if (dic.ContainsKey(firstCharOfWord) && dic[firstCharOfWord].Count > 0)
            {
                foreach (var word in dic[firstCharOfWord])
                {
                    if (sentenceArr[i].StartsWith(word))
                    {
                        sentenceArr[i] = word;
                        break;
                    }
                }
            }
        }
        return string.Join(" ", sentenceArr);
    }
    class StringLengthComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return x.Length - y.Length;
        }
    }
}
