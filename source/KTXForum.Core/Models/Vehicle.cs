using System;
using System.Collections.Generic;
using System.Text;

namespace KTXForum.Core.Models
{
    public class Vehicle
    {
        public int vehicleId { get; set; }
        public int userId { get; set; }
        public string licensePlate { get; set; }
        public string vehicleType { get; set; }
    }
}