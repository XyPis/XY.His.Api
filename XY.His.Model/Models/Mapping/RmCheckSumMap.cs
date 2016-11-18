using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class RmCheckSumMap : EntityTypeConfiguration<RmCheckSum>
    {
        public RmCheckSumMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.SumFor)
                .IsRequired()
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
            this.ToTable("RmCheckSum");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CheckId).HasColumnName("CheckId");
            this.Property(t => t.SumFor).HasColumnName("SumFor");
            this.Property(t => t.ApplyIn).HasColumnName("ApplyIn");
            this.Property(t => t.MzBackIn).HasColumnName("MzBackIn");
            this.Property(t => t.ZyBackIn).HasColumnName("ZyBackIn");
            this.Property(t => t.PyIn).HasColumnName("PyIn");
            this.Property(t => t.MoveIn).HasColumnName("MoveIn");
            this.Property(t => t.OtherIn).HasColumnName("OtherIn");
            this.Property(t => t.MoveOut).HasColumnName("MoveOut");
            this.Property(t => t.MzOut).HasColumnName("MzOut");
            this.Property(t => t.ZyOut).HasColumnName("ZyOut");
            this.Property(t => t.PkOut).HasColumnName("PkOut");
            this.Property(t => t.LoseOut).HasColumnName("LoseOut");
            this.Property(t => t.BackOut).HasColumnName("BackOut");
            this.Property(t => t.OtherOut).HasColumnName("OtherOut");
            this.Property(t => t.AdjustAmouUp).HasColumnName("AdjustAmouUp");
            this.Property(t => t.AdjustAmouDn).HasColumnName("AdjustAmouDn");
            this.Property(t => t.CheckAmou).HasColumnName("CheckAmou");
            this.Property(t => t.BalanceAmou).HasColumnName("BalanceAmou");
            this.Property(t => t.RecipeOut).HasColumnName("RecipeOut");
            this.Property(t => t.KsBackIn).HasColumnName("KsBackIn");
            this.Property(t => t.KsOut).HasColumnName("KsOut");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.RmCheck)
                .WithMany(t => t.RmCheckSums)
                .HasForeignKey(d => d.CheckId);

        }
    }
}
