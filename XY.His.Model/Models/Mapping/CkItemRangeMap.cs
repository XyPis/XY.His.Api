using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CkItemRangeMap : EntityTypeConfiguration<CkItemRange>
    {
        public CkItemRangeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.PrintResult)
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

            this.Property(t => t.TextRange)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("CkItemRange");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.TestId).HasColumnName("TestId");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.AgeFrom).HasColumnName("AgeFrom");
            this.Property(t => t.AgeTo).HasColumnName("AgeTo");
            this.Property(t => t.LowValue).HasColumnName("LowValue");
            this.Property(t => t.HighValue).HasColumnName("HighValue");
            this.Property(t => t.PanicLow).HasColumnName("PanicLow");
            this.Property(t => t.PanicHigh).HasColumnName("PanicHigh");
            this.Property(t => t.PrintResult).HasColumnName("PrintResult");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.TextRange).HasColumnName("TextRange");
            this.Property(t => t.LsAgeUnit).HasColumnName("LsAgeUnit");
            this.Property(t => t.MachineId).HasColumnName("MachineId");

            // Relationships
            this.HasOptional(t => t.CKMachine)
                .WithMany(t => t.CkItemRanges)
                .HasForeignKey(d => d.MachineId);

        }
    }
}
