namespace S2_Ex5;

public class Car
{
    public string Color {get; set; }
    public double EngineSize{ get; set; }
    public double FuelEconomy{ get; set; }
    public bool isManualShift { get; set; }

    public Car(double engineSize, double fuelEconomy, bool isManualShift, string color)
    {
        EngineSize = engineSize;
        FuelEconomy = fuelEconomy;
        this.isManualShift = isManualShift;
        Color = color;
    }


    public override string ToString()
    {
        return
            $"Color: {Color} \nEngineSize: {EngineSize} \nFuelEconomy: {FuelEconomy} \nManual shift: {isManualShift}";
    }
}