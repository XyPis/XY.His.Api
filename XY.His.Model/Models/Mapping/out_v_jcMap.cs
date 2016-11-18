using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class out_v_jcMap : EntityTypeConfiguration<out_v_jc>
    {
        public out_v_jcMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BLH, t.LSH, t.HZLY, t.Status, t.BRXM, t.KCSJ, t.JCDH, t.JCNR, t.BZ, t.BQ, t.CYSJ });

            // Properties
            this.Property(t => t.BLH)
                .IsRequired()
                .HasMaxLength(19);

            this.Property(t => t.LSH)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HZLY)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ZXKS)
                .HasMaxLength(30);

            this.Property(t => t.Status)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.BRXM)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.XB)
                .HasMaxLength(2);

            this.Property(t => t.KCKS)
                .HasMaxLength(50);

            this.Property(t => t.KCYS)
                .HasMaxLength(20);

            this.Property(t => t.JCDH)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.JCMC)
                .HasMaxLength(50);

            this.Property(t => t.JCNR)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.BZ)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.BQ)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.CH)
                .HasMaxLength(10);

            this.Property(t => t.ZD)
                .HasMaxLength(255);

            this.Property(t => t.YBLX)
                .HasMaxLength(6);

            this.Property(t => t.BRLB)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("out_v_jc");
            this.Property(t => t.BLH).HasColumnName("BLH");
            this.Property(t => t.LSH).HasColumnName("LSH");
            this.Property(t => t.HZLY).HasColumnName("HZLY");
            this.Property(t => t.ZXKS).HasColumnName("ZXKS");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.BRXM).HasColumnName("BRXM");
            this.Property(t => t.XB).HasColumnName("XB");
            this.Property(t => t.CSRQ).HasColumnName("CSRQ");
            this.Property(t => t.NL).HasColumnName("NL");
            this.Property(t => t.KCKS).HasColumnName("KCKS");
            this.Property(t => t.KCYS).HasColumnName("KCYS");
            this.Property(t => t.KCSJ).HasColumnName("KCSJ");
            this.Property(t => t.JCDH).HasColumnName("JCDH");
            this.Property(t => t.JCMC).HasColumnName("JCMC");
            this.Property(t => t.JCNR).HasColumnName("JCNR");
            this.Property(t => t.BZ).HasColumnName("BZ");
            this.Property(t => t.BQ).HasColumnName("BQ");
            this.Property(t => t.CH).HasColumnName("CH");
            this.Property(t => t.ZD).HasColumnName("ZD");
            this.Property(t => t.CYSJ).HasColumnName("CYSJ");
            this.Property(t => t.YBLX).HasColumnName("YBLX");
            this.Property(t => t.BRLB).HasColumnName("BRLB");
        }
    }
}
