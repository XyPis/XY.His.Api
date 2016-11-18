using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BKStoreLogMap : EntityTypeConfiguration<BKStoreLog>
    {
        public BKStoreLogMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.HappenTime, t.UserId, t.PatCardid, t.LsActType, t.BeforeMoney, t.HappenMoney, t.AfterMoney });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.UserId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PatCardid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BKRegNo)
                .HasMaxLength(50);

            this.Property(t => t.LsActType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BeforeMoney)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HappenMoney)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AfterMoney)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Memo)
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
            this.ToTable("BKStoreLog");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HappenTime).HasColumnName("HappenTime");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.PatCardid).HasColumnName("PatCardid");
            this.Property(t => t.BKRegNo).HasColumnName("BKRegNo");
            this.Property(t => t.LsActType).HasColumnName("LsActType");
            this.Property(t => t.BeforeMoney).HasColumnName("BeforeMoney");
            this.Property(t => t.HappenMoney).HasColumnName("HappenMoney");
            this.Property(t => t.AfterMoney).HasColumnName("AfterMoney");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
        }
    }
}
