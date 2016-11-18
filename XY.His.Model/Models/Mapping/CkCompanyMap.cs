using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CkCompanyMap : EntityTypeConfiguration<CkCompany>
    {
        public CkCompanyMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Phone)
                .HasMaxLength(15);

            this.Property(t => t.Fax)
                .HasMaxLength(15);

            this.Property(t => t.Address)
                .HasMaxLength(50);

            this.Property(t => t.PostCode)
                .HasMaxLength(7);

            this.Property(t => t.PayWayId)
                .HasMaxLength(3);

            this.Property(t => t.ResponMan)
                .HasMaxLength(15);

            this.Property(t => t.PyCode)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.WbCode)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("CkCompany");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.Fax).HasColumnName("Fax");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.PostCode).HasColumnName("PostCode");
            this.Property(t => t.PayWayId).HasColumnName("PayWayId");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.ResponMan).HasColumnName("ResponMan");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.WbCode).HasColumnName("WbCode");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");
        }
    }
}
