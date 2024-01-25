public class Piste
{
    public string Bezeichnung { get; private set; }
    public string Schwierigkeitsgrad { get; private set; }
    public double Laenge { get; private set; }

    public Piste(string bezeichnung, string schwierigkeitsgrad, double laenge)
    {
        Bezeichnung = bezeichnung;
        Schwierigkeitsgrad = schwierigkeitsgrad;
        Laenge = laenge;
    }
}
