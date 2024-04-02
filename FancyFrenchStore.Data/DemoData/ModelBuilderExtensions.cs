using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace FancyFrenchStore
{
    public static class ModelBuilderExtensions
    {
        public static void SeedFromJson<T>(this ModelBuilder modelBuilder, string filePath) where T : class
        {
            using var reader = new StreamReader(filePath);
            string json = reader.ReadToEnd();
            var entities = JsonSerializer.Deserialize<List<T>>(json);
            modelBuilder.Entity<T>().HasData(entities);
        }
    }
}
