using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Domain.BS.Mapping
{
    public class BsPatTypeMap : EntityTypeConfiguration<BsPatType>
    {
        public BsPatTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.HeadNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.WbCode)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.PyCode)
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
            this.ToTable("BsPatType");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.LimitFee).HasColumnName("LimitFee");
            this.Property(t => t.LimitIn).HasColumnName("LimitIn");
            this.Property(t => t.ArrearFei).HasColumnName("ArrearFei");
            this.Property(t => t.DiscDiag).HasColumnName("DiscDiag");
            this.Property(t => t.DiscIn).HasColumnName("DiscIn");
            this.Property(t => t.HeadNo).HasColumnName("HeadNo");
            this.Property(t => t.TallyTypeId).HasColumnName("TallyTypeId");
            this.Property(t => t.ArrearAmount).HasColumnName("ArrearAmount");
            this.Property(t => t.LsGFPatType).HasColumnName("LsGFPatType");
            this.Property(t => t.WbCode).HasColumnName("WbCode");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");
            this.Property(t => t.TwoDiscIn1).HasColumnName("TwoDiscIn1");
            this.Property(t => t.TwoDiscIn2).HasColumnName("TwoDiscIn2");

            // Relationships
        }
    }
}
