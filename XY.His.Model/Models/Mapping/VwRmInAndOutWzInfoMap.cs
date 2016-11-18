using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwRmInAndOutWzInfoMap : EntityTypeConfiguration<VwRmInAndOutWzInfo>
    {
        public VwRmInAndOutWzInfoMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.BillNo, t.RoomId, t.LocationName, t.OperTime, t.OperId, t.HouseId, t.Type, t.IsSign, t.LsActType, t.SignTime, t.pageNumber });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BillNo)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.RoomId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LocationName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.OperId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HouseId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.LsActType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.pageNumber)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VwRmInAndOutWzInfo");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BillNo).HasColumnName("BillNo");
            this.Property(t => t.RoomId).HasColumnName("RoomId");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.HouseId).HasColumnName("HouseId");
            this.Property(t => t.RetailTotle).HasColumnName("RetailTotle");
            this.Property(t => t.StockTotle).HasColumnName("StockTotle");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.IsSign).HasColumnName("IsSign");
            this.Property(t => t.LsActType).HasColumnName("LsActType");
            this.Property(t => t.SignTime).HasColumnName("SignTime");
            this.Property(t => t.pageNumber).HasColumnName("pageNumber");
        }
    }
}
