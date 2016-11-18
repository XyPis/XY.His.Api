using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class GblAutoUpdateOldMap : EntityTypeConfiguration<GblAutoUpdateOld>
    {
        public GblAutoUpdateOldMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.PathName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.FileContent)
                .IsRequired();

            this.Property(t => t.UpLoadHostName)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.UpLoadIp)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.DownLoadHostNames)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.HospitalIds)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("GblAutoUpdateOld");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PathName).HasColumnName("PathName");
            this.Property(t => t.FileContent).HasColumnName("FileContent");
            this.Property(t => t.OldVersion).HasColumnName("OldVersion");
            this.Property(t => t.NewVersion).HasColumnName("NewVersion");
            this.Property(t => t.UpLoadHostName).HasColumnName("UpLoadHostName");
            this.Property(t => t.UpLoadIp).HasColumnName("UpLoadIp");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.DownLoadHostNames).HasColumnName("DownLoadHostNames");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.HospitalIds).HasColumnName("HospitalIds");
            this.Property(t => t.IsChoose).HasColumnName("IsChoose");
        }
    }
}
