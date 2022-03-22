using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueSquare.Domain.Enums;

namespace BlueSquare.Domain.Entities
{
    public class Job
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public JobStatus Status { get; set; }

        public Customer Customer { get; set; }

        public Product Product { get; set; }
    }
}
