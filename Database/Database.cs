using System;
using System.Threading.Tasks;
using GTANetworkAPI;
using MySql.Data.MySqlClient;


public class Database
{
    private static readonly string connString = "Server=localhost;User=root;Database=server;Password=7452;Pooling=true";

    public static async Task Connection()
    {
        await using var conn = new MySqlConnection(connString);
        try
        {
            await conn.OpenAsync();
            NAPI.Util.ConsoleOutput("Database connection is done");
        }
        catch(Exception e)
        {
            NAPI.Util.ConsoleOutput(e.ToString());
        }
        finally
        {
            await conn.CloseAsync();
        }
    }

}