using EntityDataLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyEntities.Data
{
    public class StagedData : EntityData<StagedWord>
    {
        public List<Word> GetByGrade(int userKey, int grade)
        {
            using (VocabularyEntities context = new VocabularyEntities())
            {
                var list = (from x in context.StagedWords
                            where x.UserKey == userKey && x.Word.Grade == grade
                            select x.Word
                           ).ToList();


                            //.Where(x  => x.UserKey == userKey && x.Word.Grade == grade)
                            //.ToList();

                return list;

            }
        }
    }
}
