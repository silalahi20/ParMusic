// Data/DataSeeder.cs
namespace ParMusic.API.Data
{
    public class DataSeeder
    {
        private readonly ApplicationDbContext _context;

        public DataSeeder(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            if (!_context.Instruments.Any())
            {
                var instruments = new List<Instrument>
                {
                    new Instrument
                    {
                        Name = "Stratocaster",
                        Brand = "Fender",
                        Type = "Electric Guitar",
                        Genre = "Rock",
                        Price = 1499.99m,
                        Description = "Classic electric guitar with versatile sound",
                        StockQuantity = 10
                    },
                    new Instrument
                    {
                        Name = "Jazz Bass",
                        Brand = "Fender",
                        Type = "Bass Guitar",
                        Genre = "Jazz",
                        Price = 1299.99m,
                        Description = "Professional bass guitar with warm tone",
                        StockQuantity = 5
                    },
                    new Instrument
                    {
                        Name = "Stage Custom",
                        Brand = "Yamaha",
                        Type = "Drum Kit",
                        Genre = "Rock",
                        Price = 899.99m,
                        Description = "Complete drum kit for live performance",
                        StockQuantity = 3
                    }
                };

                await _context.Instruments.AddRangeAsync(instruments);
                await _context.SaveChangesAsync();
            }
        }
    }
}