using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace WebApi.Models.Configurations
{
    public class KanjisFrConfiguration : IEntityTypeConfiguration<KanjisFr>
    {
        public void Configure(EntityTypeBuilder<KanjisFr> builder)
        {
            builder.ToTable("KanjisFR");

            builder.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("_id");

            builder.Property(e => e.KunFr)
                .HasMaxLength(50)
                .HasColumnName("kun_fr");

            builder.Property(e => e.OnFr)
                .HasMaxLength(50)
                .HasColumnName("on_fr");

            builder.Property(e => e.SKunFr)
                .HasMaxLength(50)
                .HasColumnName("s_kun_fr");

            builder.Property(e => e.SKunFr2)
                .HasMaxLength(50)
                .HasColumnName("s_kun_fr_2");

            builder.Property(e => e.SKunFr3)
                .HasMaxLength(50)
                .HasColumnName("s_kun_fr_3");

            builder.Property(e => e.SOnFr)
                .HasMaxLength(50)
                .HasColumnName("s_on_fr");

            builder.Property(e => e.SOnFr2)
                .HasMaxLength(50)
                .HasColumnName("s_on_fr_2");

            builder.HasOne(d => d.IdNavigation)
                .WithOne(p => p.KanjisFr)
                .HasForeignKey<KanjisFr>(d => d.Id)
                .HasConstraintName("fk_kanjisfr_kanjis");

            builder.HasData(
                new KanjisFr { 
                    Id = 1,
                    OnFr = "prélever",
                    KunFr = "prendre",
                    SKunFr = "",
                    SOnFr = "",
                    SKunFr2 = "",
                    SOnFr2 = "",
                    SKunFr3 = ""
                },
                new KanjisFr
                {
                    Id = 4,
                    OnFr = "léger",
                    KunFr = "léger",
                    SKunFr = "",
                    SOnFr = "",
                    SKunFr2 = "",
                    SOnFr2 = "",
                    SKunFr3 = ""
                },
                new KanjisFr
                {
                    Id = 34,
                    OnFr = "chien",
                    KunFr = "chien",
                    SKunFr = "",
                    SOnFr = "",
                    SKunFr2 = "",
                    SOnFr2 = "",
                    SKunFr3 = ""
                });
        }
    }
}
