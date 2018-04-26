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

        public int IncreasePassedCount(int userKey, int wordId)
        {
            using (VocabularyEntities context = new VocabularyEntities())
            {
                StagedWord stagedWord = context.StagedWords.FirstOrDefault(x => x.UserKey == userKey && x.WordId == wordId);
                stagedWord.PassedCount++;

                context.SaveChanges();

                return stagedWord.PassedCount;

            }
        }

        public void DeleteWordByGrade(int userKey, int grade)
        {
            using (VocabularyEntities context = new VocabularyEntities())
            {
                List<StagedWord> list = (from x in context.StagedWords
                                        where x.UserKey == userKey && x.Word.Grade == grade
                                        select x).ToList();

                context.StagedWords.RemoveRange(list);

                context.SaveChanges();
            }
        }


    }
}
