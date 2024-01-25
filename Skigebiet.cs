using System;
using System.Collections.Generic;
using System.Linq;

public class Skigebiet
{
    private List<Abfahrt> abfahrten = new List<Abfahrt>();
    private List<Piste> pisten = new List<Piste>();

    public List<Abfahrt> Abfahrten => abfahrten;  // Öffentlicher Getter für Abfahrten

    public void AddAbfahrt(Abfahrt abfahrt)
    {
        abfahrten.Add(abfahrt);
    }

    public void AddPiste(Piste piste)
    {
        pisten.Add(piste);
    }

    // Entfernen Sie die Methoden 'RecordJourney', 'AddUphillHeightMeters' und 'AddDownhillHeightMeters'
    // da sie nicht direkt zu 'Skigebiet' gehören sollten, sondern zu 'WintersportEnthusiast'

    // Hier können weitere Methoden hinzugefügt werden
}
