using System;
using System.Collections.Generic;

public class WintersportEnthusiast
{
    public string Name { get; private set; }
    public int Age { get; set; }
    public char Gender { get; set; }
    public Ticket? Ticket { get; set; }  // Nullable, falls beim Erstellen kein Ticket vorhanden ist
    public Wintersportgeraet? Sportgeraet { get; set; }  // Nullable, falls beim Erstellen kein Sportgerät vorhanden ist
    public List<string> PreferredSkiBrands { get; set; } = new List<string>();
    public List<string> ActivityLog { get; private set; } = new List<string>();

    public WintersportEnthusiast(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name ist erforderlich.");
        }
        Name = name;
    }

    public void AddActivity(string activity)
    {
        ActivityLog.Add($"{DateTime.Now}: {activity}");
    }

    public void StartAbfahrt(Piste piste)
    {
        if (piste != null)
        {
            AddActivity($"Start Abfahrt auf Piste {piste.Bezeichnung}");
        }
    }

    public void EndAbfahrt(Piste piste)
    {
        if (piste != null)
        {
            AddActivity($"Ende Abfahrt auf Piste {piste.Bezeichnung}");
        }
    }

    public void UseLift(Lift lift)
    {
        AddActivity($"Benutzung des Lifts {lift.Type}");
    }

    // Rest des Klassen-Codes...
}
