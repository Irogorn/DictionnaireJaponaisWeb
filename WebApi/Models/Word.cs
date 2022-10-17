using System;
using System.Collections.Generic;

namespace WebApi
{
    public partial class Word
    {
        public Word()
        {
            Commentaries = new HashSet<Commentary>();
        }

        public int Id { get; set; }
        public string JpRomanji { get; set; } = null!;
        public string JpHiragana { get; set; } = null!;
        public string JpKatakana { get; set; } = null!;
        public string JpKanji { get; set; } = null!;
        public string NbRo { get; set; } = null!;
        public string NbHi { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string States { get; set; } = null!;
        public string Filters { get; set; } = null!;
        public string JpDefinition { get; set; } = null!;
        public string JpDefinitionRo { get; set; } = null!;
        public string Tense { get; set; } = null!;

        public virtual WordsFr WordsFr { get; set; } = null!;
        public virtual ICollection<Commentary> Commentaries { get; set; }
    }
}
