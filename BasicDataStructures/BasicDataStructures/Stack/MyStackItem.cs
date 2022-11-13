namespace BasicDataStructures.Stack;

/// <summary>
/// Trida Item slouzi pro reprezentaci objektu v zasobniku
/// </summary>
public class MyStackItem
{
    /// <summary>
    /// Reprezentuje ulozenou hodnotu
    /// </summary>
    public int Value { get; set; }

    /// <summary>
    /// Reference na predchazejici prvek v zasobniku
    /// </summary>
    public MyStackItem? Below { get; set; }
}
