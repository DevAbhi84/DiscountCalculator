using DiscountCalculatorWebAPI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DiscountCalculatorWebAPI.Controllers
{
    [AuthenticateUser]
    public class ApiAuthenicationController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new List<string>();
        }
         
        // GET api/<controller>/5
        public double Get(double? GoldPricePerGram,double? ItemWeight,double? Discount = 0)
        {
            double TotalPrice = Convert.ToDouble(GoldPricePerGram * ItemWeight);

            if (Convert.ToDouble(Discount) != 0 )
            {
                TotalPrice = Convert.ToDouble(TotalPrice - ((Discount * TotalPrice) / 100));
            }
            return TotalPrice;
        }

        // POST api/<controller>
        public bool Post([FromBody]string value)
        {
            return true;
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}