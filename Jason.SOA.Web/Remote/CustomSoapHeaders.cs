using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jason.SOA.Web.Remote
{
    /// <summary>
    /// we use Header to enhance the security of a webservice
    /// </summary>
    public class CustomSoapHeaders: System.Web.Services.Protocols.SoapHeader
    {

        private string userName = string.Empty;
        private string passWord = string.Empty;

        public CustomSoapHeaders() { } // THe construction method without args is a must.

        public CustomSoapHeaders(string userName, string passWord)
        {
            this.userName = userName;
            this.passWord = passWord;
        }
        
        //Get and set user name and pwd
        public string UserName
        {
            get { return userName; }
            set { this.userName = value; }
        }

        public string PassWord
        {
            get { return passWord; }
            set { this.passWord = value; }
        }

        public bool Validate()
        {
            return this.userName.Contains("jason") && this.passWord.Contains("yuan");
        }

    }
}