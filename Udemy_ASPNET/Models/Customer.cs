﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Udemy_ASPNET.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; } // navigation property
        public byte MembershipTypeId { get; set; }
    }
}
