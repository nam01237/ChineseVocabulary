using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyEntities
{
    class Program
    {
        static void Main(string[] args)
        {
            using (VocabularyEntities context = new VocabularyEntities())
            {
                var test = context.Words.
                            Where(x => x.WordId < 30).
                            Select(x => x.Gancheza);


                foreach (var item in test)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
