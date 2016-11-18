using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class HuOutMap : EntityTypeConfiguration<HuOut>
    {
        public HuOutMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.BillNo)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.OutMemo)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("HuOut");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BillNo).HasColumnName("BillNo");
            this.Property(t => t.HouseId).HasColumnName("HouseId");
            this.Property(t => t.RoomId).HasColumnName("RoomId");
            this.Property(t => t.ApplyId).HasColumnName("ApplyId");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OutMemo).HasColumnName("OutMemo");
            this.Property(t => t.YFSign).HasColumnName("YFSign");
            this.Property(t => t.YFOperId).HasColumnName("YFOperId");
            this.Property(t => t.YFOperTime).HasColumnName("YFOperTime");
            this.Property(t => t.IsSign).HasColumnName("IsSign");
            this.Property(t => t.SignTime).HasColumnName("SignTime");
            this.Property(t => t.SignOperId).HasColumnName("SignOperId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.ApperId).HasColumnName("ApperId");
            this.Property(t => t.OutWayId).HasColumnName("OutWayId");

            // Relationships
            this.HasRequired(t => t.BsHouse)
                .WithMany(t => t.HuOuts)
                .HasForeignKey(d => d.HouseId);
            this.HasRequired(t => t.BsRoom)
                .WithMany(t => t.HuOuts)
                .HasForeignKey(d => d.RoomId);
            this.HasOptional(t => t.RmAppDrug)
                .WithMany(t => t.HuOuts)
                .HasForeignKey(d => d.ApplyId);

        }
    }
}
