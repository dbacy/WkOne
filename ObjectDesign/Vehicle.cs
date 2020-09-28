using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectDes
{
    class Vehicle
    {
        int vehicleId;
        int customerId;
        string make;
        string model;
        int mileage;

        public Vehicle(int vehicleId, int customerId, string make,
            string model, int mileage)
        {
            this.vehicleId = vehicleId;
            this.customerId = customerId;
            this.make = make;
            this.model = model;
            this.mileage = mileage;
        }

        public int VehicleId { get => vehicleId; set => vehicleId = value; }
        public int CustomerId { get => customerId; set => customerId = value; }
        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public int Mileage { get => mileage; set => mileage = value; }

        public override string ToString()
        {
            return String.Format("Customer ID: {0} \nVehicle ID: {1} " +
                "\nMake: {2} Model: {3} Mileage: {4}\n__________________________________", customerId, vehicleId
                , make, model, mileage);
        }
    }

    
}
