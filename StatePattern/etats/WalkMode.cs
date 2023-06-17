using StatePattern.interfaces;

namespace StatePattern;

public class WalkMode : ITravelMode
{
    public void Travel()
    {
        Console.WriteLine("Je voyage à pied ...");
    }
}