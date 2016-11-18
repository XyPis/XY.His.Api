using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsLocationRoomWindowMap : EntityTypeConfiguration<BsLocationRoomWindow>
    {
        public BsLocationRoomWindowMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.RoomWindowName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.PrinterName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BsLocationRoomWindow");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.RoomWindowName).HasColumnName("RoomWindowName");
            this.Property(t => t.PrinterName).HasColumnName("PrinterName");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsLocation)
                .WithMany(t => t.BsLocationRoomWindows)
                .HasForeignKey(d => d.LocationId);

        }
    }
}
