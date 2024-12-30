namespace ParMusic.API.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int InstrumentId { get; set; }
        public Instrument Instrument { get; set; }
        public float Score { get; set; }
    }
}