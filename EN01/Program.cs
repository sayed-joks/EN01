using EN01.DatabaseContext;

namespace EN01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using AirLineDbContext dbContext = new AirLineDbContext();
            using ITIDbContext iTIDbContext = new ITIDbContext();
        }
    }
}
