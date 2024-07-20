using MongoDB.Driver;

namespace DemoWebAPIWithMongoDb.Data
{
    public class ProductDbContext
    {
        private readonly IMongoDatabase _database;
        private readonly IConfiguration _configuration;

        public ProductDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
            string connectionString = _configuration.GetConnectionString("DefaultConnection");
            string dataBaseName = _configuration.GetSection("MongoDB:DatabaseName").Value!;
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(dataBaseName);
        }
        public IMongoCollection<Product> Products =>
            _database.GetCollection<Product>(_configuration.GetSection("MongoDB:DatabaseName").Value!);
    }
}
