namespace ParMusic.API.Models
{
    public class UserPreference
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string PreferredGenre { get; set; }
        public string PreferredInstrumentType { get; set; }
        public decimal MaxBudget { get; set; }
        public List<string> FavoriteSongs { get; set; }
    }
}