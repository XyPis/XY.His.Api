using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class ElPatFormTestMap : EntityTypeConfiguration<ElPatFormTest>
    {
        public ElPatFormTestMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Result)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Unit)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.TextRange)
                .HasMaxLength(500);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("ElPatFormTest");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PatFormId).HasColumnName("PatFormId");
            this.Property(t => t.TestId).HasColumnName("TestId");
            this.Property(t => t.Result).HasColumnName("Result");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.LsRefFlag).HasColumnName("LsRefFlag");
            this.Property(t => t.LowValue).HasColumnName("LowValue");
            this.Property(t => t.HighValue).HasColumnName("HighValue");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.TextRange).HasColumnName("TextRange");
            this.Property(t => t.LabId).HasColumnName("LabId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.ElPatForm)
                .WithMany(t => t.ElPatFormTests)
                .HasForeignKey(d => d.PatFormId);

        }
    }
}
