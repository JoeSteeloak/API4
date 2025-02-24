using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API4.Models {

    public class Song {
        //Properties
        public int SongId { get; set; }

        [Required]
        public string? artist { get; set; }
        [Required]
        public string? title { get; set; }

        public int length { get; set; }
        [Required]
        public string? category { get; set; }

        // Koppling till Album
        public int AlbumId { get; set; } // Foreign Key
        [JsonIgnore]
        public Album? Album { get; set; } // Navigation Property
    }
}