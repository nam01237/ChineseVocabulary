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





    }
}
