using BasicWebCore.Data;
using BasicWebCore.IServices;
using BasicWebCore.Models;
using MongoDB.Driver;

namespace BasicWebCore.Services
{

    public class ProductService : IProductService
    {
        private readonly IMongoCollection<Product> Products;
        private readonly DbConfiguration mongoDbConfig = new DbConfiguration();

        public ProductService(IConfiguration config)
        {
            var conObj1 = config.GetSection("ConnectionStrings").Value;
            dynamic conObj2 = config.GetSection("ConnectionStrings").Value;
            config.GetSection("MongoDbConnection").Bind(mongoDbConfig);
            MongoClient client = new MongoClient(mongoDbConfig.ConnectionString);
            IMongoDatabase database = client.GetDatabase(mongoDbConfig.DatabaseName);
            Products = database.GetCollection<Product>(mongoDbConfig.CollectionName);
        }


        /// <summary>
        /// Retrieving Product details
        /// </summary>
        /// <returns></returns>
        public List<Product> Get()
        {
            //var jObject = JsonConvert.DeserializeObject<Product>(Products.Find(Product => true).ToList());
            return Products.Find(Product => true).ToListAsync().Result;
        }

        public Product Get(string id)
        {
            return Products.Find(Product => Product.Id == id).FirstOrDefaultAsync().Result;
        }

        /// <summary>
        /// Creating a new Product
        /// </summary>
        /// <param name="Product"></param>
        /// <returns></returns>
        public Product Create(Product Product)
        {
            Products.InsertOneAsync(Product).ConfigureAwait(false);
            return Product;
        }

        /// <summary>
        /// Updating the existing Product information
        /// </summary>
        /// <param name="id"></param>
        /// <param name="existingProduct"></param>
        public void Update(string id, Product existingProduct)
        {
            Products.ReplaceOneAsync(Product => Product.Id == id, existingProduct);
        }

        /// <summary>
        /// Removing Product details
        /// </summary>
        /// <param name="existingProduct"></param>
        public void Delete(Product existingProduct)
        {
            Products.DeleteOne(Product => Product.Id == existingProduct.Id);

        }

        public void Delete(string id)
        {
            Products.DeleteOneAsync(Product => Product.Id == id);
        }

        //public List<Product> Search(int ageFilter, string stateFilter)
        //{
        //    // LINQ to get list of Product being searched.
        //    IQueryable<Product> Product = from u in Products.AsQueryable()
        //                            where u.Age > 0 && u.Age <= ageFilter
        //                            select u;

        //    //var ProductDetails = Products.AsQueryable().Where(u => u.Age >= Convert.ToInt32(searchQuery) && u.Age <= 30).ToList();

        //    if (!string.IsNullOrEmpty(stateFilter))
        //    {
        //        Products.AsQueryable().Where(u => u.Home[0].state.Contains(stateFilter)).ToList();
        //    }

        //    return Product.ToList();
        //}
    }
}
