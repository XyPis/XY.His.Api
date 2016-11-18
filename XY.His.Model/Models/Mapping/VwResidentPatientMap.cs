using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwResidentPatientMap : EntityTypeConfiguration<VwResidentPatient>
    {
        public VwResidentPatientMap()
        {
            // Primary Key
            this.HasKey(t => new { t.档案号, t.姓名, t.性别, t.地址, t.电话, t.医疗证, t.身份证, t.登记时间, t.档案ID });

            // Properties
            this.Property(t => t.档案号)
                .IsRequired()
                .HasMaxLength(19);

            this.Property(t => t.姓名)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.性别)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.村_居委)
                .HasMaxLength(50);

            this.Property(t => t.镇_街道)
                .HasMaxLength(50);

            this.Property(t => t.街_巷)
                .HasMaxLength(50);

            this.Property(t => t.户主)
                .HasMaxLength(30);

            this.Property(t => t.地址)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.电话)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.医疗证)
                .IsRequired()
                .HasMaxLength(18);

            this.Property(t => t.身份证)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.职业)
                .HasMaxLength(50);

            this.Property(t => t.病人类别)
                .HasMaxLength(50);

            this.Property(t => t.学历)
                .HasMaxLength(50);

            this.Property(t => t.登记人)
                .HasMaxLength(30);

            this.Property(t => t.档案类别)
                .HasMaxLength(50);

            this.Property(t => t.档案ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VwResidentPatient");
            this.Property(t => t.档案号).HasColumnName("档案号");
            this.Property(t => t.姓名).HasColumnName("姓名");
            this.Property(t => t.性别).HasColumnName("性别");
            this.Property(t => t.出生日期).HasColumnName("出生日期");
            this.Property(t => t.年龄).HasColumnName("年龄");
            this.Property(t => t.村_居委).HasColumnName("村/居委");
            this.Property(t => t.镇_街道).HasColumnName("镇/街道");
            this.Property(t => t.街_巷).HasColumnName("街/巷");
            this.Property(t => t.户主).HasColumnName("户主");
            this.Property(t => t.地址).HasColumnName("地址");
            this.Property(t => t.电话).HasColumnName("电话");
            this.Property(t => t.医疗证).HasColumnName("医疗证");
            this.Property(t => t.身份证).HasColumnName("身份证");
            this.Property(t => t.职业).HasColumnName("职业");
            this.Property(t => t.病人类别).HasColumnName("病人类别");
            this.Property(t => t.公费).HasColumnName("公费");
            this.Property(t => t.医保).HasColumnName("医保");
            this.Property(t => t.学历).HasColumnName("学历");
            this.Property(t => t.登记时间).HasColumnName("登记时间");
            this.Property(t => t.登记人).HasColumnName("登记人");
            this.Property(t => t.档案类别).HasColumnName("档案类别");
            this.Property(t => t.档案ID).HasColumnName("档案ID");
        }
    }
}
