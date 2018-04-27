using System;
using System.Linq;
using EntityDataLibrary;

namespace VocabularyEntities.Data
{

    public class LastSelectData : EntityData<LastSelect>
    {
        public LastSelect GetLastSelect(int userKey, int grade)
        {
            using (VocabularyEntities context = new VocabularyEntities())
            {
                LastSelect lastSelect = context.LastSelects.FirstOrDefault(x => x.UserKey == userKey && x.Grade == grade);

                return lastSelect;
            }
        }

        public void SetLastSelect(int userKey, int grade, int wordId)
        {
            using (VocabularyEntities context = new VocabularyEntities())
            {
                LastSelect lastSelect = context.LastSelects.FirstOrDefault(x => x.UserKey == userKey && x.Grade == grade);

                if (lastSelect != null)
                {
                    lastSelect.WordId = wordId;
                }
                else
                {
                    lastSelect = new LastSelect();
                    lastSelect.UserKey = userKey;
                    lastSelect.Grade = grade;
                    lastSelect.WordId = wordId;

                    context.LastSelects.Add(lastSelect);
                }

                context.SaveChanges();
            }
        }
    }

}