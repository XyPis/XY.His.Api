using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_BingrzlMap : EntityTypeConfiguration<Vw_Bingrzl>
    {
        public Vw_BingrzlMap()
        {
            // Primary Key
            this.HasKey(t => new { t.c_bingrbh, t.c_xingm, t.xb, t.c_hunf, t.c_youzbm, t.c_jiasxm, t.c_jiatzz, t.jg, t.c_dianhhm, t.c_senfzhm });

            // Properties
            this.Property(t => t.mz)
                .HasMaxLength(50);

            this.Property(t => t.c_bingrbh)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.c_xingm)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.xb)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.c_hunf)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.c_youzbm)
                .IsRequired()
                .HasMaxLength(7);

            this.Property(t => t.c_jiasxm)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.c_jiatzz)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.jg)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.zy)
                .HasMaxLength(20);

            this.Property(t => t.c_dianhhm)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.c_senfzhm)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Vw_Bingrzl");
            this.Property(t => t.mz).HasColumnName("mz");
            this.Property(t => t.c_bingrbh).HasColumnName("c_bingrbh");
            this.Property(t => t.c_xingm).HasColumnName("c_xingm");
            this.Property(t => t.xb).HasColumnName("xb");
            this.Property(t => t.n_nianl).HasColumnName("n_nianl");
            this.Property(t => t.c_hunf).HasColumnName("c_hunf");
            this.Property(t => t.c_youzbm).HasColumnName("c_youzbm");
            this.Property(t => t.c_jiasxm).HasColumnName("c_jiasxm");
            this.Property(t => t.c_jiatzz).HasColumnName("c_jiatzz");
            this.Property(t => t.jg).HasColumnName("jg");
            this.Property(t => t.zy).HasColumnName("zy");
            this.Property(t => t.c_dianhhm).HasColumnName("c_dianhhm");
            this.Property(t => t.c_senfzhm).HasColumnName("c_senfzhm");
        }
    }
}
