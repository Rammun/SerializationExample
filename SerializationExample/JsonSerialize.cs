using Newtonsoft.Json;
using SerializationExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationExample
{
    public class JsonSerialize
    {
        // Newtonsoft http://www.newtonsoft.com/json

        public static void Do(ApplicationUser model)
        {
            string json = JsonConvert.SerializeObject(model);
            Console.WriteLine(json);
            Console.ReadKey();

            var ob = JsonConvert.DeserializeObject<ApplicationUser>(json);
            Console.WriteLine("Name: {0}, count: {1}", ob.UserName, ob.Quests.Count);
            Console.ReadKey();

        }
    }
}
