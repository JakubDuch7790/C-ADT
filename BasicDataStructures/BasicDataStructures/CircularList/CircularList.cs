namespace BasicDataStructures.CircularList;

/// <summary>
/// Jednostranne spojovany seznam (LinkedList) znate z prednasky - jde o zretezeny seznam
/// uzlu (Node), kde kazdy uzel ukazuje na sveho naslednika. V tomto prikladu
/// nemame first a last, seznam je zadany "prvnim" ze svych uzlu.
///
/// Tato uloha pracuje se dvema typy jednostranne spojovanych seznamu:
/// Linearni seznam - kde posledni prvek seznamu ukazuje na None.
/// Kruhovy seznam - kde posledni prvek seznamu ukazuje zpet na prvni prvek.
///
/// Zjednoduseni:
/// Pro vsechny funkce muzete predpokladat, ze seznam na vstupu obsahuje
/// vzajemne ruzne klice a ze je linearni nebo kruhovy, tj. nemusite napriklad
/// osetrovat situaci, kdy naslednikem "posledniho" v seznamu je "druhy".
/// </summary>
public class CircularList
{
    /// <summary>
    /// "Prvý" a zároveň "posledný" uzol kruhového zoznamu
    /// </summary>
    public CircularListNode? StartEnd { get; set; }

    /// <summary>
    /// Prvá úloha. V prípade, že je zoznam kruhový, vráti true, inak false. Prázdny zoznam nie je kruhový.
    /// </summary>
    /// <returns>True, ak je zoznam kruhový. Inak false</returns>
    public bool IsCircular()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Druhá úloha. Vráti dĺžku kruhového zoznamu (t. j. počet rôznych uzlov) zoznamu. Pre prázdny zoznam vracia 0.
    /// </summary>
    /// <returns>Počet unikátnych uzlov v zozname</returns>
    public int GetLength()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Úloha 3. Korektne naplni polozky "opposite" v uzlech kruhoveho seznamu sude delky. Tj. pro kruhove seznamy
    /// delky 2n (párnej dĺžky) naplni u kazdeho uzlu polozku opposite uzlem, ktery je o n kroku dale
    /// (tedy v kruhu je to uzel "naproti").
    /// 
    /// Napriklad v kruhovem seznamu 1 -> 2 -> 3 -> 4 (-> 1) je opposite
    /// uzlu 1 uzel 3, uzlu 2 uzel 4, uzlu 3 uzel 1 a uzlu 4 uzel 2.
    /// Pokud vstupni seznam neni kruhovy nebo ma lichou delku, metoda seznam neupravuje. 
    /// 
    /// Pozor na casovou a prostorovou slozitost vaseho algoritmu! Měla by být O(n) k délce seznamu.
    /// </summary>
    public void SetOpposites()
    {
        throw new NotImplementedException();
    }
}
