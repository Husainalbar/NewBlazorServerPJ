using System.ComponentModel.DataAnnotations;

namespace NewBlazorServerPJ.Data
{
    public class GameModel
    {
        [Key]
        public int Id { get; set; } 
        public string? GameName { get; set; }
        public DateTime? ReleaseDate { get; set; }
    }
}
