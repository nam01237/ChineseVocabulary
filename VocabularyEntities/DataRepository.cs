using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocabularyEntities.Data;

namespace VocabularyEntities.Data
{
    public class DataRepository
    {
        public static UserData Users { get; } = new UserData();
        public static StagedWordData StagedWords { get; } = new StagedWordData();
        public static WordData Words { get; } = new WordData();
        public static HistoryData Histiries { get; } = new HistoryData();
        public static LastSelectData LastSelects { get; } = new LastSelectData();
    }
}
