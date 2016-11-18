using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_OuExecuteDtl_BMap : EntityTypeConfiguration<Vw_OuExecuteDtl_B>
    {
        public Vw_OuExecuteDtl_BMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OperDate, t.ID, t.ExecuteId, t.listNum, t.ItemId, t.Dosage, t.UnitId, t.UsageId, t.FrequencyId, t.Days });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ExecuteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.listNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Dosage)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UsageId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FrequencyId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Days)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Vw_OuExecuteDtl_B");
            this.Property(t => t.OperDate).HasColumnName("OperDate");
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
        }
    }
}
