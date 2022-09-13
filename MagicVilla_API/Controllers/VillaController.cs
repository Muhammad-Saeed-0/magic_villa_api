using MagicVilla_API.Data;
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
            return VillaStore.villas;
        }

        [HttpGet("id")]
        public VillaDTO? GetVilla(int id)
        {
            return VillaStore.villas.FirstOrDefault(v=>v.Id==id);
        }
    }
}
