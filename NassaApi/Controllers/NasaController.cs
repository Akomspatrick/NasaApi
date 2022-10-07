using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NasaLib;
using System.Net.Sockets;

namespace NassaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NasaController : ControllerBase
    {
        [HttpGet()]
        public IActionResult Get([FromBody] PacketDto packet)
        {
            
            var plat = packet.extreEdgeOfPlateau.Trim().Split(' ').Select(int.Parse).ToList();
            var plateau = new Plateau(0, 0, plat[0], plat[1]);
            

            var x = new Rover(packet.takeoffPoint, plateau).Move(packet.pathToTake).PresentLocation();
            return Ok(x);
        }
        [HttpPost()]
        public IActionResult Post([FromBody] PacketDto packet)
        {
            var plat = packet.extreEdgeOfPlateau.Trim().Split(' ').Select(int.Parse).ToList();
            var plateau = new Plateau(0, 0, plat[0], plat[1]);
            var x = new Rover(packet.takeoffPoint,plateau).Move(packet.pathToTake).PresentLocation();
            return Ok(x);
        }
    }
}
