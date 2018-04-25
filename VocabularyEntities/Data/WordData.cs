using EntityDataLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyEntities.Data
{
    public class WordData : EntityData<Word>
    {
        public Word GetNetxWord(Word currentWord, int userKey)
        {
            using (VocabularyEntities context = new VocabularyEntities())
            {
                int wordId = currentWord.WordId;
                int grade = currentWord.Grade;


                var stagedList = context.StagedWords
                                 .Where(x => x.Word.Grade == grade && x.UserKey == userKey)
                                 .Select(x => x.WordId)
                                 .ToList();
                                                                  

                var list = context.Words
                            .Where(x => x.Grade == grade && x.WordId != wordId)
                            .Where(x => !stagedList.Contains(x.WordId))
                            .ToList();
                            
                Word word = list
                            .OrderBy(x => x.WordId)
                            .FirstOrDefault();

                return word;
                
            }
        }

        public int GetGradeCount(int grade)
        {
            using (VocabularyEntities context = new VocabularyEntities())
            {
                return context.Words.Count(x => x.Grade == grade);
            }
        }

    }
}
