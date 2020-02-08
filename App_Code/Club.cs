using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Club
/// </summary>
public class Club
{
    public Club()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public string clubName;

    public string Clubname
    {
        get { return clubName; }
        set { clubName = value; }
    }

    public string clubCity;

    public string ClubCity
    {
        get { return clubCity; }
        set { clubCity = value; }
    }
    public int clubRegistrationNumber;

    public int ClubRegistrationNumber
    {
        get { return clubRegistrationNumber; }
        set { clubRegistrationNumber = value; }
    }


    public string clubAddress;

    public string ClubAddress
    {
        get { return clubAddress; }
        set { clubAddress = value; }
    }
}