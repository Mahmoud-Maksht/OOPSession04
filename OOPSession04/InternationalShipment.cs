namespace OOPSession04;

internal class InternationalShipment:Shipment, ITrackable, IInsurable
{
    private string Destinationcountry;
    private decimal Coustomfee;

    public string DestinationCountry
    {
        get
        {
            return Destinationcountry;
        }
        set
        {
            if (!string.IsNullOrEmpty(value)) Destinationcountry = value;
        }
    }
    public decimal CustomFee
    {
        get
        {
            return Coustomfee;
        }
        set
        {
            Coustomfee = value >= 0 ? value : throw new ArgumentException("ExtraFee must be grear than or equal 0");
        }
    }
    public InternationalShipment(string trackingcode, string description, double weight, decimal deliveryfee, DeliveryAddress destination,string destinationcountry,decimal customfee):base(trackingcode,description,weight,deliveryfee,destination)
    {
        DestinationCountry = destinationcountry;
        CustomFee = customfee;
    }
    public override decimal EstimatedCost()
    {
        return DeliveryFee + (decimal)(Weight * 5) + CustomFee;
    }
    public override void PrintShipmentDetails()
    {
        
        Console.WriteLine($"Tracking Code: {TrackingCode}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Weight: {Weight} kg");
        Console.WriteLine($"Delivery Fee: ${DeliveryFee}");
        Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
        Console.WriteLine($"Estimated Cost: ${EstimatedCost()}");
        Console.WriteLine($"Destination Country: {DestinationCountry}");
        Console.WriteLine($"Custom Fee: {CustomFee:C}");
    }
    public virtual void GenerateCustomsReport()
    {
        Console.WriteLine("Customs Report");
    }
    public string GetTrackingCodeStatus()
    {
        return $"Shipment SH003: {TrackingCode} is has been delivered.";
    }
    public decimal CalculateInsurance()
    {
        return EstimatedCost() * 0.08m;
    }

}

