using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationExample.Models
{
    [Serializable]
    public class Quest
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public int Rate { get; set; }
        public bool Active { get; set; }
        public virtual List<Stage> Stages { get; set; }

        public Quest()
        {
            Stages = new List<Stage>();
        }
    }
}
