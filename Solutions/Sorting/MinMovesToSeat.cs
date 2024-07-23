namespace Application;
public partial class SortSolution
{
    public int MinMovesToSeat(int[] seats, int[] students)
    {
        Array.Sort(seats);
        Array.Sort(students);
        int moves = 0;
        for (int i = 0; i < seats.Length; i++)
        {
            moves += Math.Abs(seats[i] - students[i]);
        }
        return moves;
    }
}