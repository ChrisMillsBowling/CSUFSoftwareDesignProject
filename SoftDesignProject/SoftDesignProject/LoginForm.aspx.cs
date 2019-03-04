using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoftDesignProject
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            
        }

        protected void Login1_LoggingIn(object sender, LoginCancelEventArgs e)
        {
         
        }

        protected void Password_TextChanged(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            if (Login1.UserName == "admin") {
                //redirect to administrator page when using "admin"
            }
            if (Login1.UserName == "email") {
                //redirect to user page when using standard email login (stored in some document)
            }
        }
    }
}
