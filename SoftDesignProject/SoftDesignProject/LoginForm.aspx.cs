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
            string[] userbase = { "bob", "chris", "hunter" };
            if (Login1.UserName == "admin") {
                if (Login1.Password == "password")
                {
                    //redirect to administrator page when using "admin"
                    Welcome.USERNAME = Login1.UserName;
                    Response.Redirect("Welcome.aspx");
                }
            }
            foreach (string x in userbase)
            {
                if (Login1.UserName.Contains(x))
                {
                    //redirect to user page when using standard email login (stored in string array)
                    Welcome.USERNAME = Login1.UserName;
                    Response.Redirect("Welcome.aspx");
                }
            }
        }
        protected void AboutUs_Click(object sender, EventArgs e)
        {
            Response.Redirect("About.aspx");
        }
        protected void ContactUs_Click(object sender, EventArgs e)
        {
            Response.Redirect("Contact.aspx");
        }
    }
}
