using CSharp.Data;

class Program
{
    static void Main()
    {
        Console.WriteLine("UNO!");
        Deck deck = new Deck(); 
        foreach (var c in deck.Cards)
        {
            Console.WriteLine(c.Colour + " " + c.Action);

        }
    }
}
