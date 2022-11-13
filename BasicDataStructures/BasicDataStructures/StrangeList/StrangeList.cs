using BasicDataStructures.LinkedList;

namespace BasicDataStructures.StrangeList;

/// <summary>
/// Vasi ulohou v tomto priklade je modifikovat jiz existujici strukturu
/// oboustranne zretezeneho linearniho seznamu.
///
/// Oboustranne zretezeny seznam je definovan ukazatelem first, ktery
/// ukazuje na zacatek seznamu, a ukazatelem last, ktery ukazuje na konec
/// seznamu.
///
/// Seznam s uzly a, b, c, d, e, f vypada bezne takto (v nakresu
/// vynechavame ukazatele first a last):
///       ___   ___   ___   ___   ___
///      /   \ /   \ /   \ /   \ /   \
///     a <-- b <-- c <-- d <-- e <-- f
///
/// kde obloucky nad pismeny reprezentuji dopredne sipky (napr. a --> b),
/// tedy ukazatele next.
///
/// Nas modifikovany StrangeList pouziva pro reprezentaci stejne promenne,
/// pouze ukazatele ukazuji jinam. Ukazatele next budou ukazovat ob jeden
/// uzel, ukazatele prev zustanou zachovany. Po prevedeni predchoziho
/// seznamu na StrangeList vznikne takovyto seznam (opet vynechavame
/// ukazatele first a last):
///       _________   _________
///      /         \ /         \
///     a <-- b <-- c <-- d <-- e <-- f
///            \_________/ \_________/
///
/// StrangeList je take definovan ukazatelem first, ktery ukazuje na jeho
/// zacatek, a ukazatelem last, ktery ukazuje na jeho konec, v tomto pripade
/// first - a, last - f.
/// </summary>
public class StrangeList
{
    /*
     * Ukol 1.
     * Definujte datovou strukturu StrangeList. Muzete se inspirovat definici MyLinkedList.
     * */

    /// <summary>
    /// Ukol 2.
    /// Implementujte metodu list_to_strange_list, ktera z oboustranne
    /// zretezeneho seznamu vytvori nas StrangeList.
    /// </summary>
    /// <param name="linkedList"></param>
    /// <returns></returns>
    public static StrangeList? TransformToStrangeList(MyLinkedList linkedList)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Ukol 3.
    /// Zkontroluje, ze property First a Last jsou nastaveny spravne.
    /// </summary>
    /// <returns></returns>
    public bool IsValid()
    {
        throw new NotImplementedException();
    }
}
