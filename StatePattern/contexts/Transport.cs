using StatePattern.interfaces;

namespace StatePattern.contexts;

public class Transport
{
    public ITravelMode TravelMode { get; set; } 
    
    public Transport()
        {
            TravelMode = new WalkMode();
        }
    
    public Transport(ITravelMode travelMode)
    {
        TravelMode = travelMode;
    }

    public void Travel()
    {
        TravelMode.Travel();
    }
    
}