using EntityDataLibrary;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyEntities.Data
{
    public class UserData : EntityData<User>
    {
        public User GetByPk(int userKey)
        {
            using (VocabularyEntities context = new VocabularyEntities())
            {
                return context.Users.FirstOrDefault(x => x.UserKey == userKey);
            }
        }
    }
}
