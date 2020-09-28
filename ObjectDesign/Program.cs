using System;

namespace ObjectDes
{
    class Program
    {
        static void Main(string[] args)
        {
            Custormer myCustormer = new Custormer(1638,"Derek","000-000-0000" );
            Console.WriteLine(myCustormer);

            Service myService = new Service(1003,473824,1638,"Oil Change",
                50.00m,10);
            Console.WriteLine(myService);


            Vehicle myVehicle = new Vehicle(473824,1638,"Chevy","Corvette",2500);
            Console.WriteLine(myVehicle);
        }
    }
}
