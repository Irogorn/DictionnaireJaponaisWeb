using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace WebApi.Models.Configurations
{
    public class KanjiConfiguration : IEntityTypeConfiguration<Kanji>
    {
        public void Configure(EntityTypeBuilder<Kanji> builder)
        {
            builder.Property(e => e.Id).HasColumnName("_id");

            builder.Property(e => e.Jlpt).HasColumnName("jlpt");

            builder.Property(e => e.Kanji1)
                    .HasMaxLength(50)
                    .HasColumnName("kanji");

            builder.Property(e => e.Kun)
                    .HasMaxLength(50)
                    .HasColumnName("kun");

            builder.Property(e => e.KunRo)
                    .HasMaxLength(50)
                    .HasColumnName("kun_ro");

            builder.Property(e => e.NbStrokes)
                .HasColumnName("nb_strokes");

            builder.Property(e => e.On)
                    .HasMaxLength(50)
                    .HasColumnName("on");

            builder.Property(e => e.OnKa)
                    .HasMaxLength(50)
                    .HasColumnName("on_ka");

            builder.Property(e => e.OnRo)
                    .HasMaxLength(50)
                    .HasColumnName("on_ro");

            builder.Property(e => e.SKun)
                    .HasMaxLength(50)
                    .HasColumnName("s_kun");

            builder.Property(e => e.SKun2)
                .HasMaxLength(50)
                .HasColumnName("s_kun_2");

            builder.Property(e => e.SKun3)
                .HasMaxLength(50)
                .HasColumnName("s_kun_3");

            builder.Property(e => e.SKunRo)
                .HasMaxLength(50)
                .HasColumnName("s_kun_ro");

            builder.Property(e => e.SKunRo2)
                .HasMaxLength(50)
                .HasColumnName("s_kun_ro_2");

            builder.Property(e => e.SKunRo3)
                .HasMaxLength(50)
                .HasColumnName("s_kun_ro_3");

            builder.Property(e => e.SOn)
                .HasMaxLength(50)
                .HasColumnName("s_on");

            builder.Property(e => e.SOn2)
                .HasMaxLength(50)
                .HasColumnName("s_on_2");

            builder.Property(e => e.SOnKa)
                .HasMaxLength(50)
                .HasColumnName("s_on_ka");

            builder.Property(e => e.SOnKa2)
                .HasMaxLength(50)
                .HasColumnName("s_on_ka_2");

            builder.Property(e => e.SOnRo)
                .HasMaxLength(50)
                .HasColumnName("s_on_ro");

            builder.Property(e => e.SOnRo2)
                .HasMaxLength(50)
                .HasColumnName("s_on_ro_2");

            builder.HasData(
                new Kanji
                {
                    Id = 1,
                    Jlpt = 1,
                    Kanji1 = "撮",
                    NbStrokes = 15,
                    On = "さつ",
                    OnKa = "サツ",
                    OnRo = "satsu",
                    Kun = "と",
                    KunRo = "to",
                    SKun = "",
                    SKunRo ="",
                    SOn = "",
                    SOnKa = "",
                    SOnRo = "",
                    SKun2 ="",
                    SKunRo2 ="",
                    SOn2 = "",
                    SOnKa2 = "",
                    SOnRo2 = "",
                    SKun3 = "",
                    SKunRo3 = ""


                },
                new Kanji
                {
                    Id = 4,
                    Jlpt = 4,
                    Kanji1 = "軽",
                    NbStrokes = 12,
                    On = "けい",
                    OnKa = "ケイ",
                    OnRo = "kei",
                    Kun = "かる",
                    KunRo = "karu",
                    SKun = "",
                    SKunRo = "",
                    SOn = "",
                    SOnKa = "",
                    SOnRo = "",
                    SKun2 = "",
                    SKunRo2 = "",
                    SOn2 = "",
                    SOnKa2 = "",
                    SOnRo2 = "",
                    SKun3 = "",
                    SKunRo3 = ""
                },
                 new Kanji
                 {
                     Id = 34,
                     Jlpt = 4,
                     Kanji1 = "犬",
                     NbStrokes = 4,
                     On = "けん",
                     OnKa = "ケン",
                     OnRo = "ken",
                     Kun = "いぬ",
                     KunRo = "inu",
                     SKun = "",
                     SKunRo = "",
                     SOn = "",
                     SOnKa = "",
                     SOnRo = "",
                     SKun2 = "",
                     SKunRo2 = "",
                     SOn2 = "",
                     SOnKa2 = "",
                     SOnRo2 = "",
                     SKun3 = "",
                     SKunRo3 = ""
                 });
        }
    }
}
