using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SetUpPage : System.Web.UI.Page
{
    //sukhmanbaath-300986381
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void RadioButtonBlue_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void Page_PreInit(object sender, EventArgs e)
    {
        if ((string)Session["theme"] != null)
        {
            Page.Theme = (string)Session["theme"];
        }
        else
        {
            Page.Theme = "Light";
        }
    }
    //sukhmanbaath-300986381

    protected void ButtonColor_Click(object sender, EventArgs e)
    {
        if(RadioButtonDark.Checked)
        {
            Session["theme"] = "Dark";
        }
        if(RadioButtonLight.Checked)
        {
            Session["theme"] = "Light";
        }
        Response.Redirect("Default.aspx");
    }
}
//sukhmanbaath-300986381