using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace WebApi.Models.Configurations
{
    public class WordConfiguration : IEntityTypeConfiguration<Word>
    {
        public void Configure(EntityTypeBuilder<Word> builder)
        {
            builder.Property(e => e.Id).HasColumnName("_id");

            builder.Property(e => e.Filters)
                .HasMaxLength(50)
                .HasColumnName("filters");

            builder.Property(e => e.JpDefinition)
                .HasMaxLength(50)
                .HasColumnName("jp_definition");

            builder.Property(e => e.JpDefinitionRo)
                .HasMaxLength(50)
                .HasColumnName("jp_definition_ro");

            builder.Property(e => e.JpHiragana)
                .HasMaxLength(50)
                .HasColumnName("jp_hiragana");

            builder.Property(e => e.JpKanji)
                .HasMaxLength(50)
                .HasColumnName("jp_kanji");

            builder.Property(e => e.JpKatakana)
                .HasMaxLength(50)
                .HasColumnName("jp_katakana");

            builder.Property(e => e.JpRomanji)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("jp_romanji");

            builder.Property(e => e.NbHi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nb_hi");

            builder.Property(e => e.NbRo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nb_ro");

            builder.Property(e => e.States)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("states");

            builder.Property(e => e.Tense)
                .HasMaxLength(50)
                .HasColumnName("tense");

            builder.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("type");

            builder.HasData(
                new Word
                {
                    Id = 1,
                    JpRomanji = "eakon",
                    JpHiragana = "",
                    JpKatakana = "エアコン",
                    JpKanji = "",
                    NbRo = "",
                    NbHi = "",
                    Type = "noun",
                    States = "",
                    Filters = "",
                    JpDefinition = "エアコンが故障している",
                    JpDefinitionRo = "eakon ha koshou shiteiru.",
                    Tense = ""

                },
                new Word
                {
                    Id = 3,
                    JpRomanji = "toru",
                    JpHiragana = "とる",
                    JpKatakana = "",
                    JpKanji = "撮る",
                    NbRo = "2",
                    NbHi = "1",
                    Type = "godan",
                    States = "",
                    Filters = "",
                    JpDefinition = "写真に撮ります。",
                    JpDefinitionRo = "shashin ni torimasu.",
                    Tense = "for_pr"

                },
                new Word
                {
                    Id = 6,
                    JpRomanji = "karui",
                    JpHiragana = "かるい",
                    JpKatakana = "",
                    JpKanji = "軽い",
                    NbRo = "4",
                    NbHi = "2",
                    Type = "i",
                    States = "",
                    Filters = "",
                    JpDefinition = "この旅行鞄は軽いです。",
                    JpDefinitionRo = "kono ryokoukaban ha karuidesu.",
                    Tense = "for_pr"
                },
                new Word
                {
                    Id = 36,
                    JpRomanji = "inu",
                    JpHiragana = "いぬ",
                    JpKatakana = "",
                    JpKanji = "犬",
                    NbRo = "3",
                    NbHi = "2",
                    Type = "noun",
                    States = "",
                    Filters = "",
                    JpDefinition = "道で犬が吠えています。",
                    JpDefinitionRo = "michi de inu ga hoeteimasu.",
                    Tense = ""
                });
        }
    }
}
