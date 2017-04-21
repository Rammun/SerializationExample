using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializationExample.Models
{
    [Serializable]
    //[XmlRoot("User", IsNullable = false)]
    //[XmlInclude(typeof(BaseUser))]
    public class ApplicationUser
    {
        //[XmlElement("name")]
        public string UserName { get; set; }
        public UserProfile Profile { get; set; }
        public List<Quest> Quests { get; set; }

        public ApplicationUser()
        {
            Quests = new List<Quest>();
        }
    }    
}
