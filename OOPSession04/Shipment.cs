namespace OOPSession04;

public abstract class Shipment
{
    private string trackingcode;
    private string description;
    private double weight;
    private decimal deliveryfee;
    private DeliveryAddress destination;
    public string TrackingCode
    {
        get { return trackingcode; }
        private set
        {
            if (!string.IsNullOrWhiteSpace(value)) trackingcode = value;
        }
        
    }
    public string Description
    {
        get { return description; }
        set { if (!string.IsNullOrWhiteSpace(value)) description = value; }
    }
    public double Weight
    {
        get { return weight; }
        set { if (value > 0) weight = value; }
    }
    public decimal DeliveryFee
    {
        get { return deliveryfee; }
        private set { if (value > 0) deliveryfee = value; }
    }
    public DeliveryAddress Destination
    {
        get { return destination; }
        set { destination = value; }
    }
    public abstract decimal EstimatedCost();
   
    public Shipment(string trackingcode)
    {
        TrackingCode = trackingcode;
        Description = "Unknown";
        Weight = 1;
        DeliveryFee = 50;
        Destination = default;
    }
    public Shipment(string trackingcode, string description, double weight, decimal deliveryfee, DeliveryAddress destination)
    {
        TrackingCode = trackingcode;
        Description = description;
        Weight = weight;
        DeliveryFee = deliveryfee;
        Destination = destination;
    }
    public decimal UpdateDeliveryFee(decimal newFee)
    {
        if (newFee > 0)
        {
            DeliveryFee = newFee;
        }
        return DeliveryFee;
    }
   
    public abstract void PrintShipmentDetails();
   
    public void UpdateWeight(double newWeight)
    {
        if (newWeight > 0)
        {
            Weight = newWeight;
        }
    }
    public void UpdateWeight(double newWeight , double extraPackingWeight)
    {
        if(newWeight > 0 && extraPackingWeight >= 0)
        {
            Weight = newWeight + extraPackingWeight;
        }
    }
}

