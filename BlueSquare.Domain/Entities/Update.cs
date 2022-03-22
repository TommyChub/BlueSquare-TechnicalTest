using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueSquare.Domain.Enums;

namespace BlueSquare.Domain.Entities
{
    public class Update
    {
        public string Timestamp { get; set; }

        public JobStatus Status { get; set; }
    }
}
