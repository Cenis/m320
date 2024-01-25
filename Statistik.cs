using System;
using System.Collections.Generic;
using System.Linq;

public class Statistik
{
    private Skigebiet skigebiet;

    public Statistik(Skigebiet skigebiet)
    {
        this.skigebiet = skigebiet;
    }

    // Methoden zur Berechnung von Statistiken wie Gesamtdistanz und Höhenmeter
    // Beispiel einer Methode zur Berechnung der gesamten gefahrenen Distanz:
    public double BerechneGesamtdistanz()
    {
        return skigebiet.Abfahrten.Sum(abfahrt => abfahrt.Piste.Laenge);
    }

    // Beispiel einer Methode zur Berechnung der zurückgelegten Höhenmeter:
    public int BerechneGesamteHöhenmeter()
    {
        // Diese Methode würde die Höhenmeter aus den Abfahrten summieren.
        // Sie benötigen hierfür weitere Daten, die aktuell im Modell nicht vorhanden sind.
        return 0; // Platzhalter, da weitere Implementierungsdetails fehlen.
    }
}
