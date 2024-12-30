// DTOs/UserPreferenceDto.cs
namespace ParMusic.API.DTOs
{
    public class UserPreferenceDto
    {
        public string PreferredGenre { get; set; } = string.Empty;
        public string PreferredInstrumentType { get; set; } = string.Empty;
        public decimal MaxBudget { get; set; }
        public List<string> FavoriteSongs { get; set; } = new();
    }
}