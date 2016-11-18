using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsDocRegTypeMap : EntityTypeConfiguration<BsDocRegType>
    {
        public BsDocRegTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.RoomNo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("BsDocRegType");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.RegTypeId).HasColumnName("RegTypeId");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.LimitNum).HasColumnName("LimitNum");
            this.Property(t => t.LastLimitDate).HasColumnName("LastLimitDate");
            this.Property(t => t.LastLimitNum).HasColumnName("LastLimitNum");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.WeekDay).HasColumnName("WeekDay");
            this.Property(t => t.TimeSpanId).HasColumnName("TimeSpanId");
            this.Property(t => t.RoomNo).HasColumnName("RoomNo");
            this.Property(t => t.Diagroomid).HasColumnName("Diagroomid");
        }
    }
}
