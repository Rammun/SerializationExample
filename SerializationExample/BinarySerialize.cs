using SerializationExample.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializationExample
{
    public class BinarySerialize
    {
        public static void Do(ApplicationUser model)
        {
            //------------------------------------------------------------------------
            using (var fs = new FileStream("user.dat", FileMode.OpenOrCreate))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(fs, model);

                Console.WriteLine("Все ОК");
                Console.ReadKey();
            }

            //----------------------------------------------------------------------------
            using (FileStream fs = new FileStream("user.dat", FileMode.OpenOrCreate))
            {
                var formatter = new BinaryFormatter();
                var user = (ApplicationUser)formatter.Deserialize(fs);

                Console.WriteLine("Name: {0}, count: {1}", user.UserName, user.Quests.Count);
                Console.ReadKey();
            }
        }
    }
}
