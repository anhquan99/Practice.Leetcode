namespace Application;
public partial class QueueSolution
{
    public int[] DeckRevealedIncreasing(int[] deck)
    {
        var sortedDeck = deck.ToList();
        sortedDeck.Sort();
        var queueIndex = new Queue<int>(Enumerable.Range(0, deck.Length));
        while (queueIndex.Count > 0)
        {
            var index = queueIndex.Dequeue();
            deck[index] = sortedDeck[0];
            sortedDeck.RemoveAt(0);
            if (queueIndex.Count > 0)
            {
                queueIndex.Enqueue(queueIndex.Dequeue());
            }
        }
        return deck;
    }
}