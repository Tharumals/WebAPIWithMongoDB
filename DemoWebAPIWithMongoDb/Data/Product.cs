﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DemoWebAPIWithMongoDb.Data
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        [BsonElement("Name")]
        public string? Name { get; set; }
        [BsonElement("Description")]
        public string? Description { get; set; }
        [BsonElement("Quantity")]
        public int Quantity { get; set; }
    }
}
