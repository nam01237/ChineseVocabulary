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
        public List<StagedWord> GetByGrade(int userKey, int grade)
        {
            using (VocabularyEntities context = new VocabularyEntities())
            {
                var list = context.StagedWords.
                            .Where(x  => x.UserKey == userKey && x.Word.Grade == grade)
                            .ToList();

                return list;

            }
        }
    }
}
