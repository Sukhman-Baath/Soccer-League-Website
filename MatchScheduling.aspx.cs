using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;


public partial class MatchScheduling : System.Web.UI.Page
{
    //sukhmanbaath-300986381
    int check = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        string connectionString1 = ConfigurationManager.ConnectionStrings["SoccerLeague"].ConnectionString;
        SqlConnection con1 = new SqlConnection(connectionString1);

        SqlCommand cmd1 = new SqlCommand("Select * from MatchTable", con1);
        con1.Open();
        SqlDataReader rdr = cmd1.ExecuteReader();

        GridViewMatch.DataSource = rdr;
        GridViewMatch.DataBind();
        con1.Close();


        if (!IsPostBack)
        {
            Calendar2.Visible = false;

            
            string connectionString = ConfigurationManager.ConnectionStrings["SoccerLeague"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);


            SqlCommand cmd = new SqlCommand("Select * from ClubTable", con);

            con.Open();
            DropDownList1.DataSource = cmd.ExecuteReader();
            DropDownList1.DataTextField = "ClubName";
            DropDownList1.DataValueField = "ClubRegistrationNo";
            DropDownList1.DataBind();
            con.Close();
            con.Open();
            DropDownList2.DataSource = cmd.ExecuteReader();
            DropDownList2.DataTextField = "ClubName";
            DropDownList2.DataValueField = "ClubRegistrationNo";
            DropDownList2.DataBind();
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


    protected void ImageButtonCalenderClick(object sender, ImageClickEventArgs e)
    {
        if (Calendar2.Visible)
        {
            Calendar2.Visible = false;
        }
        else
            Calendar2.Visible = true;
    }
    protected void Calendar2_SelectionChanged(object sender, EventArgs e)
    {
        DateTextBox.Text = Calendar2.SelectedDate.ToShortDateString();

        Calendar2.Visible = false;
    }

    protected void MatchButton_Click(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedItem.Text == DropDownList2.SelectedItem.Text)
        {
            Response.Write("<script>alert('INVALID SELECTION') </script>");

        }
        else
        {


            DateTime date1 = Convert.ToDateTime(DateTextBox.Text);
            

            string connectionString1 = ConfigurationManager.ConnectionStrings["SoccerLeague"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString1);

            SqlCommand cmd = new SqlCommand("Select MatchDate from MatchTable", con);


            con.Open();
            using (SqlDataReader read = cmd.ExecuteReader())
            {

                while (read.Read())
                {
                    string date2 = read["MatchDate"].ToString();
                    DateTime date3 = Convert.ToDateTime(date2);

                    var days = (date1 - date3).Days;
                    if (days <= 2)
                    {
                        check = check + 1;
                        Response.Write("<script>alert('You cannot select this date as its less than a two days gap with an existing match') </script>");
                    }
                }
                read.Close();
            }


            con.Close();





            if (check == 0)
            {
                Response.Write("<script>alert('MATCH SCHEDULED SUCCESSFULLY') </script>");

                {
                    SqlConnection conn;
                    SqlCommand comm;

                    string connectionString = ConfigurationManager.ConnectionStrings["SoccerLeague"].ConnectionString;
                     conn = new SqlConnection(connectionString);


                   

                    comm = new SqlCommand("insert into MatchTable(HostClub, GuestClub, MatchDate) values( @HostClub, @GuestClub,@MatchDate )", conn);

                    comm.Parameters.AddWithValue("@HostClub", DropDownList1.SelectedItem.Text);

                    comm.Parameters.AddWithValue("@GuestClub", DropDownList2.SelectedItem.Text);

                    comm.Parameters.AddWithValue("@MatchDate", Convert.ToDateTime(DateTextBox.Text));








                    try
                    {

                        conn.Open();

                        comm.ExecuteNonQuery();
                        Response.Redirect("MatchScheduling.aspx");

                    }
                    catch (SqlException ex)
                    {
                        Label11.Visible = true;
                        Label11.Text = ex.Message;
                    }
                    finally
                    {

                        conn.Close();
                    }

                }
            }
        }
    }


    protected void Calendar2_DayRender(object sender, DayRenderEventArgs e)
    {
        if(DateTime.Now >= e.Day.Date)
        {
            e.Cell.Font.Strikeout = true;
            e.Day.IsSelectable = false;
        }
    }
}
//sukhmanbaath-300986381

