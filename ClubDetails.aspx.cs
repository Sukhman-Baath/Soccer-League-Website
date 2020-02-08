using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;
using System.Data;

public partial class ClubDetails : System.Web.UI.Page
{
    //sukhmanbaath-300986381
    String name;
    int count = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["PageName"] = "ClubDetails.aspx";
        if (!IsPostBack)
        {
            // BindList();
            BindList();
        }
    }
        private void BindList()
        {
        string connectionString = ConfigurationManager.ConnectionStrings["SoccerLeague"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);

       
        SqlCommand cmd = new SqlCommand("Select * from ClubTable where ClubRegistrationNo="+(string)Session["ClubRegistrationNo"], con);
        SqlCommand cmdP = new SqlCommand("Select * from PlayerTable where ClubRegistrationNo=" + (string)Session["ClubRegistrationNo"], con);
        con.Open();
        SqlDataReader rdr = cmd.ExecuteReader();
        GridViewClub.DataSource = rdr;
        GridViewClub.DataBind();
        con.Close();
        con.Open();
        SqlDataReader rdrP = cmdP.ExecuteReader();
        playerList.DataSource = rdrP;
        playerList.DataBind();
        con.Close();
        
    }



    protected void DeleteButton_Click1(object sender, EventArgs e)
    {
        if (System.Web.HttpContext.Current.User.Identity.IsAuthenticated)
        {
            SqlConnection conn;
            SqlCommand comm1;
            SqlCommand comm2;
            string sqlString2;
            

            string connectionString = ConfigurationManager.ConnectionStrings["SoccerLeague"].ConnectionString;
            // Initialize connection
           
             conn = new SqlConnection(connectionString);

            
            SqlCommand cmdN = new SqlCommand("Select ClubName from ClubTable where ClubRegistrationNo=" + (string)Session["ClubRegistrationNo"],conn);
            conn.Open();
            using (SqlDataReader read = cmdN.ExecuteReader())
            {
               
              while(read.Read())
                {
                    String name = read["ClubName"].ToString();
                    count++;
                    read.Close();
                    conn.Close();
                    
                    sqlString2 = "DELETE from [MatchTable] where HostClub= @Club OR GuestClub= @Club";
                    try
                    {
                        conn.Open();
                        SqlCommand comm3 = new SqlCommand(sqlString2, conn);
                        comm3.Parameters.AddWithValue("@Club", name);
                        comm3.CommandType = CommandType.Text;
                        comm3.ExecuteNonQuery();

                    }
                    finally
                    {
                        conn.Close();
                        
                    }
                    if (count == 1)
                        break;
                }
            }

           

            




            string sqlString = "DELETE  from ClubTable where ClubRegistrationNo=" + (string)Session["ClubRegistrationNo"];
            string sqlString1 = "DELETE  from PlayerTable where ClubRegistrationNo=" + (string)Session["ClubRegistrationNo"];
            



            //sukhmanbaath-300986381

            comm1 = new SqlCommand(sqlString, conn);
            comm2 = new SqlCommand(sqlString1, conn);
         

            try
            {
                conn.Open();

                comm1.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = ex.Message;
            }
            finally
            {

                conn.Close();
            }

            try
            {
                conn.Open();

                comm2.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = ex.Message;
            }
            finally
            {

                conn.Close();
            }
           


            Response.Redirect("Clubs.aspx");
            Response.Write("<script>alert('CLUB DELETED SUCCESSFULLY') </script>");
        }
        else
        {
            Response.Redirect("LoginCheck.aspx");
        }
      
    }
    //sukhmanbaath-300986381




   


    protected void playerList_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "EditItem")
        {
            if (System.Web.HttpContext.Current.User.Identity.IsAuthenticated)
            {
                playerList.EditItemIndex = e.Item.ItemIndex;
                BindList();
            }
            else
            {
                Response.Redirect("LoginCheck.aspx");
            }
        }
        else if (e.CommandName == "CancelEditing")
        {
            playerList.EditItemIndex = -1;
            BindList();
        }
        else if (e.CommandName == "UpdateItem")
        {
            int playerId = Convert.ToInt32(e.CommandArgument);
            TextBox nameTextBox = (TextBox)e.Item.FindControl("nameTextBox");
            TextBox dobTextBox = (TextBox)e.Item.FindControl("dobTextBox");
            TextBox jerseyTextBox = (TextBox)e.Item.FindControl("jerseyTextBox");

            string newName = nameTextBox.Text;
            string newdob = dobTextBox.Text;
            string newjerseyNo = jerseyTextBox.Text;

            UpdateItem(playerId, newName, newdob, newjerseyNo);

            playerList.EditItemIndex = -1;
            BindList();
        }
    }

    private void UpdateItem(int playerId, string newName, string newdob,string newjerseyNo)
    {
        SqlConnection conn;
        SqlCommand comm;
        // Read the connection string from Web.config
         
        string connectionString = ConfigurationManager.ConnectionStrings["SoccerLeague"].ConnectionString;
        conn = new SqlConnection(connectionString);


        // Initialize connection

        comm = new SqlCommand("update PlayerTable set PlayerName=@Name, DOB=@DOB , JerseyNo=@JerseyNo where PlayerId = @PlayerId", conn);
        
        

        // Create command 
    

      

        comm.Parameters.Add("@PlayerId", System.Data.SqlDbType.Int);
        comm.Parameters["@PlayerId"].Value = playerId;
        comm.Parameters.Add("@Name", System.Data.SqlDbType.NVarChar, 50);
        comm.Parameters["@Name"].Value = newName;
        comm.Parameters.Add("@DOB", System.Data.SqlDbType.Date);
        comm.Parameters["@DOB"].Value = newdob;
        comm.Parameters.Add("@JerseyNo", System.Data.SqlDbType.Int);
        comm.Parameters["@JerseyNo"].Value = newjerseyNo;

        try
        {
            // Open the connection
            conn.Open();
            // Execute the command
            comm.ExecuteNonQuery();

        }
        catch (SqlException ex)
        {

        }
        finally
        {
            // Close the connection
            conn.Close();
        }
    }
}












