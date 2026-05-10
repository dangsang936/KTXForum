using System;
using System.Collections.Generic;
using System.Text;

namespace KTXForum.Core.Models
{
    public class ParkingRegistration
    {
        public int parkingRegistrationId { get; set; }
        public int vehicleId { get; set; }
        public int durationMonths { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public decimal totalPrice { get; set; }
        public string status { get; set; }
    }
}