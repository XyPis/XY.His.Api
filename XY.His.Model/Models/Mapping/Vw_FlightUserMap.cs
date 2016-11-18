using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_FlightUserMap : EntityTypeConfiguration<Vw_FlightUser>
    {
        public Vw_FlightUserMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Name, t.工作类别, t.职称, t.性别, t.出生日期, t.身份证, t.职务, t.联系方式, t.电子邮件, t.家庭住址, t.人员状态, t.入职时间, t.离职时间 });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.输入码)
                .HasMaxLength(4000);

            this.Property(t => t.工作类别)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.职称)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.性别)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.出生日期)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.身份证)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.职务)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.联系方式)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.电子邮件)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.家庭住址)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.人员状态)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.入职时间)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.离职时间)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("Vw_FlightUser");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.输入码).HasColumnName("输入码");
            this.Property(t => t.科室代码).HasColumnName("科室代码");
            this.Property(t => t.工作类别).HasColumnName("工作类别");
            this.Property(t => t.职称).HasColumnName("职称");
            this.Property(t => t.性别).HasColumnName("性别");
            this.Property(t => t.出生日期).HasColumnName("出生日期");
            this.Property(t => t.身份证).HasColumnName("身份证");
            this.Property(t => t.职务).HasColumnName("职务");
            this.Property(t => t.联系方式).HasColumnName("联系方式");
            this.Property(t => t.电子邮件).HasColumnName("电子邮件");
            this.Property(t => t.家庭住址).HasColumnName("家庭住址");
            this.Property(t => t.人员状态).HasColumnName("人员状态");
            this.Property(t => t.入职时间).HasColumnName("入职时间");
            this.Property(t => t.离职时间).HasColumnName("离职时间");
        }
    }
}
