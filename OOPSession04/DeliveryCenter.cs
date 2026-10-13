using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace OOPSession04;

internal class DeliveryCenter
{
    private string Centername;
    private Shipment[]? shipments;
    public Driver Driver { get; set; }
    public DeliveryCenter(string centername)
    {
        shipments = new Shipment[20];
        Centername = centername;
    }

    public Shipment this[int index]
    {
        get
        {
            if (index >= 0 && index < shipments.Length)
            {
                return shipments[index];
            }
            return default;
        }
        set
        {
            if (index >= 0 && index < shipments.Length)
            {
                shipments[index] = value;
            }
        }

    }

    public Shipment this[string trackingcode]
    {
        get
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i].TrackingCode == trackingcode)
                    return shipments[i];
            }

            return default;
        }
    }
    public bool AddShipment(Shipment shipment)
    {
        for (int i = 0; i < shipments.Length; i++)
        {
            if (shipments[i] == null)
            {
                shipments[i] = shipment;
                return true;
            }
        }
        return false;
    }
    public bool RemoveShipment(string trackingcode)
    {
        for (int i = 0; i < shipments.Length; i++)
        {
            if (shipments[i].TrackingCode == trackingcode)
            {
                shipments[i] = default;
                return true;
            }
        }
        return false;
    }
    public void PrintAllShipments()
    {
        for (int i = 0; i < shipments.Length; i++)
        {
            if (shipments[i] != null)
            {
                shipments[i].PrintShipmentDetails();
            }
        }
    }
    public void GetTrackingCodeStatuses()
    {
        foreach (Shipment shipment in shipments)
        {
            if (shipment is ITrackable trackable)
            {
                Console.WriteLine($"Tracking Code: {shipment.TrackingCode}, Status: {trackable.GetTrackingCodeStatus()}");
            }
        }
    }
    public void PrintInsuranceCosts()
    {
        foreach (Shipment shipment in shipments)
        {
            if (shipment is IInsurable insurable)
            {
                Console.WriteLine($"Insurance Cost: ${insurable.CalculateInsurance()}");
            }
        }
    }
}





