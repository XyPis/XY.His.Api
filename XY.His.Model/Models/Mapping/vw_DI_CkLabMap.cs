using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class vw_DI_CkLabMap : EntityTypeConfiguration<vw_DI_CkLab>
    {
        public vw_DI_CkLabMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.标本号, t.送检单位, t.IllHistory, t.Diagnose, t.IsPriority, t.IsCancel, t.LsSource, t.检验人, t.检验类别 });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.标本号)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.住院号)
                .HasMaxLength(13);

            this.Property(t => t.卡号)
                .HasMaxLength(19);

            this.Property(t => t.病人姓名)
                .HasMaxLength(30);

            this.Property(t => t.性别)
                .HasMaxLength(4);

            this.Property(t => t.送检单位)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.IllHistory)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.科室)
                .HasMaxLength(30);

            this.Property(t => t.医生)
                .HasMaxLength(40);

            this.Property(t => t.Diagnose)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.LsSource)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.检验人)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.标本来源)
                .HasMaxLength(8);

            this.Property(t => t.检验类别)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.检验项目)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("vw_DI_CkLab");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.标本号).HasColumnName("标本号");
            this.Property(t => t.住院号).HasColumnName("住院号");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.卡号).HasColumnName("卡号");
            this.Property(t => t.病人姓名).HasColumnName("病人姓名");
            this.Property(t => t.性别).HasColumnName("性别");
            this.Property(t => t.年龄).HasColumnName("年龄");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.送检单位).HasColumnName("送检单位");
            this.Property(t => t.IllHistory).HasColumnName("IllHistory");
            this.Property(t => t.科室).HasColumnName("科室");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.医生).HasColumnName("医生");
            this.Property(t => t.Diagnose).HasColumnName("Diagnose");
            this.Property(t => t.IsPriority).HasColumnName("IsPriority");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");
            this.Property(t => t.阴性).HasColumnName("阴性");
            this.Property(t => t.SpecialityId).HasColumnName("SpecialityId");
            this.Property(t => t.LsSource).HasColumnName("LsSource");
            this.Property(t => t.报告时间).HasColumnName("报告时间");
            this.Property(t => t.检验人).HasColumnName("检验人");
            this.Property(t => t.标本来源).HasColumnName("标本来源");
            this.Property(t => t.检验类别).HasColumnName("检验类别");
            this.Property(t => t.检验项目).HasColumnName("检验项目");
            this.Property(t => t.TogetherNum).HasColumnName("TogetherNum");
        }
    }
}
