using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectDes
{
    class Custormer
    {
        int customerId;
        string custName;
        string phoneNumber;

        public Custormer(int customerId, string custName, string phoneNumber)
        {
            this.customerId = customerId;
            this.custName = custName;
            this.phoneNumber = phoneNumber;
        }

        public int CustomerId { get => customerId; set => customerId = value; }
        public string CustName { get => custName; set => custName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }


        public override string ToString()
        {
            return String.Format("Customer ID: {0} \nCustomer Name: {1} \n" +
                "Customer Phone Number: {2}\n__________________________________", customerId, custName, phoneNumber);
        }
    }
}
