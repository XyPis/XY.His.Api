using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class HuStockReqMap : EntityTypeConfiguration<HuStockReq>
    {
        public HuStockReqMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.BillNo)
                .IsRequired()
                .HasMaxLength(14);

            this.Property(t => t.ApplyIdea)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ApplyHander)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("HuStockReq");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BillNo).HasColumnName("BillNo");
            this.Property(t => t.HouseId).HasColumnName("HouseId");
            this.Property(t => t.ApplyTime).HasColumnName("ApplyTime");
            this.Property(t => t.ValideTime).HasColumnName("ValideTime");
            this.Property(t => t.ApplyIdea).HasColumnName("ApplyIdea");
            this.Property(t => t.ApplyHander).HasColumnName("ApplyHander");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.CompId).HasColumnName("CompId");

            // Relationships
            this.HasOptional(t => t.BsCompany)
                .WithMany(t => t.HuStockReqs)
                .HasForeignKey(d => d.CompId);
            this.HasRequired(t => t.BsHouse)
                .WithMany(t => t.HuStockReqs)
                .HasForeignKey(d => d.HouseId);

        }
    }
}
