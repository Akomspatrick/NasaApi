using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NassaApi.Controllers
{
    public class PacketDto2
    {
        public readonly string extreEdgeOfPlateau;
        public readonly string takeoffPoint;
        public readonly string pathToTake;




    }

    public record PacketDto ( string extreEdgeOfPlateau,string takeoffPoint, string pathToTake);




    
}