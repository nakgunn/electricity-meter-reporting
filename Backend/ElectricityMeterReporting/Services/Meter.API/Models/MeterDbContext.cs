using Microsoft.EntityFrameworkCore;
namespace Meter.API.Models
{
    public class MeterDbContext : DbContext
    {
        public MeterDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Meter.API.Models.Entities.Meter> Meters { get; set; }


        // Entity'e ulaşmak için uzun olarak path tanımlamak durumunda kaldım. Using ile kullamadım o sebeple "Meter.API.Models.Entities.Meter" bu şekilde kullandım.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var initialMeters = new List<Meter.API.Models.Entities.Meter>();
            for (int i = 1; i <= 10; i++)
            {
                initialMeters.Add(new Meter.API.Models.Entities.Meter
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = GenerateSerialNumber(),
                    MeasurementCurrent = GenerateDiff(),
                    MeasurementVoltage = GenerateDiff(),
                    LastIndex = GenerateIndex(), // 1 ile 50 arasında rastgele bir değer
                    LastIndexDate = DateTime.Now
                });
            }

            modelBuilder.Entity<Meter.API.Models.Entities.Meter>().HasData(initialMeters);
        }

        public static string GenerateSerialNumber()
        {
            var random = new Random();
            string prefix = "SN";
            string numbers = random.Next(100000, 1000000).ToString();
            return prefix + numbers;
        }

        public static decimal GenerateIndex()
        {
            var random = new Random();
            var index = (decimal)(random.NextDouble() * (50 - 1) + 1);
            return index;
        }

        public static decimal GenerateDiff()
        {
            var random = new Random();
            var index = (decimal)(random.NextDouble() * 10);
            return index;
        }
    }
}
