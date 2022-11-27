namespace BasicDataStructures.Queue;

/// <summary>
/// Trida Queue reprezentuje frontu, first in, first out strukturu (FIFO)
/// </summary>
public class MyQueue
{
    /// <summary>
    /// Reference na prvni prvek
    /// </summary>
    public MyQueueItem? First { get; set; }

    /// <summary>
    /// Reference na posledni prvek
    /// </summary>
    public MyQueueItem? Last { get; set; }

    /// <summary>
    /// Vlozi do fronty novy prvek s hodnotou (value)
    /// </summary>
    /// <param name="value"></param>
    public void Enque(int value)
    {

        var myQueueItem = new MyQueueItem()
        {
            Value = value
        };

        if (IsEmpty())
        {
            First = myQueueItem;
            Last = myQueueItem;
        }
        else
        {
            myQueueItem.LeftItem = Last;
            Last = myQueueItem;
            myQueueItem.Value = value;
        }

    }

    /// <summary>
    /// Vraci hodnotu (value) odebraneho prvku, pokud je fronta prazdna, vraci null
    /// </summary>
    /// <returns></returns>
    public int? Deque()
    {
        var first = First.Value;

        if (IsEmpty())
        {
            return null;
        }

        if (First.LeftItem != null)
        {
            First.LeftItem = First;
        }
        return first;


    }

    /// <summary>
    /// Vraci True v pripade prazdne fronty, jinak False.
    /// </summary>
    /// <returns></returns>
    public bool IsEmpty()
    {
        if (First == null && Last == null)

        { 
            return true;
        }
        return false;
    }
}
