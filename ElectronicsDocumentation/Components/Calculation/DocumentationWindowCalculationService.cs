using System.Globalization;

namespace ElectronicsDocumentation.Components.Calculation
{
  public class DocumentationWindowCalculationService
  {
    public string CalculateResistance(float voltage, float amperage)
    {
      return Convert.ToString(voltage / amperage);
    }

    public string CalculateCapacitorVoltage()
    {
      return "";
    }
  }
}
