using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebUserControl : System.Web.UI.UserControl
{
    //sukhmanbaath-300986381
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
        
        ((List<Club>)Application["clubs"]).Add(
            new Club
            {

                clubName = NameTextBox.Text,
                clubCity = CityTextBox.Text
            });
       
        Response.Redirect("clubs.aspx");

    }
    //sukhmanbaath-300986381
    public string Name
    {
        get
        {
            return NameTextBox.Text;
        }
        
    }

    public string City
    {
        get
        {
            return CityTextBox.Text;
        }

    }
    //sukhmanbaath-300986381

}