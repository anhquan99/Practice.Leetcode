namespace Application;
public partial class MathSolution
{
    public int[] PlusOne(int[] digits)
    {
        int[] arrayJustInCase = new int[digits.Count() + 1];
        digits[digits.Count() - 1]++;

        for (int i = digits.Count() - 1; i >= 0; i--)
            if (digits[i] == 10)
            {
                digits[i] = 0;

                if (i > 0)
                    digits[i - 1]++;
                else
                {
                    arrayJustInCase[i] = 1;
                    for (int x = 1; x < digits.Count(); x++)
                        arrayJustInCase[x] = digits[x];
                }
            }

        return Array.Exists(arrayJustInCase, v => v != 0) ? arrayJustInCase : digits;
    }
}