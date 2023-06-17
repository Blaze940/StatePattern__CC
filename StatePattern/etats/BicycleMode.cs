using StatePattern.interfaces;

namespace StatePattern;

public class BicycleMode : ITravelMode
{
    public void Travel()
    {
        Console.WriteLine("Je voyage en vélo ...");
    }
}