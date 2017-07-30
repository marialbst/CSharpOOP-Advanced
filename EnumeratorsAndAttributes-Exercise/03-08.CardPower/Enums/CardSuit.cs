namespace _03_08.CardPower.Enums
{
    using Attributes;

    [Type("Enumeration" , "Suit", "Provides suit constants for a Card class.")]
    public enum CardSuit
    {
        Clubs,
        Diamonds = 13,
        Hearts = 26,
        Spades = 39
    }
}
