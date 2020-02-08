using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

public partial class Results : System.Web.UI.Page
{
    //sukhmanbaath-300986381
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Calendar1.Visible = false;

            string connectionString = ConfigurationManager.ConnectionStrings["SoccerLeague"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);


            SqlCommand cmd = new SqlCommand("Select * from ClubTable", con);

            con.Open();
            DropDownListTeam.DataSource = cmd.ExecuteReader();
            DropDownListTeam.DataTextField = "ClubName";
            DropDownListTeam.DataValueField = "ClubRegistrationNo";
            DropDownListTeam.DataBind();
            con.Close();
            con.Open();
            DropDownList2.DataSource = cmd.ExecuteReader();
            DropDownList2.DataTextField = "ClubName";
            DropDownList2.DataValueField = "ClubRegistrationNo";
            DropDownList2.DataBind();
            con.Close();
            con.Open();
            DropDownList3.DataSource = cmd.ExecuteReader();
            DropDownList3.DataTextField = "ClubName";
            DropDownList3.DataValueField = "ClubRegistrationNo";
            DropDownList3.DataBind();
            con.Close();


        }

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

    protected void ImageButtonCalenderClick(object sender, ImageClickEventArgs e)
    {
        if (Calendar1.Visible)
        {
            Calendar1.Visible = false;
        }
        else
            Calendar1.Visible = true;
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        DateTextBox.Text = Calendar1.SelectedDate.ToShortDateString();

        Calendar1.Visible = false;
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
       
        string connectionString = ConfigurationManager.ConnectionStrings["SoccerLeague"].ConnectionString;
        SqlConnection conn = new SqlConnection(connectionString);

        String SqlString = "Select * from ResultTable where WinnerTeam=@Club OR LooserTeam=@Club";
        try
        {
            conn.Open();
            SqlCommand comm = new SqlCommand(SqlString, conn);
            comm.Parameters.AddWithValue("@Club", DropDownListTeam.SelectedItem.Text);
            SqlDataReader rdr = comm.ExecuteReader();
            GridViewResult.DataSource = rdr;
            GridViewResult.DataBind();
        }




        finally
        {
            conn.Close();

        }

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection conn;
        SqlCommand comm;
        // Read the connection string from Web.config
        string connectionString = ConfigurationManager.ConnectionStrings["SoccerLeague"].ConnectionString;
        // Initialize connection

        conn = new SqlConnection(connectionString);


        
        // Create command 
        comm = new SqlCommand("insert into ResultTable(WinnerTeam, LooserTeam, DateOfMatch ) values( @WinnerTeam, @LooserTeam, @DateOfMatch)", conn);

        comm.Parameters.AddWithValue("@WinnerTeam", DropDownList2.SelectedItem.Text);

        comm.Parameters.AddWithValue("@LooserTeam", DropDownList3.SelectedItem.Text);
        comm.Parameters.AddWithValue("@DateOfMatch", Convert.ToDateTime(DateTextBox.Text));
        
        try
        {

            conn.Open();

            comm.ExecuteNonQuery();

        }
        catch (SqlException ex)
        {
            
        }
        finally
        {

            conn.Close();
        }
        Response.Write("<script>alert('MATCHRESULT HAS BEEN UPDATED SUCCESSFULLY') </script>");
        //sukhmanbaath-300986381
    }
}
    


      