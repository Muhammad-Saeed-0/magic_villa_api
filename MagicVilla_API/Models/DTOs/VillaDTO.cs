using System.ComponentModel.DataAnnotations;

namespace MagicVilla_API.Models.DTOs
{
    public class VillaDTO
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string? Name { get; set; }
    }
}
