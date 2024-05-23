namespace Application;
public partial class Solution
{
    List<int> dic = new List<int>()
    {
        8, 4, 2, 1,
        32, 16, 8, 4, 2, 1
    };
    public IList<string> ReadBinaryWatch(int turnedOn)
    {
        if (turnedOn == 0) return new List<string>() { "0:00" };
        var result = new HashSet<string>();
        Permute(result, turnedOn, 0, 0, 0, 0);
        var final = result.ToList();
        final.Reverse();
        return final;

    }
    void Permute(HashSet<string> result, int turnedOn, int index, int hour, int min, int count)
    {

        var completeHour = $"{hour}:{min:D2}";
        if (count == turnedOn)
        {
            result.Add(completeHour);
        }
        for (int i = index; i < dic.Count && count < turnedOn; i++)
        {
            bool isHourChanged = false, isMinChanged = false;
            if (i < 4 && hour + dic[i] < 12)
            {
                hour += dic[i];
                isHourChanged = true;
                count++;
            }
            else if (i >= 4 && min + dic[i] < 60)
            {
                min += dic[i];
                isMinChanged = true;
                count++;
            }
            Permute(result, turnedOn, i + 1, hour, min, count);
            if (isHourChanged)
            {
                hour -= dic[i];
                count--;
            }
            else if (isMinChanged)
            {
                min -= dic[i];
                count--;
            }
        }
    }
}