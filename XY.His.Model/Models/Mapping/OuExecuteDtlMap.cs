using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class OuExecuteDtlMap : EntityTypeConfiguration<OuExecuteDtl>
    {
        public OuExecuteDtlMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OuExecuteDtl");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ExecuteId).HasColumnName("ExecuteId");
            this.Property(t => t.RecipeDtlId).HasColumnName("RecipeDtlId");
            this.Property(t => t.listNum).HasColumnName("listNum");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.Dosage).HasColumnName("Dosage");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.UsageId).HasColumnName("UsageId");
            this.Property(t => t.FrequencyId).HasColumnName("FrequencyId");
            this.Property(t => t.Days).HasColumnName("Days");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.UnitDiagId).HasColumnName("UnitDiagId");
            this.Property(t => t.IssueTime).HasColumnName("IssueTime");
            this.Property(t => t.BackTime).HasColumnName("BackTime");
            this.Property(t => t.IsExecuted).HasColumnName("IsExecuted");
            this.Property(t => t.ExecutedTime).HasColumnName("ExecutedTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");

            // Relationships
            this.HasRequired(t => t.BsFrequency)
                .WithMany(t => t.OuExecuteDtls)
                .HasForeignKey(d => d.FrequencyId);
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.OuExecuteDtls)
                .HasForeignKey(d => d.ItemId);
            this.HasRequired(t => t.BsUnit)
                .WithMany(t => t.OuExecuteDtls)
                .HasForeignKey(d => d.UnitId);
            this.HasRequired(t => t.BsUsage)
                .WithMany(t => t.OuExecuteDtls)
                .HasForeignKey(d => d.UsageId);
            this.HasRequired(t => t.OuExecute)
                .WithMany(t => t.OuExecuteDtls)
                .HasForeignKey(d => d.ExecuteId);

        }
    }
}
