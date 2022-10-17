using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace WebApi.Models.Configurations
{
    public class FormVerbConfiguration : IEntityTypeConfiguration<FormVerb>
    {
        public void Configure(EntityTypeBuilder<FormVerb> builder)
        {
            
            builder.ToTable("FormVerb");

            builder.Property(e => e.Id).HasColumnName("_id");

            builder.Property(e => e.Causative)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("causative");

            builder.Property(e => e.CausativeHi)
                .HasMaxLength(50)
                .HasColumnName("causative_hi");

            builder.Property(e => e.Conditionnel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("conditionnel");

            builder.Property(e => e.ConditionnelHi)
                .HasMaxLength(50)
                .HasColumnName("conditionnel_hi");

            builder.Property(e => e.ConditionnelPa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("conditionnel_pa");

            builder.Property(e => e.ConditionnelPaHi)
                .HasMaxLength(50)
                .HasColumnName("conditionnel_pa_hi");

            builder.Property(e => e.Conjectural)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("conjectural");

            builder.Property(e => e.ConjecturalFor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("conjectural_for");

            builder.Property(e => e.ConjecturalForHi)
                .HasMaxLength(50)
                .HasColumnName("conjectural_for_hi");

            builder.Property(e => e.ConjecturalHi)
                .HasMaxLength(50)
                .HasColumnName("conjectural_hi");

            builder.Property(e => e.Dan)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("dan");

            builder.Property(e => e.ForNPa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("for_n_pa");

            builder.Property(e => e.ForNPaHi)
                .HasMaxLength(50)
                .HasColumnName("for_n_pa_hi");

            builder.Property(e => e.ForNPr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("for_n_pr");

            builder.Property(e => e.ForNPrHi)
                .HasMaxLength(50)
                .HasColumnName("for_n_pr_hi");

            builder.Property(e => e.ForPa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("for_pa");

            builder.Property(e => e.ForPaHi)
                .HasMaxLength(50)
                .HasColumnName("for_pa_hi");

            builder.Property(e => e.ForPassif)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("for_passif");

            builder.Property(e => e.ForPassifHi)
                .HasMaxLength(50)
                .HasColumnName("for_passif_hi");

            builder.Property(e => e.ForPotentiel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("for_potentiel");

            builder.Property(e => e.ForPotentielHi)
                .HasMaxLength(50)
                .HasColumnName("for_potentiel_hi");

            builder.Property(e => e.ForPr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("for_pr");

            builder.Property(e => e.ForPrHi)
                .HasMaxLength(50)
                .HasColumnName("for_pr_hi");

            builder.Property(e => e.ForToo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("for_too");

            builder.Property(e => e.ForTooHi)
                .HasMaxLength(50)
                .HasColumnName("for_too_hi");

            builder.Property(e => e.ForTooPa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("for_too_pa");

            builder.Property(e => e.ForTooPaHi)
                .HasMaxLength(50)
                .HasColumnName("for_too_pa_hi");

            builder.Property(e => e.Imperative)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("imperative");

            builder.Property(e => e.ImperativeHi)
                .HasMaxLength(50)
                .HasColumnName("imperative_hi");

            builder.Property(e => e.NPa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("n_pa");

            builder.Property(e => e.NPaHi)
                .HasMaxLength(50)
                .HasColumnName("n_pa_hi");

            builder.Property(e => e.NPr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("n_pr");

            builder.Property(e => e.NPrHi)
                .HasMaxLength(50)
                .HasColumnName("n_pr_hi");

            builder.Property(e => e.NTe)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("n_te");

            builder.Property(e => e.NTeHi)
                .HasMaxLength(50)
                .HasColumnName("n_te_hi");

            builder.Property(e => e.Obligation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("obligation");

            builder.Property(e => e.ObligationHi)
                .HasMaxLength(50)
                .HasColumnName("obligation_hi");

            builder.Property(e => e.Pa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pa");

            builder.Property(e => e.PaHi)
                .HasMaxLength(50)
                .HasColumnName("pa_hi");

            builder.Property(e => e.Passif)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("passif");

            builder.Property(e => e.PassifHi)
                .HasMaxLength(50)
                .HasColumnName("passif_hi");

            builder.Property(e => e.Potentiel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("potentiel");

            builder.Property(e => e.PotentielHi)
                .HasMaxLength(50)
                .HasColumnName("potentiel_hi");

            builder.Property(e => e.Stem)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("stem");

            builder.Property(e => e.StemHi)
                .HasMaxLength(50)
                .HasColumnName("stem_hi");

            builder.Property(e => e.Te)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("te");

            builder.Property(e => e.TeHi)
                .HasMaxLength(50)
                .HasColumnName("te_hi");

            builder.Property(e => e.Volutive)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("volutive");

            builder.Property(e => e.VolutiveHi)
                .HasMaxLength(50)
                .HasColumnName("volutive_hi");

            builder.HasData(
                new FormVerb
                {
                    Id = 13,
                    ForPr = "ikimasu",
                    ForPrHi = "いきます",
                    ForPa = "ikimashita",
                    ForPaHi = "いきました",
                    ForNPr = "ikimasen",
                    ForNPrHi = "いきません",
                    ForNPa = "ikimasendeshita",
                    ForNPaHi = "いきませんでした",
                    Pa = "itta",
                    PaHi = "いった",
                    NPr = "ikanai",
                    NPrHi = "いかない",
                    NPa = "ikanakatta",
                    NPaHi = "いかなかった",
                    Te = "itte",
                    TeHi = "いって",
                    NTe = "ikanakute",
                    NTeHi = "いかなくて",
                    ForPotentiel = "ikemasu",
                    ForPotentielHi = "いけます",
                    Potentiel = "ikeru",
                    PotentielHi = "いける",
                    ConjecturalFor = "ikimashou",
                    ConjecturalForHi = "いきましょう",
                    Conjectural = "ikou",
                    ConjecturalHi = "いこう",
                    Imperative = "ike",
                    ImperativeHi = "いけ",
                    Causative = "ikaseru",
                    CausativeHi = "いかせる",
                    Volutive = "ikitai",
                    VolutiveHi = "いきたい",
                    Conditionnel = "ikeba",
                    ConditionnelHi = "いけば",
                    ConditionnelPa = "ittara",
                    ConditionnelPaHi = "いったら",
                    Obligation = "ikanakerebanarimasen",
                    ObligationHi = "いかなけらばりません",
                    ForToo = "ikisugimasu",
                    ForTooHi = "いきすぎます",
                    ForTooPa = "ikisugimashita",
                    ForTooPaHi = "いきすぎました",
                    Stem = "iku",
                    StemHi = "いく",
                    Dan ="godan",
                    ForPassif = "ikaremasu",
                    ForPassifHi = "かれます",
                    Passif = "ikareru",
                    PassifHi = "いかれる",
                });
        }
    }
}
