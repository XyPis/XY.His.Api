using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CsCostClassMap : EntityTypeConfiguration<CsCostClass>
    {
        public CsCostClassMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .HasMaxLength(20);

            this.Property(t => t.SuppItemCode)
                .HasMaxLength(20);

            this.Property(t => t.LastLevel)
                .IsFixedLength()
                .HasMaxLength(1);

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

            // Table & Column Mappings
            this.ToTable("CsCostClass");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.SuppItemCode).HasColumnName("SuppItemCode");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.LastLevel).HasColumnName("LastLevel");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.WbCode).HasColumnName("WbCode");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
        }
    }
}
