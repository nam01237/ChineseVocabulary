using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyEntities
{
    public partial class Word
    {
        public Word(Word word, int passedCount)
        {
            WordId = word.WordId;
            Gancheza = word.Gancheza;
            ByeongEum = word.ByeongEum;
            Meaning = word.Meaning;
            WordClass = word.WordClass;
            Grade = word.Grade;
            PassedCount = passedCount;
            
        }

        public int PassedCount { get; set; }
    }
}
