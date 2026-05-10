using System;
using System.Collections.Generic;
using System.Text;

namespace KTXForum.Core.Models
{
    public class Payment
    {
        public int paymentId { get; set; }
        public int roomRegistrationId { get; set; }
        public double amount { get; set; }
       
    }
}
