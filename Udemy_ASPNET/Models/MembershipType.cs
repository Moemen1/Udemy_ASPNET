using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Udemy_ASPNET.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public short SignUpFee { get; set; } // short because we dont need any values more than 30000
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
    }
}
