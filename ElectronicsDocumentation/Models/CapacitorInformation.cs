namespace ElectronicsDocumentation.Models
{
  public class CapacitorInfomration
  {
    public string CapacitorTitle { get; set; } = "Capacitor";
    public string CapacitorBody { get; set; } = "To demonstrate how does a capacitor " +
      "work, let us consider a most basic structure of a capacitor. It is made of two " +
      "parallel conducting plates separated by a dielectric that is parallel plate " +
      "capacitor. When we connect a battery (DC Voltage Source) across the capacitor, " +
      "one plate (plate-I) gets attached to the positive end, and another plate " +
      "(plate-II) to the negative end of the battery. Now, the potential of that " +
      "battery is applied across that capacitor. At that situation, plate-I is in " +
      "positive potency with respect to the plate-II. At steady state condition, the " +
      "current from the battery tries to flow through this capacitor from its positive " +
      "plate (plate-I) to negative plate (plate-II) but cannot flow due to the " +
      "separation of these plates with an insulating material.";
    public string CapacitorEquasionVoltage { get; set; } = "V = Q / C\n" +
      "Q = Stored Energy between plates (coulombs)\n" +
      "C = Capacitance (farands)\n" +
      "V = Difference between plates (volts)";
    public string CapacitorEquasionChargeStored { get; set; } = "Q = C * V";
  }
}
