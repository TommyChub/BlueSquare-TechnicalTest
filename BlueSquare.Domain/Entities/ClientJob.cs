using BlueSquare.Domain.Enums;

namespace BlueSquare.Domain.Entities
{
    public class ClientJob
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public JobStatus Status { get; set; }

        public Customer Customer { get; set; }

        public Product Product { get; set; }
    }
}
