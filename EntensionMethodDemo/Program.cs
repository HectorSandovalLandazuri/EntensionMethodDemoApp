// See https://aka.ms/new-console-template for more information

"Hello World".PrintToConsole();
HotelRoomModel room=new HotelRoomModel();
room.TurnOnAir().SetTemperature(24).OpenShades();
room.TurnOffAir().CloseShades();




public class HotelRoomModel
{
    public int Temperature { get; set; }
    public bool IsAirRunning { get; set; }
    public bool AreShadesOpen { get; set; }

}


public static class ExtensionSamples
{
    public static void PrintToConsole(this string message)
    {
        Console.WriteLine(message);
    }

    public static  HotelRoomModel TurnOnAir(this HotelRoomModel room)
    {
        room.IsAirRunning = true;
        return room;
    }

    public static HotelRoomModel TurnOffAir(this HotelRoomModel room)
    {
        room.IsAirRunning = false;
        return room;
    }

    public static HotelRoomModel SetTemperature(this HotelRoomModel room,int temperature)
    {
        room.Temperature = temperature;
        return room;
    }

    public static HotelRoomModel OpenShades(this HotelRoomModel room)
    {
        room.AreShadesOpen = true;
        return room;
    }

    public static HotelRoomModel CloseShades(this HotelRoomModel room)
    {
        room.AreShadesOpen = false;
        return room;
    }
}
