namespace OOPSession04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            // Q1
            // What is Abstraction in Object - Oriented Programming ?
            // is the process of hiding unnecessary implementation details and showing only the essential features of an object to the user.
            // Why is abstraction considered one of the four pillars of OOP?
            // because it reduces complexity, hides unnecessary implementation details, and allows users to focus on the essential features of an object. This makes code easier to understand, maintain, and reuse.

            // Q2
            // What is the difference between an Abstract Class and an Interface?
            // Abstract Class: Can contain both abstract and non-abstract methods, fields, and constructors and can inherit from only one abstract class. It is used when there is a common base class that provides some implementation for its subclasses.
            // Interface: Can only contain abstract methods, properties, events, and indexers. It cannot contain fields or constructors. A class can implement multiple interfaces.
            // When would you choose an Interface instead of an Abstract Class?
            // when we need implementation 100%.
            // Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?
            // A class cannot inherit from multiple abstract classes, but it can implement multiple interfaces.
            #endregion

            #region Part02
            Console.WriteLine("---------- Delivery Center ----------");
            Console.WriteLine("-------------------------------------");
            Console.Write("Entre Center Name:");
            string centername = Console.ReadLine();
            DeliveryCenter center = new DeliveryCenter(centername);
            Console.WriteLine("---------- StandardShipment ----------");
            Console.Write("Entre TrackingCode :");
            string trackingcode = Console.ReadLine();
            Console.Write("Entre Decription :");
            string desription = Console.ReadLine();
            Console.Write("Entre Weight :");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Entre DeliveryFee :");
            decimal deliveryfee = decimal.Parse(Console.ReadLine());
            Console.Write("Enter city :");
            string city = Console.ReadLine();
            Console.Write("Entre Street :");
            string street = Console.ReadLine();
            Console.Write("Entre BuildingNumber :");
            int buildingNumber = int.Parse(Console.ReadLine());
            DeliveryAddress deliveryAddress = new DeliveryAddress(city, street, buildingNumber);
            StandardShipment standardShipment = new(trackingcode, desription, weight, deliveryfee, deliveryAddress);

            Console.WriteLine("---------- Express Shipment ----------");
            Console.Write("Entre TrackingCode :");
            string trackingcode2 = Console.ReadLine();
            Console.Write("Entre Decription :");
            string desription2 = Console.ReadLine();
            Console.Write("Entre Weight :");
            double weight2 = double.Parse(Console.ReadLine());
            Console.Write("Entre DeliveryFee :");
            decimal deliveryfee2 = decimal.Parse(Console.ReadLine());
            Console.Write("Enter city :");
            string city2 = Console.ReadLine();
            Console.Write("Entre Street :");
            string street2 = Console.ReadLine();
            Console.Write("Entre BuildingNumber :");
            int buildingNumber2 = int.Parse(Console.ReadLine());
            Console.Write("Entre Extrafee :");
            decimal extrafee = decimal.Parse(Console.ReadLine());
            DeliveryAddress deliveryAddress2 = new DeliveryAddress(city2, street2, buildingNumber2);
            ExpressShipment expressShipment = new ExpressShipment(trackingcode2, desription2, weight2, deliveryfee2, deliveryAddress2, extrafee);

            Console.WriteLine("---------- International Shipment ----------");
            Console.Write("Entre TrackingCode :");
            string trackingcode3 = Console.ReadLine();
            Console.Write("Entre Decription :");
            string desription3 = Console.ReadLine();
            Console.Write("Entre Weight :");
            double weight3 = double.Parse(Console.ReadLine());
            Console.Write("Entre DeliveryFee :");
            decimal deliveryfee3 = decimal.Parse(Console.ReadLine());
            Console.Write("Enter city :");
            string city3 = Console.ReadLine();
            Console.Write("Entre Street :");
            string street3 = Console.ReadLine();
            Console.Write("Entre BuildingNumber :");
            int buildingNumber3 = int.Parse(Console.ReadLine());
            Console.Write("Entre DestenationCountry :");
            string destenationcountry = Console.ReadLine();
            Console.Write("Entre CustomFee :");
            decimal customfee = decimal.Parse(Console.ReadLine());
            DeliveryAddress deliveryAddress3 = new DeliveryAddress(city3, street3, buildingNumber3);
            InternationalShipment internationalShipment = new InternationalShipment(trackingcode3, desription3, weight3, deliveryfee3, deliveryAddress3, destenationcountry, customfee);

            center.AddShipment(standardShipment);
            center.AddShipment(expressShipment);
            center.AddShipment(internationalShipment);

            Console.WriteLine("--------- Print Shipments ---------");
            center.PrintAllShipments();

            Console.WriteLine("---------- Tracking Statuses ----------");
            center.GetTrackingCodeStatuses();

            Console.WriteLine("---------- Insurance ----------");
            center.PrintInsuranceCosts();

            ITrackable[] trackables =  { standardShipment, expressShipment, internationalShipment };
            foreach (ITrackable trackable in trackables)
            {
                Console.WriteLine($"Tracking Code: {trackable.GetTrackingCodeStatus()}");
            }

            IInsurable[] insurables = { standardShipment, expressShipment, internationalShipment };
            foreach (IInsurable insurable in insurables)
            {
                Console.WriteLine($"Insurance Cost: {insurable.CalculateInsurance()}");
            }
            #endregion
        }   
    }
}
