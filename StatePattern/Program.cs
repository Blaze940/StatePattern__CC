using System;
using StatePattern.contexts;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Transport transport = new Transport();

            // Mode par défaut
            transport.Travel();

            // Changement de mode
            // Voyage en voiture
            transport.TravelMode = new CarMode();
            transport.Travel();

            // Voyage à vélo
            transport.TravelMode = new BicycleMode();
            transport.Travel();

            // Voyage en avion
            transport.TravelMode = new AirPlaneMode();
            transport.Travel();
        }
    }
}