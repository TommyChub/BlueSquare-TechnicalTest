using BlueSquare.Domain.Enums;

namespace BlueSquare.Domain.Entities
{
    public class Update
    {
        public string Timestamp { get; set; }

        public JobStatus Status { get; set; }
    }
}
