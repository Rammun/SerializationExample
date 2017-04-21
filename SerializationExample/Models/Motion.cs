using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationExample.Models
{
    [Serializable]
    public class Motion
    {
        public string Description { get; set; }
        public int NextStageId { get; set; }
    }
}
