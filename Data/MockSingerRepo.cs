using Prueba.Models;

namespace Prueba.Data
{
    public class MockSingerRepo : ISingerRepo
    {
        public Singer GetSinger(int singer_id)
        {
            return new Singer
            {
                Id = singer_id,
                Name = "Eminem",
                // Description = "Best Rapper ever",
                // Rating = 5
            };
        }
    }
}