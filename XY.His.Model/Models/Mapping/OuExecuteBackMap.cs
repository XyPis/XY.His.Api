using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class OuExecuteBackMap : EntityTypeConfiguration<OuExecuteBack>
    {
        public OuExecuteBackMap()
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
            this.ToTable("OuExecuteBack");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ExecuteId).HasColumnName("ExecuteId");
            this.Property(t => t.ExecuteDtlId).HasColumnName("ExecuteDtlId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.IsBack).HasColumnName("IsBack");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.KsBackBillId).HasColumnName("KsBackBillId");
            this.Property(t => t.BackTime).HasColumnName("BackTime");

            // Relationships
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.OuExecuteBacks)
                .HasForeignKey(d => d.OperId);
            this.HasRequired(t => t.OuExecute)
                .WithMany(t => t.OuExecuteBacks)
                .HasForeignKey(d => d.ExecuteId);
            this.HasRequired(t => t.OuExecuteDtl)
                .WithMany(t => t.OuExecuteBacks)
                .HasForeignKey(d => d.ExecuteDtlId);

        }
    }
}
