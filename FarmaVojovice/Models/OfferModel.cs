using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace FarmaVojovice.Models
{
    public class OfferModel
    {
        public string Name { get; set; }
        public string Cost { get; set; }
        public string DeadDate { get; set; }
        public string Description { get; set; }
    }
}