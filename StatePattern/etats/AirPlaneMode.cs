using StatePattern.interfaces;

namespace StatePattern;

public class AirPlaneMode : ITravelMode
{
    public void Travel()
    {
        Console.WriteLine("Je voyage en avion ...");
    }
}