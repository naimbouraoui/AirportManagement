// See https://aka.ms/new-console-template for more information

using AM.Core.Domain;

Console.WriteLine("Hello, World!");
//TP1.Question7
Plane plane= new Plane();
plane.Capacity = 300;
plane.ManufactureDate = new DateTime(2000, 1, 1);
plane.MyPlaneType = PlaneType.Boeing;
//TP1.Question8
Plane plane1 = new Plane(PlaneType.Airbus, 100, new DateTime(2001, 9, 12));
//Tp1.Question9
Plane plane2 = new Plane()
{
    Capacity = 100,
    ManufactureDate = new DateTime(2011, 2, 14)
};
//tp1.Question12.b
Passenger passenger= new Passenger();
Console.WriteLine(passenger.GetPassengerType());
Staff staff= new Staff();
Console.WriteLine(staff.GetPassengerType());
Traveller traveller= new Traveller();
Console.WriteLine(traveller.GetPassengerType());




