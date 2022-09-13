using MagicVilla_API.Models.DTOs;

namespace MagicVilla_API.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villas= new List<VillaDTO>
            { 
                new VillaDTO{Id = 1, Name = "Villa1" },
                new VillaDTO{Id = 2, Name="Villa2"}

            };
    }
}
