using SerializationExample.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializationExample
{
    public class XMLSerialize
    {
        public static void Do(ApplicationUser model)
        {            
            //-------------------------------------------------------------
            string text = string.Empty;
            using (var stw = new StringWriter())
            {
                var serializer = new XmlSerializer(typeof(ApplicationUser));
                serializer.Serialize(stw, model);
                text = stw.ToString();                
            }
            Console.WriteLine(text);
            Console.ReadKey();

            //-----------------------------------------------------------------
            ApplicationUser user;
            using (var rdr = new StringReader(text))
            {
                var serializer = new XmlSerializer(typeof(ApplicationUser));
                user = (ApplicationUser)serializer.Deserialize(rdr);
            }
            Console.WriteLine("Name: {0}, count: {1}", user.UserName, user.Quests.Count);
            Console.ReadKey();
            
            //-----------------------------------------------------------------
            using (var fs = new FileStream("user.xml", FileMode.OpenOrCreate))
            {
                var serializer = new XmlSerializer(typeof(ApplicationUser));
                serializer.Serialize(fs, model);

                Console.WriteLine("Все ОК");
            }
            
            //---------------------------------------------------------------------
            user = null;
            using (var fs = new FileStream("persons.xml", FileMode.OpenOrCreate))
            {
                var serializer = new XmlSerializer(typeof(ApplicationUser));
                user = (ApplicationUser)serializer.Deserialize(fs);                
            }
            Console.WriteLine("Name: {0}, count: {1}", user.UserName, user.Quests.Count);
            Console.ReadKey();
        }
    }
}
