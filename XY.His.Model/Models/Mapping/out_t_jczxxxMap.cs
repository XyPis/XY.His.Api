using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class out_t_jczxxxMap : EntityTypeConfiguration<out_t_jczxxx>
    {
        public out_t_jczxxxMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.JYJCDH)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.SUID)
                .HasMaxLength(400);

            this.Property(t => t.BW)
                .HasMaxLength(60);

            this.Property(t => t.ZDJG)
                .HasMaxLength(1000);

            this.Property(t => t.REPORTID)
                .HasMaxLength(40);

            this.Property(t => t.BGR)
                .HasMaxLength(10);

            this.Property(t => t.HZLY)
                .HasMaxLength(4);

            this.Property(t => t.YYSJ)
                .HasMaxLength(200);

            this.Property(t => t.JGBG)
                .HasMaxLength(4000);

            this.Property(t => t.HostName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("out_t_jczxxx");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.EVENTID).HasColumnName("EVENTID");
            this.Property(t => t.JYJCDH).HasColumnName("JYJCDH");
            this.Property(t => t.ZXZT).HasColumnName("ZXZT");
            this.Property(t => t.SUID).HasColumnName("SUID");
            this.Property(t => t.BW).HasColumnName("BW");
            this.Property(t => t.ZDJG).HasColumnName("ZDJG");
            this.Property(t => t.REPORTID).HasColumnName("REPORTID");
            this.Property(t => t.BGSJ).HasColumnName("BGSJ");
            this.Property(t => t.BGR).HasColumnName("BGR");
            this.Property(t => t.HZLY).HasColumnName("HZLY");
            this.Property(t => t.YYSJ).HasColumnName("YYSJ");
            this.Property(t => t.JGBG).HasColumnName("JGBG");
            this.Property(t => t.RowTime).HasColumnName("RowTime");
            this.Property(t => t.HostName).HasColumnName("HostName");
        }
    }
}
