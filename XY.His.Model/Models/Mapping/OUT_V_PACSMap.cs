using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class OUT_V_PACSMap : EntityTypeConfiguration<OUT_V_PACS>
    {
        public OUT_V_PACSMap()
        {
            // Primary Key
            this.HasKey(t => new { t.JYJCDH, t.KCSJ, t.HZLY, t.BLH, t.LSH, t.BRXM, t.BQ, t.BZ, t.Status, t.LXDZ, t.YBID, t.LXDZ2, t.ZTLX, t.TJH, t.ZYH });

            // Properties
            this.Property(t => t.JYJCDH)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.KCYS)
                .HasMaxLength(20);

            this.Property(t => t.KCKS)
                .HasMaxLength(50);

            this.Property(t => t.HZLY)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.BLH)
                .IsRequired()
                .HasMaxLength(19);

            this.Property(t => t.LSH)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BRXM)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.XB)
                .HasMaxLength(2);

            this.Property(t => t.BQ)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.CH)
                .HasMaxLength(10);

            this.Property(t => t.BRLB)
                .HasMaxLength(50);

            this.Property(t => t.YBLX)
                .HasMaxLength(6);

            this.Property(t => t.ZD)
                .HasMaxLength(255);

            this.Property(t => t.BZ)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.Status)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ZXKS)
                .HasMaxLength(30);

            this.Property(t => t.LXDZ)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.LXDH)
                .HasMaxLength(15);

            this.Property(t => t.YBID)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.LXDZ2)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ZTLX)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.TJH)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ZYH)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.BW)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OUT_V_PACS");
            this.Property(t => t.JYJCDH).HasColumnName("JYJCDH");
            this.Property(t => t.KCSJ).HasColumnName("KCSJ");
            this.Property(t => t.KCYS).HasColumnName("KCYS");
            this.Property(t => t.KCKS).HasColumnName("KCKS");
            this.Property(t => t.HZLY).HasColumnName("HZLY");
            this.Property(t => t.BLH).HasColumnName("BLH");
            this.Property(t => t.LSH).HasColumnName("LSH");
            this.Property(t => t.BRXM).HasColumnName("BRXM");
            this.Property(t => t.NL).HasColumnName("NL");
            this.Property(t => t.XB).HasColumnName("XB");
            this.Property(t => t.CSRQ).HasColumnName("CSRQ");
            this.Property(t => t.BQ).HasColumnName("BQ");
            this.Property(t => t.CH).HasColumnName("CH");
            this.Property(t => t.BRLB).HasColumnName("BRLB");
            this.Property(t => t.YBLX).HasColumnName("YBLX");
            this.Property(t => t.ZD).HasColumnName("ZD");
            this.Property(t => t.BZ).HasColumnName("BZ");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.ZXKS).HasColumnName("ZXKS");
            this.Property(t => t.LXDZ).HasColumnName("LXDZ");
            this.Property(t => t.LXDH).HasColumnName("LXDH");
            this.Property(t => t.YBID).HasColumnName("YBID");
            this.Property(t => t.LXDZ2).HasColumnName("LXDZ2");
            this.Property(t => t.ZTLX).HasColumnName("ZTLX");
            this.Property(t => t.TJH).HasColumnName("TJH");
            this.Property(t => t.ZYH).HasColumnName("ZYH");
            this.Property(t => t.BW).HasColumnName("BW");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
        }
    }
}
