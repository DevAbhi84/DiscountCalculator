using DiscountCalculatorWebAPI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http.Filters;
using System.Linq;

namespace DiscountCalculatorWebAPI.Common
{
    public class AuthenticateUser : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(System.Web.Http.Controllers.HttpActionContext actionContext)
        {

            if (!ValidateUserData.session)
            {
                //var abc= actionContext.Request.Headers..Parameter;
                if (actionContext.Request.Headers.Authorization == null)
                {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
                }
                else
                {
                    // Gets header parameters  
                    string authenticationString = actionContext.Request.Headers.Authorization.Parameter;
                    string originalString = Encoding.UTF8.GetString(Convert.FromBase64String(authenticationString));

                    // Gets username and password  
                    string _username = Convert.ToString(originalString.Split(':')[0]);
                    string _pswd = Convert.ToString(originalString.Split(':')[1]);

                    // Validate username and password  
                    if (!ValidateUserData.VaidateUser(_username, _pswd))
                    {
                        // returns unauthorized error  
                        actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
                    }
                }
            }

            base.OnAuthorization(actionContext);
        }

        
    }
}