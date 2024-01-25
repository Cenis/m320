public class Lift
{
    public LiftType Type { get; private set; }
    public int Capacity { get; set; } // Beförderungskapazität pro Stunde.
    public int HeightDifference { get; set; } // Höhendifferenz zwischen Tal- und Bergstation.

    public Lift(LiftType type, int capacity, int heightDifference)
    {
        Type = type;
        Capacity = capacity;
        HeightDifference = heightDifference;
    }
}
