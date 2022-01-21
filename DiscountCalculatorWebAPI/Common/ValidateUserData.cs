using DiscountCalculatorWebAPI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiscountCalculatorWebAPI.Common
{
    public static class ValidateUserData
    {
        public static bool session { get; set; }

        public static bool VaidateUser(string username, string password)
        {
            // Check if it is valid credential 
            UserList obj = new UserList();
            var _List = obj.GetLists();
            var result = _List.AsEnumerable().Where(r => r.UserName == username && r.Password == password).ToList();
            if (result.Count > 0)
            {
                session = true;
                return true;
            }
            else
            {
                session = false;
                return false;
            }
        }

        
    }
}