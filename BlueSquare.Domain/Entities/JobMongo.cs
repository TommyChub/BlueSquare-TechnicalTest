using System.Collections;
using System.Collections.Generic;
using BlueSquare.Domain.Enums;

namespace BlueSquare.Domain.Entities
{
    public class JobMongo
    {
        public int Id { get; set; }

        public string Date { get; set; }

        public string Type { get; set; }

        public JobStatus Status { get; set; }

        public Customer Customer { get; set; }

        public Product Product { get; set; }

        public IEnumerable<Update> Updates { get; set; }
    }
}
