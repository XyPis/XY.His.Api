using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_DI_OurecipeDtlMap : EntityTypeConfiguration<Vw_DI_OurecipeDtl>
    {
        public Vw_DI_OurecipeDtlMap()
        {
            // Primary Key
            this.HasKey(t => new { t.就诊卡号, t.性别, t.处方编号, t.处方时间, t.药品编码, t.药品通用名, t.药品商品名, t.药品规格, t.用法 });

            // Properties
            this.Property(t => t.就诊卡号)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.性别)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.医疗付款方式)
                .HasMaxLength(50);

            this.Property(t => t.科室名称)
                .HasMaxLength(30);

            this.Property(t => t.医师工号)
                .HasMaxLength(12);

            this.Property(t => t.医师职称)
                .HasMaxLength(50);

            this.Property(t => t.处方编号)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.药品编码)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.药品通用名)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.药品商品名)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.药品生产企业)
                .HasMaxLength(50);

            this.Property(t => t.给药途径)
                .HasMaxLength(50);

            this.Property(t => t.药品规格)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.剂量)
                .HasMaxLength(50);

            this.Property(t => t.用法)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.包装数量)
                .HasMaxLength(50);

            this.Property(t => t.包装)
                .HasMaxLength(201);

            this.Property(t => t.单价)
                .HasMaxLength(52);

            // Table & Column Mappings
            this.ToTable("Vw_DI_OurecipeDtl");
            this.Property(t => t.就诊卡号).HasColumnName("就诊卡号");
            this.Property(t => t.性别).HasColumnName("性别");
            this.Property(t => t.年龄).HasColumnName("年龄");
            this.Property(t => t.医疗付款方式).HasColumnName("医疗付款方式");
            this.Property(t => t.科室名称).HasColumnName("科室名称");
            this.Property(t => t.医师工号).HasColumnName("医师工号");
            this.Property(t => t.医师职称).HasColumnName("医师职称");
            this.Property(t => t.处方编号).HasColumnName("处方编号");
            this.Property(t => t.处方时间).HasColumnName("处方时间");
            this.Property(t => t.药品编码).HasColumnName("药品编码");
            this.Property(t => t.药品通用名).HasColumnName("药品通用名");
            this.Property(t => t.药品商品名).HasColumnName("药品商品名");
            this.Property(t => t.药品生产企业).HasColumnName("药品生产企业");
            this.Property(t => t.给药途径).HasColumnName("给药途径");
            this.Property(t => t.药品规格).HasColumnName("药品规格");
            this.Property(t => t.剂量).HasColumnName("剂量");
            this.Property(t => t.用法).HasColumnName("用法");
            this.Property(t => t.包装数量).HasColumnName("包装数量");
            this.Property(t => t.包装).HasColumnName("包装");
            this.Property(t => t.单价).HasColumnName("单价");
            this.Property(t => t.数量).HasColumnName("数量");
            this.Property(t => t.药品金额).HasColumnName("药品金额");
            this.Property(t => t.审核药师工号).HasColumnName("审核药师工号");
            this.Property(t => t.调剂药师工号).HasColumnName("调剂药师工号");
        }
    }
}
