using System.ComponentModel.DataAnnotations;

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
    }
}