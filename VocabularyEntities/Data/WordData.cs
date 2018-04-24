using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocabularyEntities.Entities;

namespace VocabularyEntities.Data
{
    class WordData : EntityDataLibrary<Word>
    {
        public override Word GetByPk(int WordId)
        {
            return base.GetByPk(WordId);
        }
    }
}
