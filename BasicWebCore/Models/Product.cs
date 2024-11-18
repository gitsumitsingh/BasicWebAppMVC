using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BasicWebCore.Models
{
    [BsonIgnoreExtraElements]
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("ProductSKU")]
        public string ProductSKU { get; set; }

        [BsonElement("Description")]
        public string Description { get; set; }

        [BsonElement("Country")]
        public string Country { get; set; }
    }
}
