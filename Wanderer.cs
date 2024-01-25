public class Wanderer : Person
{
    public int UphillHeightMeters { get; private set; }
    public int DownhillHeightMeters { get; private set; }

    // Constructor calls the base class constructor with the name parameter
    public Wanderer(string name) : base(name) { }

    public void AddUphillHeightMeters(int heightMeters)
    {
        UphillHeightMeters += heightMeters;
    }

    public void AddDownhillHeightMeters(int heightMeters)
    {
        DownhillHeightMeters += heightMeters;
    }

    // Any other properties or methods specific to Wanderer
}
