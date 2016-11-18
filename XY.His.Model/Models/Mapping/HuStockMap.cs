using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class HuStockMap : EntityTypeConfiguration<HuStock>
    {
        public HuStockMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.BillNo)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.Memo)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("HuStock");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BillNo).HasColumnName("BillNo");
            this.Property(t => t.HouseId).HasColumnName("HouseId");
            this.Property(t => t.CompId).HasColumnName("CompId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.IsSign).HasColumnName("IsSign");
            this.Property(t => t.SignTime).HasColumnName("SignTime");
            this.Property(t => t.SignOperId).HasColumnName("SignOperId");
            this.Property(t => t.IsBack).HasColumnName("IsBack");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.BuyId).HasColumnName("BuyId");
            this.Property(t => t.BuyWayId).HasColumnName("BuyWayId");
            this.Property(t => t.Applicant).HasColumnName("Applicant");
            this.Property(t => t.Application).HasColumnName("Application");

            // Relationships
            this.HasRequired(t => t.BsCompany)
                .WithMany(t => t.HuStocks)
                .HasForeignKey(d => d.CompId);
            this.HasRequired(t => t.BsHouse)
                .WithMany(t => t.HuStocks)
                .HasForeignKey(d => d.HouseId);

        }
    }
}
