using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityDataLibrary;
using VocabularyEntities;
using VocabularyEntities.Data;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            EntityDataInitializer.ConnectionString = "name = VocabularyEntities";


                User user = new User { Id = "test3", PassWord = "123"};
            DataRepository.Users.Insert(user);
        }
    }
}
