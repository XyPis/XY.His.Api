using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsManufacturerMap : EntityTypeConfiguration<BsManufacturer>
    {
        public BsManufacturerMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.CODE)
                .HasMaxLength(8);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AreaCode)
                .HasMaxLength(20);

            this.Property(t => t.Address)
                .HasMaxLength(50);

            this.Property(t => t.WbCode)
                .HasMaxLength(20);

            this.Property(t => t.PyCode)
                .HasMaxLength(20);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BsManufacturer");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CODE).HasColumnName("CODE");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.LsKind).HasColumnName("LsKind");
            this.Property(t => t.AreaCode).HasColumnName("AreaCode");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.WbCode).HasColumnName("WbCode");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");
        }
    }
}
