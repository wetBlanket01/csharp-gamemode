using System;
using GTANetworkAPI;

public class Events : Script
{
    [ServerEvent(Event.ResourceStart)]
    public async void OnResurceStart()
    {
        NAPI.Util.ConsoleOutput("Welcome");
        
        await Database.Connection();
    }
}