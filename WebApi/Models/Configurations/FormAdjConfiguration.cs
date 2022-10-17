using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace WebApi.Models.Configurations
{
    public class FormAdjConfiguration : IEntityTypeConfiguration<FormAdj>
    {
        public void Configure(EntityTypeBuilder<FormAdj> builder)
        {
            builder.ToTable("FormAdj");

            builder.Property(e => e.Id).HasColumnName("_id");

            builder.Property(e => e.Conditionnel)
                    .HasMaxLength(50)
                    .HasColumnName("conditionnel");

            builder.Property(e => e.ConditionnelHi)
                    .HasMaxLength(50)
                    .HasColumnName("conditionnel_hi");

            builder.Property(e => e.ConditionnelPa)
                    .HasMaxLength(50)
                    .HasColumnName("conditionnel_pa");

            builder.Property(e => e.ConditionnelPaHi)
                    .HasMaxLength(50)
                    .HasColumnName("conditionnel_pa_hi");

            builder.Property(e => e.ForNPa)
                    .HasMaxLength(50)
                    .HasColumnName("for_n_pa");

            builder.Property(e => e.ForNPaHi)
                    .HasMaxLength(50)
                    .HasColumnName("for_n_pa_hi");

            builder.Property(e => e.ForNPr)
                    .HasMaxLength(50)
                    .HasColumnName("for_n_pr");

            builder.Property(e => e.ForNPrHi)
                    .HasMaxLength(50)
                    .HasColumnName("for_n_pr_hi");

            builder.Property(e => e.ForPa)
                    .HasMaxLength(50)
                    .HasColumnName("for_pa");

            builder.Property(e => e.ForPaHi)
                    .HasMaxLength(50)
                    .HasColumnName("for_pa_hi");

            builder.Property(e => e.ForPr)
                    .HasMaxLength(50)
                    .HasColumnName("for_pr");

            builder.Property(e => e.ForPrHi)
                    .HasMaxLength(50)
                    .HasColumnName("for_pr_hi");

            builder.Property(e => e.Intentionnelle)
                    .HasMaxLength(50)
                    .HasColumnName("intentionnelle");

            builder.Property(e => e.IntentionnelleHi)
                    .HasMaxLength(50)
                    .HasColumnName("intentionnelle_hi");

            builder.Property(e => e.NPa)
                    .HasMaxLength(50)
                    .HasColumnName("n_pa");

            builder.Property(e => e.NPaHi)
                    .HasMaxLength(50)
                    .HasColumnName("n_pa_hi");

            builder.Property(e => e.NPr)
                    .HasMaxLength(50)
                    .HasColumnName("n_pr");

            builder.Property(e => e.NPrHi)
                    .HasMaxLength(50)
                    .HasColumnName("n_pr_hi");

            builder.Property(e => e.NTe)
                    .HasMaxLength(50)
                    .HasColumnName("n_te");

            builder.Property(e => e.NTeHi)
                    .HasMaxLength(50)
                    .HasColumnName("n_te_hi");

            builder.Property(e => e.Pa)
                    .HasMaxLength(50)
                    .HasColumnName("pa");

            builder.Property(e => e.PaHi)
                    .HasMaxLength(50)
                    .HasColumnName("pa_hi");

            builder.Property(e => e.Te)
                    .HasMaxLength(50)
                    .HasColumnName("te");

            builder.Property(e => e.TeHi)
                    .HasMaxLength(50)
                    .HasColumnName("te_hi");

            builder.Property(e => e.Type)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("type");

            builder.HasData(
                new FormAdj
                {
                    Id = 1,
                    ForPr = "idesu",
                    ForPrHi = "いです",
                    ForPa = "kattadesu",
                    ForPaHi = "かったです",
                    ForNPr = "kunaidsesu",
                    ForNPrHi = "くないです",
                    ForNPa = "kunakattadesu",
                    ForNPaHi = "くなかったです",
                    Pa = "katta",
                    PaHi = "かった",
                    NPr = "kunai",
                    NPrHi = "くない",
                    NPa = "kunakatta",
                    NPaHi = "くなかった",
                    Te = "kute",
                    TeHi = "くて",
                    NTe = "kunakute",
                    NTeHi = "くなくて",
                    Intentionnelle = "idarou",
                    IntentionnelleHi = "いだろう",
                    Conditionnel = "kereba",
                    ConditionnelHi = "ければ",
                    ConditionnelPa = "kattara",
                    ConditionnelPaHi = "かったら",
                    Type = "i"
                });
        }
    }
}
