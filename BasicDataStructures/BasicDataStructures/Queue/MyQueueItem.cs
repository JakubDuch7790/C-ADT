namespace BasicDataStructures.Queue;

/// <summary>
/// Slouzi pro reprezentaci objektu ve fronte
/// </summary>
public class MyQueueItem
{
    /// <summary>
    /// Reprezentuje ulozenou hodnotu
    /// </summary>
    public int Value { get; set; }

    /// <summary>
    /// Reference na predchazejici prvek ve fronte
    /// </summary>
    public MyQueueItem? Previous { get; set; }
}
