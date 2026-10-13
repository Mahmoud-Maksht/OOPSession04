namespace OOPSession04;

internal class DeliveryReport
{
    public void PrintShipment(ITrackable shipment)
    {
        Console.WriteLine($"Tracking Code Status: {shipment.GetTrackingCodeStatus()}");
    }

    public void PrintInsurance(IInsurable shipment)
    {
        Console.WriteLine($"Insurance Cost: {shipment.CalculateInsurance()}");
    }
}
