using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace Jason.SOA.Web.Remote
{
    /// <summary>
    /// Summary description for MyWebService
    /// </summary>
    [WebService(Namespace = "http://jasonexeruri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MyWebService : System.Web.Services.WebService
    {
        public CustomSoapHeaders CustomSoapHeaders;

        [WebMethod] //Must have this tag.
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int Plus (int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        [System.Web.Services.Protocols.SoapHeader("CustomSoapHeaders")]
        public List<WebserviceUser> GetUsers()
        {   
            if (this.CustomSoapHeaders != null && this.CustomSoapHeaders.Validate())
            {
                return new List<WebserviceUser>()
                {
                    new WebserviceUser()
                    {
                        Id=100,
                        Name ="User 1",
                        Profile = "Come from China"
                    },

                    new WebserviceUser()
                    {
                        Id=101,
                        Name ="User 2",
                        Profile = "Come from USA"
                    }

                };
            }
            else
            {
                throw new SoapException("User validation failed", SoapHeaderException.ServerFaultCode);
            }

        }
    }

    public class WebserviceUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Profile { get; set; }
        
    }
}
