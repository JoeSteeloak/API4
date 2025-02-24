using System.ComponentModel.DataAnnotations;

namespace API4.Models {

    public class Album {
        //Properties
        public int AlbumId { get; set; }

        [Required]
        public string? artist { get; set; }
        [Required]
        public string? title { get; set; }

        public DateOnly releaseDate { get; set; }

        // Koppling till flera låtar
        public List<Song>? Songs { get; set; } // Navigation Property
    }
}