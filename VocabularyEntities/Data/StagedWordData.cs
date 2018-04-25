using EntityDataLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyEntities.Data
{
    public class StagedWordData : EntityData<StagedWord>
    {
        
        public StagedWord GetByWordId(int userKey, int wordId)
        {
            using (VocabularyEntities context = new VocabularyEntities())
            {
                StagedWord word = context.StagedWords
                                  .Where(x => x.WordId == wordId && x.UserKey == userKey)
                                  .FirstOrDefault();

                return word;
                                 
            }
        }

        public List<Word> GetByGrade(int userKey, int grade)
        {
            using (VocabularyEntities context = new VocabularyEntities())
            {
                var list = (from x in context.StagedWords
                            where x.UserKey == userKey && x.Word.Grade == grade
                            select new { x.Word, x.Tested }
                           ).ToList();

                return list.ConvertAll(x => new Word(x.Word, x.Tested));

            }
        }

    }
}
