using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace WebApi.Models.Configurations
{
    public class WordsFrConfiguration : IEntityTypeConfiguration<WordsFr>
    {
        public void Configure(EntityTypeBuilder<WordsFr> builder)
        {
            builder.ToTable("WordsFR");

            builder.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("_id");

            builder.Property(e => e.BlueWord)
                .HasMaxLength(50)
                .HasColumnName("blue_word");

            builder.Property(e => e.FrDefinition)
                .HasMaxLength(50)
                .HasColumnName("fr_definition");

            builder.Property(e => e.FrExplication)
                .HasMaxLength(50)
                .HasColumnName("fr_explication");

            builder.Property(e => e.French)
                .HasMaxLength(50)
                .HasColumnName("french");

            builder.HasOne(d => d.IdNavigation)
                .WithOne(p => p.WordsFr)
                .HasForeignKey<WordsFr>(d => d.Id)
                .HasConstraintName("fk_wordsfr_word");

            builder.HasData(
                new WordsFr
                {
                    Id =1,
                    French = "climatiseur",
                    FrExplication = "air conditionné",
                    FrDefinition = "Le climatiseur est en panne.",
                    BlueWord = "",
                },
                new WordsFr
                {
                    Id = 6,
                    French = "léger",
                    FrExplication = "",
                    FrDefinition = "Cette valise est légère.",
                    BlueWord = "légère",
                },
                 new WordsFr
                 {
                     Id = 36,
                     French = "chien",
                     FrExplication = "",
                     FrDefinition = "Un chien aboye dans la rue.",
                     BlueWord = "",
                 });
        }
    }
}
