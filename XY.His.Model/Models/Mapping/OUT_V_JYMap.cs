using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class OUT_V_JYMap : EntityTypeConfiguration<OUT_V_JY>
    {
        public OUT_V_JYMap()
        {
            // Primary Key
            this.HasKey(t => new { t.KCSJ, t.HZLY, t.BLH, t.BRXM, t.BQ, t.ZD, t.LXDZ, t.LXDH, t.LXDZ2 });

            // Properties
            this.Property(t => t.JYJCDH)
                .HasMaxLength(30);

            this.Property(t => t.KCYS)
                .HasMaxLength(20);

            this.Property(t => t.KCKS)
                .HasMaxLength(30);

            this.Property(t => t.HZLY)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.BLH)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.LSH)
                .HasMaxLength(20);

            this.Property(t => t.BRXM)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.XB)
                .HasMaxLength(2);

            this.Property(t => t.NL)
                .HasMaxLength(40);

            this.Property(t => t.BQ)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.CH)
                .HasMaxLength(10);

            this.Property(t => t.BRLB)
                .HasMaxLength(50);

            this.Property(t => t.YBLB)
                .HasMaxLength(50);

            this.Property(t => t.ZD)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.BZ)
                .HasMaxLength(1000);

            this.Property(t => t.ZXKS)
                .HasMaxLength(30);

            this.Property(t => t.LXDZ)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.LXDH)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.YBID)
                .HasMaxLength(18);

            this.Property(t => t.LXDZ2)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.JYDM)
                .HasMaxLength(20);

            this.Property(t => t.JYMC)
                .HasMaxLength(50);

            this.Property(t => t.SJQK)
                .HasMaxLength(30);

            this.Property(t => t.ZTLX)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OUT_V_JY");
            this.Property(t => t.JYJCDH).HasColumnName("JYJCDH");
            this.Property(t => t.KCSJ).HasColumnName("KCSJ");
            this.Property(t => t.KCYS).HasColumnName("KCYS");
            this.Property(t => t.KCKS).HasColumnName("KCKS");
            this.Property(t => t.HZLY).HasColumnName("HZLY");
            this.Property(t => t.BLH).HasColumnName("BLH");
            this.Property(t => t.LSH).HasColumnName("LSH");
            this.Property(t => t.BRXM).HasColumnName("BRXM");
            this.Property(t => t.XB).HasColumnName("XB");
            this.Property(t => t.NL).HasColumnName("NL");
            this.Property(t => t.CSRQ).HasColumnName("CSRQ");
            this.Property(t => t.BQ).HasColumnName("BQ");
            this.Property(t => t.CH).HasColumnName("CH");
            this.Property(t => t.BRLB).HasColumnName("BRLB");
            this.Property(t => t.YBLB).HasColumnName("YBLB");
            this.Property(t => t.ZD).HasColumnName("ZD");
            this.Property(t => t.BZ).HasColumnName("BZ");
            this.Property(t => t.ZXKS).HasColumnName("ZXKS");
            this.Property(t => t.LXDZ).HasColumnName("LXDZ");
            this.Property(t => t.LXDH).HasColumnName("LXDH");
            this.Property(t => t.YBID).HasColumnName("YBID");
            this.Property(t => t.LXDZ2).HasColumnName("LXDZ2");
            this.Property(t => t.JYDM).HasColumnName("JYDM");
            this.Property(t => t.JYMC).HasColumnName("JYMC");
            this.Property(t => t.SJQK).HasColumnName("SJQK");
            this.Property(t => t.ZTLX).HasColumnName("ZTLX");
        }
    }
}
