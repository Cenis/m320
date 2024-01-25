using System;

public class Abfahrt
{
    private readonly DateTime startzeit;
    private DateTime endzeit;
    public Piste Piste { get; private set; }

    public Abfahrt(Piste piste)
    {
        Piste = piste;
        startzeit = DateTime.Now; // oder ein anderer Mechanismus zum Festlegen der Startzeit
    }

    public void SetEndzeit()
    {
        endzeit = DateTime.Now; // oder ein anderer Mechanismus zum Festlegen der Endzeit
    }

    public TimeSpan Dauer => endzeit - startzeit;

    public double Durchschnittsgeschwindigkeit => Piste.Laenge / Dauer.TotalHours;
}
