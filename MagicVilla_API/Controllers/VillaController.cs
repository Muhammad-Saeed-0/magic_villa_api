using MagicVilla_API.Models;
using MagicVilla_API.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace MagicVilla_API.Controllers
{
    [Route("api/Villa")]
    [ApiController]
    public class VillaController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDTO> GetVillas()
        {
            return new List<VillaDTO>
            { 
                new VillaDTO{Id = 1, Name = "Villa1" },
                new VillaDTO{Id = 2, Name="Villa2"}

            };
        }
    }
}
