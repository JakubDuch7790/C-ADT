namespace BasicDataStructures.Stack;

/// <summary>
/// Trida stack reprezentuje zasobnik - last in, first out strukturu (LIFO)
/// </summary>
public class MyStack
{
    public MyStackItem? TopItem { get; set; }

    /// <summary>
    /// Vlozi na vrchol zasobniku novy prvek s hodnotou (value).
    /// </summary>
    /// <param name="value"></param>
    public void Push(int value)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Odebere vrchni prvek zasobniku. Vraci hodnotu odebraneho prvku, pokud je zasobnik prazdny vraci null.
    /// </summary>
    /// <returns></returns>
    public int? Pop()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Vraci True v pripade prazdneho zasobniku, jinak False.
    /// </summary>
    /// <returns></returns>
    public bool IsEmpty()
    {
        throw new NotImplementedException();
    }
}
