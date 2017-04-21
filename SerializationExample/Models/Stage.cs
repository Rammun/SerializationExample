using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializationExample.Models
{
    [Serializable]
    public class Stage
    {
        [XmlAttribute("id")]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int Point { get; set; }
        public virtual List<Motion> Motions { get; set; }
        
        public Stage()
        {
            Motions = new List<Motion>();
        }
    }
}
