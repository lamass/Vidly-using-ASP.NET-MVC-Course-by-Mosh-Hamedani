﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class DetailsViewModel
    {
        public Customer CustomerDetail { get; set; }
        public MembershipType MembershipType { get; set; }
    }
}