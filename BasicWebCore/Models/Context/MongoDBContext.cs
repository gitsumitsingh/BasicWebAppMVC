using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace BasicWebCore.Models.Context
{

    public class MongoDBContext : DbContext //IdentityDbContext<ApplicationUser>
    {
        private IMongoClient _client;
        private IMongoDatabase _database { get; }

        /// <summary> 
        /// Author  : Sumit Singh
        /// Date    : 21/Nov/2024
        /// Scope   : Get MongoDb Database
        /// </summary>
        /// <returns>MongoDb Database</returns> 
        public MongoDBContext(DbContextOptions<MongoDBContext> options, IOptions<ConfigSettings> settings) : base(options)
        {
            //Getting database related values from appsettings json
            string ConnStr = settings.Value.MongoConnectionString;
            string DbName = settings.Value.DatabaseName;
            var mongoUrl = MongoUrl.Create(ConnStr);
            try
            {
                _client = new MongoClient(ConnStr);
                _database = new MongoClient(mongoUrl).GetDatabase(DbName);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Author  : Sumit Singh
        /// Date    : 21/Nov/2024
        /// Scope   : Get MongoDb Collection by passing Collection name and Model name
        /// </summary>
        /// <returns>MongoDb Collection</returns>       
        public IMongoCollection<T> GetCollection<T>(string CollectionName)
        {
            try
            {
                return _database.GetCollection<T>(CollectionName);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
