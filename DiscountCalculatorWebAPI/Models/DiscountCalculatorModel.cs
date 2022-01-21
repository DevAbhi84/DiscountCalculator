using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiscountCalculatorWebAPI.Models
{
    public class DiscountCalculatorModel
    {

        public double GoldPricePerGram { get; set; }

        public double ItemWeight { get; set; }

        public double Discount { get; set; }
    }
}