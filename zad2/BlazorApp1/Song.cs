using System.ComponentModel.DataAnnotations;

namespace BlazorApp1 {
    public class Song {
        public int Id { get; set; }
        public string? SongTitle { get; set; }
        public string? SongArtist { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }
        public float? Rating { get; set; }
        public int? RatingCount { get; set; }
        public string? Url { get; set; }
    }
}
