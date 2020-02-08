using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ClubRepository
/// </summary>
public class ClubRepository
{
    public ClubRepository()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public List<Club> GetClubs()
    {
        return (List<Club>)HttpContext.Current.Application["clubs"];
    }
    public void Update(Club newClub)
    {

    }



}