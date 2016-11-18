using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_yingxjc_MZMap : EntityTypeConfiguration<Vw_yingxjc_MZ>
    {
        public Vw_yingxjc_MZMap()
        {
            // Primary Key
            this.HasKey(t => new { t.c_bingrbh, t.c_songjlb, t.c_songjksbh, t.c_songjysbh, t.sfbzmh, t.sfbzbh, t.ksmc, t.mc, t.sjfy, t.rq, t.sjh });

            // Properties
            this.Property(t => t.c_bingrbh)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

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

            this.Property(t => t.sfbzmh)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.sfbzbh)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ksmc)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.mc)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.sjfy)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sjh)
                .IsRequired()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("Vw_yingxjc_MZ");
            this.Property(t => t.c_bingrbh).HasColumnName("c_bingrbh");
            this.Property(t => t.c_songjlb).HasColumnName("c_songjlb");
            this.Property(t => t.c_songjksbh).HasColumnName("c_songjksbh");
            this.Property(t => t.c_songjysbh).HasColumnName("c_songjysbh");
            this.Property(t => t.c_jiancysxm).HasColumnName("c_jiancysxm");
            this.Property(t => t.sfbzmh).HasColumnName("sfbzmh");
            this.Property(t => t.sfbzbh).HasColumnName("sfbzbh");
            this.Property(t => t.ksmc).HasColumnName("ksmc");
            this.Property(t => t.mc).HasColumnName("mc");
            this.Property(t => t.sjfy).HasColumnName("sjfy");
            this.Property(t => t.rq).HasColumnName("rq");
            this.Property(t => t.sjh).HasColumnName("sjh");
        }
    }
}
