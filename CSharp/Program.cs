using CSharp.Data;

//to run the program, use the following terminal command from the CSharp project folder
//      >
//      > dotnet run
//      >

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
