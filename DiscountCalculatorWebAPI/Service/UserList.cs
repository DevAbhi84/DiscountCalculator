using DiscountCalculatorWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiscountCalculatorWebAPI.Service
{
    public class UserList
    {
        public List<LoginModel> GetLists()
        {
            List<LoginModel> _List = new List<LoginModel>()
            {
                new LoginModel(){UserName="Abhishek",Password = "Password123"},
                new LoginModel(){UserName="admin",Password = "admin"},
            };

            return _List;
        }
    }
}