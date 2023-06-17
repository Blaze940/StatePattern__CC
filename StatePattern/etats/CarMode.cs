using StatePattern.interfaces;

namespace StatePattern;

public class CarMode : ITravelMode
{
    public void Travel()
    {
        Console.WriteLine("Je voyage en voiture ...");
    }
}