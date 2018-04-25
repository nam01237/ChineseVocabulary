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
        public Word GetNetxWord(int wordId, int grade)
        {
            using (VocabularyEntities context = new VocabularyEntities())
            {
                Word word = context.Words
                            .Where(x => x.Grade == grade && x.WordId != wordId)
                            .OrderBy(x => x.WordId)
                            .FirstOrDefault();

                return word;
                
            }
        }

    }
}
