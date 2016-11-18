using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class OuDiagCallMap : EntityTypeConfiguration<OuDiagCall>
    {
        public OuDiagCallMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Memo)
                .HasMaxLength(100);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.PatName)
                .HasMaxLength(50);

            this.Property(t => t.ActType)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OuDiagCall");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.PatName).HasColumnName("PatName");
            this.Property(t => t.ActType).HasColumnName("ActType");
            this.Property(t => t.IsCall).HasColumnName("IsCall");

            // Relationships
            this.HasOptional(t => t.BsDoctor)
                .WithMany(t => t.OuDiagCalls)
                .HasForeignKey(d => d.DoctorId);
            this.HasRequired(t => t.OuHosInfo)
                .WithMany(t => t.OuDiagCalls)
                .HasForeignKey(d => d.MzRegId);

        }
    }
}
