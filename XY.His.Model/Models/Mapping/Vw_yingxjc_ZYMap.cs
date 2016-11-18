using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_yingxjc_ZYMap : EntityTypeConfiguration<Vw_yingxjc_ZY>
    {
        public Vw_yingxjc_ZYMap()
        {
            // Primary Key
            this.HasKey(t => new { t.c_songjlb, t.c_songjksbh, t.c_songjysbh, t.c_bingrbh, t.c_zuyh, t.sfbzbh, t.mc, t.KSMC, t.sjfy, t.rq, t.hzdh });

            // Properties
            this.Property(t => t.c_songjlb)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.c_songjksbh)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.c_songjysbh)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.c_jiancysxm)
                .HasMaxLength(40);

            this.Property(t => t.c_bingrbh)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.c_zuyh)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.c_bingch)
                .HasMaxLength(10);

            this.Property(t => t.c_fangjh)
                .HasMaxLength(6);

            this.Property(t => t.sfbzbh)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.mc)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.KSMC)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.sjfy)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.hzdh)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("Vw_yingxjc_ZY");
            this.Property(t => t.c_songjlb).HasColumnName("c_songjlb");
            this.Property(t => t.c_songjksbh).HasColumnName("c_songjksbh");
            this.Property(t => t.c_songjysbh).HasColumnName("c_songjysbh");
            this.Property(t => t.c_jiancysxm).HasColumnName("c_jiancysxm");
            this.Property(t => t.c_bingrbh).HasColumnName("c_bingrbh");
            this.Property(t => t.c_zuyh).HasColumnName("c_zuyh");
            this.Property(t => t.c_bingch).HasColumnName("c_bingch");
            this.Property(t => t.c_fangjh).HasColumnName("c_fangjh");
            this.Property(t => t.sfbzbh).HasColumnName("sfbzbh");
            this.Property(t => t.mc).HasColumnName("mc");
            this.Property(t => t.KSMC).HasColumnName("KSMC");
            this.Property(t => t.sjfy).HasColumnName("sjfy");
            this.Property(t => t.rq).HasColumnName("rq");
            this.Property(t => t.hzdh).HasColumnName("hzdh");
        }
    }
}
