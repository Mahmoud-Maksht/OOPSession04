using System.ComponentModel;

namespace OOPSession04;

internal class StandardShipment:Shipment , ITrackable, IInsurable
{
    public StandardShipment(string trackingcode, string description, double weight, decimal deliveryfee, DeliveryAddress destination):base (trackingcode, description, weight, deliveryfee, destination)
    {
        
    }
    public override decimal EstimatedCost()
    {
        return DeliveryFee + (decimal)(Weight * 5);
    }
    public override void PrintShipmentDetails()
    {
        Console.WriteLine($"Tracking Code: {TrackingCode}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Weight: {Weight} kg");
        Console.WriteLine($"Delivery Fee: ${DeliveryFee}");
        Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
        Console.WriteLine($"Estimated Cost: ${EstimatedCost()}");
    }
   
    public decimal CalculateInsurance()
    {
        return EstimatedCost() * 0.05m;
    }

    public string GetTrackingCodeStatus()
    {
        return $"Shipment SH001: {TrackingCode} is ready."; 
    }
}
