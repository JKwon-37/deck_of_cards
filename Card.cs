class Card
{
    public string Name {get; set;}
    public string Suit {get;set;}
    public int Val {get;set;}

    public Card(string name, string suit, int val)
    {
        Name = name;
        Suit = suit;
        Val = val;
    }

    public void Print ()
    {
        Console.WriteLine($"This card is a {Name} of {Suit} which has the value of {Val}.");
    }

}