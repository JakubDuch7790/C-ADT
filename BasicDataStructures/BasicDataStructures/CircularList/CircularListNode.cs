namespace BasicDataStructures.CircularList;

/// <summary>
/// Trida Node reprezentujici prvek ve kruhovem seznamu
/// </summary>
public class CircularListNode
{
    public int Key { get; set; }

    public CircularListNode? Next { get; set; }

    public CircularListNode? Opposite { get; set; }
}
