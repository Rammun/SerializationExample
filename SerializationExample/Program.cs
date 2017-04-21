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
    class Program
    {
        static void Main(string[] args)
        {
            var model = GetModel();

            XMLSerialize.Do(model);

            JsonSerialize.Do(model);

            BinarySerialize.Do(model);
        }

        public static ApplicationUser GetModel()
        {
            var quests = new List<Quest>()
            {
                new Quest
                {
                    Title = "Название1",
                    Date = DateTime.Now,
                    Active = true,
                    Rate = 100,
                    Stages = new List<Stage>()
                    {
                        new Stage{ Id = 1, Title = "Сцена первая", Point = 10, Body = "Описание1" },
                        new Stage{ Id = 2, Title = "Сцена вторая", Point = 20, Body = "Описание2" }
                    }
                },

                new Quest
                {
                    Title = "Название2",
                    Date = DateTime.Now,
                    Active = true,
                    Rate = 200,
                }
            };

            var user = new ApplicationUser
            {
                UserName = "Имя",
                Profile = new UserProfile
                {
                    Sex = true,
                    Birthday = DateTime.Now - new TimeSpan(10000, 0, 0, 0),
                    avatarUrl = @"http://questgame.ru"
                },
                Quests = quests
            };

            return user;
        }
    }
}
