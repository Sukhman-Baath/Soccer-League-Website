using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

public partial class AddClub : System.Web.UI.Page
{
    //sukhmanbaath-300986381
    protected void Page_Load(object sender, EventArgs e)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["SoccerLeague"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);

        
        SqlCommand cmd = new SqlCommand("Select ClubRegistrationNo,ClubName, ClubCity from ClubTable", con);
        
        con.Open();
        SqlDataReader rdr = cmd.ExecuteReader();
        NameCityDataList.DataSource = rdr;
        NameCityDataList.DataBind();
        con.Close();
        
    }
    //sukhmanbaath-300986381
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

    protected void NameCity_ItemCommand( object source, DataListCommandEventArgs e)
    {
        if(e.CommandName == "ViewDetails")
        {
            Session["ClubRegistrationNo"] = e.CommandArgument;
            Response.Redirect("ClubDetails.aspx");
        }
    }

}
//sukhmanbaath-300986381