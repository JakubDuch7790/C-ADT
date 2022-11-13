namespace BasicDataStructures.LinkedList
{
    /// <summary>
    /// Trida Node slouzi pro reprezentaci objektu v oboustranne spojovanem seznamu.
    /// </summary>
    public class MyLinkedListNode
    {
        /// <summary>
        /// Reprezentuje ulozenou hodnotu/objekt
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Reference na nasledujici prvek v seznamu
        /// </summary>
        public MyLinkedListNode? Next { get; set; }

        /// <summary>
        /// Reference na predchazejici prvek v seznamu
        /// </summary>
        public MyLinkedListNode? Previous { get; set; }
    }
}
