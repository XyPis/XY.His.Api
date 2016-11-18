using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class NrPregnancyDtlMap : EntityTypeConfiguration<NrPregnancyDtl>
    {
        public NrPregnancyDtlMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Strength)
                .HasMaxLength(50);

            this.Property(t => t.LongTimes)
                .HasMaxLength(50);

            this.Property(t => t.Sometimes)
                .HasMaxLength(50);

            this.Property(t => t.UterusHigh)
                .HasMaxLength(50);

            this.Property(t => t.Post)
                .HasMaxLength(50);

            this.Property(t => t.Speed)
                .HasMaxLength(50);

            this.Property(t => t.Place)
                .HasMaxLength(50);

            this.Property(t => t.FirstHigh)
                .HasMaxLength(50);

            this.Property(t => t.Lengh)
                .HasMaxLength(50);

            this.Property(t => t.Expand)
                .HasMaxLength(50);

            this.Property(t => t.Membrane)
                .HasMaxLength(50);

            this.Property(t => t.Anus)
                .HasMaxLength(50);

            this.Property(t => t.Vagina)
                .HasMaxLength(50);

            this.Property(t => t.Others)
                .HasMaxLength(50);

            this.Property(t => t.CheckMan)
                .HasMaxLength(50);

            this.Property(t => t.CenterTimes)
                .HasMaxLength(50);

            this.Property(t => t.LinkUp)
                .HasMaxLength(50);

            this.Property(t => t.Score)
                .HasMaxLength(50);

            this.Property(t => t.AmniFluid)
                .HasMaxLength(50);

            this.Property(t => t.VaginaBleed)
                .HasMaxLength(50);

            this.Property(t => t.MoveTimes)
                .HasMaxLength(50);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("NrPregnancyDtl");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PregnancyId).HasColumnName("PregnancyId");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.ExamBp).HasColumnName("ExamBp");
            this.Property(t => t.ExamBp2).HasColumnName("ExamBp2");
            this.Property(t => t.Strength).HasColumnName("Strength");
            this.Property(t => t.LongTimes).HasColumnName("LongTimes");
            this.Property(t => t.Sometimes).HasColumnName("Sometimes");
            this.Property(t => t.UterusHigh).HasColumnName("UterusHigh");
            this.Property(t => t.Post).HasColumnName("Post");
            this.Property(t => t.Speed).HasColumnName("Speed");
            this.Property(t => t.Place).HasColumnName("Place");
            this.Property(t => t.FirstHigh).HasColumnName("FirstHigh");
            this.Property(t => t.Lengh).HasColumnName("Lengh");
            this.Property(t => t.Expand).HasColumnName("Expand");
            this.Property(t => t.Membrane).HasColumnName("Membrane");
            this.Property(t => t.Anus).HasColumnName("Anus");
            this.Property(t => t.Vagina).HasColumnName("Vagina");
            this.Property(t => t.Others).HasColumnName("Others");
            this.Property(t => t.CheckMan).HasColumnName("CheckMan");
            this.Property(t => t.CenterTimes).HasColumnName("CenterTimes");
            this.Property(t => t.LinkUp).HasColumnName("LinkUp");
            this.Property(t => t.Score).HasColumnName("Score");
            this.Property(t => t.AmniFluid).HasColumnName("AmniFluid");
            this.Property(t => t.VaginaBleed).HasColumnName("VaginaBleed");
            this.Property(t => t.MoveTimes).HasColumnName("MoveTimes");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.NrPregnancy)
                .WithMany(t => t.NrPregnancyDtls)
                .HasForeignKey(d => d.PregnancyId);

        }
    }
}
