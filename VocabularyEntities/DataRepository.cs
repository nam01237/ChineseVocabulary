using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocabularyEntities.Data;

namespace EntityDataLibrary
{
    class DataRepository
    {
        public static UserData Users { get; } = new UserData();
    }
}
