using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Players
/// </summary>
public class Players
{
    public Players()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public String playerName;
    public string PlayerdName
    {
        get { return playerName; }
        set { playerName = value; }
    }

    

    public string dateOfBirth;
    public string DateOfBirth
    {
        get { return dateOfBirth; }
        set { dateOfBirth = value; }
    }

    public int jerseyNumber;

    public int JerseyNumber
    {
        get { return jerseyNumber; }
        set { jerseyNumber = value; }
    }
    public int clubNumber;

    public int ClubNumber
    {
        get { return clubNumber; }
        set { clubNumber = value; }
    }

}
