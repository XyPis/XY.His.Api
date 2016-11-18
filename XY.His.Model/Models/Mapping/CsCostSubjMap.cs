using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CsCostSubjMap : EntityTypeConfiguration<CsCostSubj>
    {
        public CsCostSubjMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SuppItemCode)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.PyCode)
                .HasMaxLength(10);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.WbCode)
                .HasMaxLength(6);

            this.Property(t => t.ToLocIds)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CsCostSubj");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.SuppItemCode).HasColumnName("SuppItemCode");
            this.Property(t => t.LsTreatMed).HasColumnName("LsTreatMed");
            this.Property(t => t.IsLastLevel).HasColumnName("IsLastLevel");
            this.Property(t => t.CostSubjGrade).HasColumnName("CostSubjGrade");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IsFix).HasColumnName("IsFix");
            this.Property(t => t.LsType).HasColumnName("LsType");
            this.Property(t => t.ClassId).HasColumnName("ClassId");
            this.Property(t => t.WbCode).HasColumnName("WbCode");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.IsDerect).HasColumnName("IsDerect");
            this.Property(t => t.LsAppPara).HasColumnName("LsAppPara");
            this.Property(t => t.ToLocIds).HasColumnName("ToLocIds");

            // Relationships
            this.HasOptional(t => t.CsCostClass)
                .WithMany(t => t.CsCostSubjs)
                .HasForeignKey(d => d.ClassId);

        }
    }
}
