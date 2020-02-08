using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;


public partial class AddClubs : System.Web.UI.Page
{
    
    //sukhmanbaath-300986381
    protected void Page_Load(object sender, EventArgs e)
    {
        
      if(! IsPostBack)
        {
            Calendar1.Visible = false;
        }
        
    }
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Session["PageName"] = "AddClub.aspx";
        if ((string)Session["theme"] != null)
        {
            Page.Theme = (string)Session["theme"];
        }
        else
        {
            Page.Theme = "Light";
        }
    }


    protected void SaveClubButton_Click(object sender, EventArgs e)
    {
        Response.Write("<script>alert('CLUB SAVED SUCCESSFULLY') </script>");
        AddPlayerButton.Visible = true;


        TextBox NameTextBox = WebUserControl1.FindControl("NameTextBox") as TextBox;
        TextBox CityTextBox = WebUserControl1.FindControl("CityTextBox") as TextBox;

        string ClubName = NameTextBox.Text;
        string ClubCity = CityTextBox.Text;
        SqlConnection conn;
        SqlCommand comm;
        // Read the connection string from Web.config
        string connectionString = ConfigurationManager.ConnectionStrings["SoccerLeague"].ConnectionString;
        // Initialize connection
       
        conn = new SqlConnection(connectionString);

       
        // Create command 
        

        comm = new SqlCommand("insert into ClubTable(ClubName, ClubCity, ClubRegistrationNo , ClubAddress) values( @ClubName, @ClubCity, @RegistrationNumber, @Address)", conn);
        
        comm.Parameters.AddWithValue("@ClubName", ClubName);

        comm.Parameters.AddWithValue("@ClubCity", ClubCity);

        comm.Parameters.AddWithValue("@RegistrationNumber", RegistrationTextBox.Text);
        comm.Parameters.AddWithValue("@Address", AddressTextBox.Text); 


        try
        {

            conn.Open();

            comm.ExecuteNonQuery();

        }
        catch (SqlException ex)
        {
            Label6.Visible = true;
            Label6.Text = ex.Message;
        }
        finally
        {

            conn.Close();
        }

    }
    //sukhmanbaath-300986381
    protected void AddPlayerButton_Click(object sender, EventArgs e)
    { 
        Label3.Visible = true;
        Label4.Visible = true;
        Label5.Visible = true;
        TextBoxPlayerName.Visible = true;
        TextBoxDOB.Visible = true;
        TextBoxJersey.Visible = true;
        SubmitPlayerButton.Visible = true;
        ImageButtonCalender.Visible = true;
        CancelPlayerButton.Visible = true;
        
    }

    protected void ImageButtonCalender_Click(object sender, ImageClickEventArgs e)
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
        TextBoxDOB.Text = Calendar1.SelectedDate.ToShortDateString();

        Calendar1.Visible = false;
    }

    protected void CancelPlayerButton_Click(object sender, EventArgs e)
    {
        TextBoxPlayerName.Text = null;
        TextBoxJersey.Text = null;
        TextBoxDOB.Text = null;
        Response.Write("<script>alert('CANCELLED') </script>");


    }

    protected void SubmitPlayerButton_Click(object sender, EventArgs e)
    {

         
        SqlConnection conn;
        SqlCommand comm;
        // Read the connection string from Web.config
        string connectionString = ConfigurationManager.ConnectionStrings["SoccerLeague"].ConnectionString;
        // Initialize connection
        
         conn = new SqlConnection(connectionString);


        
        // Create command 
       comm = new SqlCommand("insert into PlayerTable(PlayerName, DOB, JerseyNo, ClubRegistrationNo ) values( @PlayerName, @DOB, @JerseyNo, @ClubRegistrationNumber)", conn);

        comm.Parameters.AddWithValue("@PlayerName", TextBoxPlayerName.Text);

        comm.Parameters.AddWithValue("@DOB", Convert.ToDateTime(TextBoxDOB.Text));
        comm.Parameters.AddWithValue("@JerseyNo", TextBoxJersey.Text);
        comm.Parameters.AddWithValue("@ClubRegistrationNumber", RegistrationTextBox.Text); 
        try
        {

            conn.Open();

            comm.ExecuteNonQuery();

        }
        catch (SqlException ex)
        {
            Label6.Text = ex.Message;
        }
        finally
        {

            conn.Close();
        }
        Response.Write("<script>alert('PLAYER HAS BEEN SAVED SUCCESSFULLY') </script>");
        //sukhmanbaath-300986381
    }

    protected void CancelButton_Click(object sender, EventArgs e)
    {

        TextBox NameTextBox = WebUserControl1.FindControl("NameTextBox") as TextBox;
        TextBox CityTextBox = WebUserControl1.FindControl("CityTextBox") as TextBox;

        NameTextBox.Text = null;
        CityTextBox.Text = null;
        AddressTextBox.Text = null;
        RegistrationTextBox.Text = null;
      



    }
}