using System.ComponentModel.DataAnnotations;

namespace API4.Models {

    public class Song {
        //Properties
        public int SongId { get; set; }

        [Required]
        public string? SongArtist { get; set; }
        [Required]
        public string? SongTitle { get; set; }

        public int SongLength { get; set; }
        [Required]
        public string? SongCategory { get; set; }
    }
}