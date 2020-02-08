using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PlayersRepository
/// </summary>
public class PlayersRepository
{
    public PlayersRepository()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public List<Players> GetPlayers()
    {
        return (List<Players>)HttpContext.Current.Application["players"];
    }
    public void Update(Players newPlayers)
    {

    }
}