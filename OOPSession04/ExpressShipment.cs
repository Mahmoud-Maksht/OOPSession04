using System.Security.Cryptography.X509Certificates;

namespace OOPSession04;

internal class ExpressShipment:Shipment, ITrackable, IInsurable
{
    private decimal Extrafee;
    public ExpressShipment(string trackingcode, string description, double weight, decimal deliveryfee, DeliveryAddress destination, decimal extrafee) : base(trackingcode, description, weight, deliveryfee, destination)
    {
        ExtraFee = extrafee;
   
    }
    public decimal ExtraFee
    {
        get
        {
            return Extrafee;
        }
        set
        {
            Extrafee = value >= 0 ? value : throw new ArgumentException("ExtraFee must be grear than or equal 0");
        }
    }
    public override decimal EstimatedCost()
    {
        return DeliveryFee + (decimal)(Weight * 5) + ExtraFee;
    }
    public override void PrintShipmentDetails()
    { 
        Console.WriteLine($"Tracking Code: {TrackingCode}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Weight: {Weight} kg");
        Console.WriteLine($"Delivery Fee: ${DeliveryFee}");
        Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
        Console.WriteLine($"Estimated Cost: ${EstimatedCost()}");
        Console.WriteLine($"Extra Fee: {ExtraFee:C}");
    }
    public string GetTrackingCodeStatus()
    {
        return $"Shipment SH002: {TrackingCode} is out for delivery.";
    }
    public decimal CalculateInsurance()
    {
        return EstimatedCost() * 0.08m;
    }

   
}

