using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace StormIsComing
{
    internal class StormDistanceCalculaor


    {

        private const double speedlighsound = 0.32;
            

        public static double CalculateDistance(double time)
        {
            double distance;
            
            distance = time * speedlighsound;
            return distance;
        }
        
        public static string MessageByDistance(double miliseconds)
        {
            double distance = CalculateDistance(miliseconds);
            

            switch ( distance)
            {
                case <= 2000:
                    return ("You are inside the storm,approximately " + distance +  " meters away");
                    break;

                case  <= 4000:
                    return "Storm is very near,approximately "  + distance +  " meters away";
                    break;
                case  <= 8000:
                    return ("Storm is very close,approximately "  + distance +  " meters away");
                    break;
                case > 8000:
                    return ("Storm is pretty far ,approximately "  + distance +  " meters away");
                    break;
 
            }
            return "Invalid result";
        }
    }
}
