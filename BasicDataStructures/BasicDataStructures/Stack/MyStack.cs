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
        var kotuc = new MyStackItem();

        if (IsEmpty())
        {
            TopItem = kotuc;
            kotuc.Value = value;
        }
        else
        {
            kotuc.Below = TopItem;
            TopItem = kotuc;
            kotuc.Value = value;
        }
    }

    /// <summary>
    /// Odebere vrchni prvek zasobniku. Vraci hodnotu odebraneho prvku, pokud je zasobnik prazdny vraci null.
    /// </summary>
    /// <returns></returns>
    public int? Pop()
    {
        var topItemValue = TopItem.Value;

        if (IsEmpty())
        {
            return null;
        }
        else
        {
            TopItem = TopItem.Below;
        }
        return topItemValue;
    }

    /// <summary>
    /// Vraci True v pripade prazdneho zasobniku, jinak False.
    /// </summary>
    /// <returns></returns>
    public bool IsEmpty()
    {
        if (TopItem == null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
