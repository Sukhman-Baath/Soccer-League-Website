using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        
        if (Membership.ValidateUser(Login1.UserName, Login1.Password))
        {
            Login1.Visible = true;
            Session["user"] = User.Identity.Name;
            FormsAuthentication.RedirectFromLoginPage(Login1.UserName, true);
            if (Session["PageName"] != null)
                Response.Redirect((string)Session["PageName"]);
            else
                Response.Redirect("Default.aspx");
        }
    }
}