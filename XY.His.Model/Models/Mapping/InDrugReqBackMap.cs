using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class InDrugReqBackMap : EntityTypeConfiguration<InDrugReqBack>
    {
        public InDrugReqBackMap()
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
            this.ToTable("InDrugReqBack");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ReqDtlId).HasColumnName("ReqDtlId");
            this.Property(t => t.ListNum).HasColumnName("ListNum");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.IsBack).HasColumnName("IsBack");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.BackTime).HasColumnName("BackTime");
            this.Property(t => t.AdviceId).HasColumnName("AdviceId");
            this.Property(t => t.LsMarkType).HasColumnName("LsMarkType");
            this.Property(t => t.IsPrint).HasColumnName("IsPrint");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.RequestId).HasColumnName("RequestId");

            // Relationships
            this.HasRequired(t => t.BsUnit)
                .WithMany(t => t.InDrugReqBacks)
                .HasForeignKey(d => d.UnitId);

        }
    }
}
