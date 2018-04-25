using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyEntities
{
    public partial class Word
    {
        public Word(Word word, bool tested)
        {
            WordId = word.WordId;
            Gancheza = word.Gancheza;
            ByeongEum = word.ByeongEum;
            Meaning = word.Meaning;
            WordClass = word.WordClass;
            Grade = word.Grade;
            Tested = tested;
            
        }

        public bool Tested { get; set; }
    }
}
