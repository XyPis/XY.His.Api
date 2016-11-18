using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwRmInAndOutInfoMap : EntityTypeConfiguration<VwRmInAndOutInfo>
    {
        public VwRmInAndOutInfoMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.BillNo, t.RoomId, t.OperTime, t.Operid, t.IsSign, t.LsActType });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BillNo)
                .IsRequired()
                .HasMaxLength(14);

            this.Property(t => t.RoomId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LocationName)
                .HasMaxLength(50);

            this.Property(t => t.Operid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Type)
                .HasMaxLength(59);

            this.Property(t => t.LsActType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VwRmInAndOutInfo");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BillNo).HasColumnName("BillNo");
            this.Property(t => t.RoomId).HasColumnName("RoomId");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.Operid).HasColumnName("Operid");
            this.Property(t => t.RetailTotle).HasColumnName("RetailTotle");
            this.Property(t => t.StockTotle).HasColumnName("StockTotle");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.IsSign).HasColumnName("IsSign");
            this.Property(t => t.LsActType).HasColumnName("LsActType");
            this.Property(t => t.SignTime).HasColumnName("SignTime");
            this.Property(t => t.PageNumber).HasColumnName("PageNumber");
        }
    }
}
