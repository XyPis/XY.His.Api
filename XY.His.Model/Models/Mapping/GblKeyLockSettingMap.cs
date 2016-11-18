using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class GblKeyLockSettingMap : EntityTypeConfiguration<GblKeyLockSetting>
    {
        public GblKeyLockSettingMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.KeyValue)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.WorkStationName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UserId)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LockIp)
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
            this.ToTable("GblKeyLockSetting");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.KeyTypeId).HasColumnName("KeyTypeId");
            this.Property(t => t.KeyValue).HasColumnName("KeyValue");
            this.Property(t => t.WorkStationName).HasColumnName("WorkStationName");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.LockIp).HasColumnName("LockIp");
            this.Property(t => t.LockTime).HasColumnName("LockTime");
            this.Property(t => t.SPID).HasColumnName("SPID");
            this.Property(t => t.LoginTime).HasColumnName("LoginTime");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
        }
    }
}
