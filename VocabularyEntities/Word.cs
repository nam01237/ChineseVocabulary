//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VocabularyEntities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Word
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Word()
        {
            this.Histories = new HashSet<History>();
            this.LastSelects = new HashSet<LastSelect>();
            this.StagedWords = new HashSet<StagedWord>();
        }
    
        public int WordId { get; set; }
        public string Gancheza { get; set; }
        public string ByeongEum { get; set; }
        public string WordClass { get; set; }
        public string Meaning { get; set; }
        public int Grade { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<History> Histories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LastSelect> LastSelects { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StagedWord> StagedWords { get; set; }
    }
}
