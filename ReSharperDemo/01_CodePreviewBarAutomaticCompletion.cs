using System;
using ReSharperDemo;

public class Flights
{
    public void CallEmirates()
    {
        var total = 200;
        var emirates = new Emirates();

        //Place the cursor at the end of a word in one of the methods below and press Ctrl+Space
        //You will see the complete symbol options and then press Tab on the option you want
        emirates.GetLocation();
        emirates.CalculateReward();

        //Ctrl+Space x2 will find the Controller reference from the ReSharperDemos.Tests project and import it
        //ExcelPackage

        //Invoke quick info by pressing Ctrl+Q on the class and the method name
        var mango = new Mango();
        mango.FlightInfo("JE", true);

        //Alt+Enter change all local
        //Console.WriteLine(abc);
        //Console.WriteLine(abc);
        //Console.WriteLine(abc);
    }
}