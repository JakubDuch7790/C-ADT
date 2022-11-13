using System.Security.Cryptography;

namespace BasicDataStructures.LinkedList;

/// <summary>
/// Trida LinkedList reprezentuje spojovany seznam
/// </summary>
public class MyLinkedList
{
    /// <summary>
    /// Reference na prvni prvek seznamu
    /// </summary>
    public MyLinkedListNode? First { get; set; }


    /// <summary>
    /// Reference na posledni prvek seznamu
    /// </summary>
    public MyLinkedListNode? Last { get; set; }

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
       
    }
}
