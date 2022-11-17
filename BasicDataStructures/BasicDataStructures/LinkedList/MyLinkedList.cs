
namespace BasicDataStructures.LinkedList;

/// <summary>
/// Trida LinkedList reprezentuje spojovany seznam
/// </summary>
public class MyLinkedList
{
    /// <summary>
    /// Reference na prvni prvek seznamu
    /// </summary>
    public MyLinkedListNode? First { get; private set; }


    /// <summary>
    /// Reference na posledni prvek seznamu
    /// </summary>
    public MyLinkedListNode? Last { get; private set; }

    /// <summary>
    /// Vlozi na konec seznamu (za prvek last) novy uzel s hodnotou value.Vraci nove vlozeny objekt.
    /// </summary>
    /// <param name="value">Hodnota vlozena do seznamu</param>
    public MyLinkedListNode Insert(int value)
    {
        var newNode = new MyLinkedListNode()
        {
            Value = value,
            Previous = Last,
            Next = null

        };

        if (Last == null)
        {
            First = newNode;
            
        }
        else 
        {
            Last.Next = newNode;
        }
        Last = newNode;
        return newNode;
        
    }

    /// <summary>
    /// Vraci referenci na prvni vyskyt uzlu s hodnotou value v seznamu.
    /// Pokud se hodnota v seznamu nenachazi, vraci null.
    /// </summary>
    /// <param name="value">Hodnota hledaneho uzlu seznamu</param>
    /// <returns></returns>
    public MyLinkedListNode? Search(int value)
    {
        if (First == null)
        {
            return null;
        }

        var currentNode = First;

        while (currentNode != null)
        {
            if (currentNode.Value == value)
            {
                return currentNode;
            }
            currentNode = currentNode.Next;
        }
        return null;
    }

    /// <summary>
    /// Smaze uzel node v seznamu.
    /// </summary>
    /// <param name="node"></param>
    public void Delete(MyLinkedListNode node)
    {

        var nextNode = node.Next;
        {
            if (node == Last)
            {
                Last = node.Previous;
            }
            else if (nextNode != null)
            {
                nextNode.Previous = node.Previous;
            }
            if (node == First)
            {
                node.Next = First;
            }
            else if (node.Previous != null)
            {
                node.Next = node.Previous.Next;
            }
        }
    }

    /// <summary>
    /// Vytvorí obrátenú kópiu pôvodného LinkedListu bez toho, aby bol zmenený (!!!).
    /// Príklad: zoznam s uzlami A (first) ukazuje na Next uzol B, ktorý ukazuje cez Previous na A
    /// a zároveň ukazuje cez Next na uzol C. Ten ukazuje na uzol B cez prev a zároveň je Last.
    /// 
    /// Reverse vytvorí nad týmto zoznamom vytvorí nasledujúcu verziu:
    /// First uzol C ukazuje cez Next na B, ktorý spätne ukazuje cez Previous na C. B zároveň ukazuje cez
    /// Next na A. Ten ukazuje na B cez Previous a zároveň je Last zoznamu.
    /// </summary>
    /// <returns>Obrátená verzia pôvodného zoznamu</returns>
    public MyLinkedList Reverse()
    {
        throw new NotImplementedException();
    }

    public bool IsEmpty()
    {
        return First == null && Last == null;
    }
}
