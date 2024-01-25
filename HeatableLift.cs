public class HeatableLift : Lift
{
    public bool IsHeatingOn { get; private set; }
    public int TargetTemperature { get; private set; }

    public HeatableLift(LiftType type, int capacity, int heightDifference)
        : base(type, capacity, heightDifference)
    {
        // Standardmäßig ist die Heizung aus, wenn eine neue beheizbare Anlage erstellt wird.
        IsHeatingOn = false;
    }

    public void SwitchHeating(bool on)
    {
        IsHeatingOn = on;
    }

    public bool SetTargetTemperature(int temperature)
    {
        if (temperature < 15 || temperature > 26)
        {
            return false; // Ungültige Temperatur.
        }

        TargetTemperature = temperature;
        return true;
    }
}
