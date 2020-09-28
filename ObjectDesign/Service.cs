using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectDes
{
    class Service
    {
        int serviceId;
        int carId;
        int customerId;
        string serviceDescription;
        decimal cost;
        int timeToComplete;

        public Service(int serviceId, int carId, int customerId, 
            string serviceDescription, decimal cost, int timeToComplete)
        {
            this.ServiceId = serviceId;
            this.CarId = carId;
            this.CustomerId = customerId;
            this.ServiceDescription = serviceDescription;
            this.Cost = cost;
            this.TimeToComplete = timeToComplete;
        }

        public decimal Cost { get => cost; set => cost = value; }
        public int TimeToComplete { get => timeToComplete; set => timeToComplete = value; }
        public string ServiceDescription { get => serviceDescription; set => serviceDescription = value; }
        public int CustomerId { get => customerId; set => customerId = value; }
        public int CarId { get => carId; set => carId = value; }
        public int ServiceId { get => serviceId; set => serviceId = value; }

        public override string ToString()
        {
            return String.Format("Customer ID: {0} \nService ID: {1} " +
                "\nCar ID: {2} \nDescription: {3} \ncost: {4} " +
                "\nTime to complete: {5}\n__________________________________", customerId, ServiceId
                , carId, ServiceDescription, cost, timeToComplete);
        }
    }

  

}




