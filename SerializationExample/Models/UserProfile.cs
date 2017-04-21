using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationExample.Models
{
    [Serializable]
    public class UserProfile
    {
        public DateTime Birthday { get; set; }
        public bool Sex { get; set; }
        public string avatarUrl { get; set; }
    }
}
