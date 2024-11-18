using BasicWebCore.Models;

namespace BasicWebCore.IServices
{
    public interface IProducService
    {
        Product Create(Product Product);
        void Delete(Product existingProduct);
        void Delete(string id);
        List<Product> Get();
        Product Get(string id);
        void Update(string id, Product existingProduct);
    }
}