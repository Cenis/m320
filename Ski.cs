public class Ski : Wintersportgeraet
{
    public List<string> Marken { get; set; }

    public Ski(List<string> marken, string bezeichnung)
    {
        if (marken == null || !marken.Any())
            throw new ArgumentException("Mindestens eine Marke muss angegeben werden.");
        
        Marken = marken;
        Bezeichnung = bezeichnung;
    }
    // Spezifische Eigenschaften und Methoden für Ski.
}
