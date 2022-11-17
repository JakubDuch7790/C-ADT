﻿namespace BasicDataStructures.Stack;

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
            kotuc = TopItem;
            kotuc.Value = value;
        }
        else
        {
            kotuc = TopItem.Below;
            kotuc.Value = value;
        }
    }

    /// <summary>
    /// Odebere vrchni prvek zasobniku. Vraci hodnotu odebraneho prvku, pokud je zasobnik prazdny vraci null.
    /// </summary>
    /// <returns></returns>
    public int? Pop()
    {
        if (IsEmpty())
        {
            return null;
        }
        else
        {
            return TopItem.Value;
            TopItem.Below = TopItem;
        }
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
