using System.Collections.Generic;
using BlueSquare.Domain.Enums;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BlueSquare.Domain.Entities
{
    public class Job
    {
        [BsonId]
        [BsonElement("job_id")]
        public string Id { get; set; }

        [BsonRequired]
        [BsonElement("job_date")]
        public string Date { get; set; }

        [BsonRequired]
        [BsonElement("job_type")]
        public string Type { get; set; }

        [BsonRequired]
        [BsonElement("job_status")]
        public JobStatus Status { get; set; }

        public Customer Customer { get; set; }

        public Product Product { get; set; }

        public IEnumerable<Update> Updates { get; set; }
    }
}
