using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_DI_InAdviceMap : EntityTypeConfiguration<Vw_DI_InAdvice>
    {
        public Vw_DI_InAdviceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.病案号, t.住院次数, t.医嘱类别, t.药品编码, t.药品通用名, t.药品商品名, t.规格, t.包装数量, t.包装, t.单位, t.摆药数量, t.单价 });

            // Properties
            this.Property(t => t.病案号)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.住院次数)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.医嘱类别)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

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

            this.Property(t => t.规格)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.剂型)
                .HasMaxLength(50);

            this.Property(t => t.用法)
                .HasMaxLength(50);

            this.Property(t => t.包装数量)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.包装)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.单位)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.摆药数量)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.单价)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.医师工号)
                .HasMaxLength(12);

            this.Property(t => t.医师的职称)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Vw_DI_InAdvice");
            this.Property(t => t.病案号).HasColumnName("病案号");
            this.Property(t => t.住院次数).HasColumnName("住院次数");
            this.Property(t => t.摆药时间).HasColumnName("摆药时间");
            this.Property(t => t.医嘱类别).HasColumnName("医嘱类别");
            this.Property(t => t.药品编码).HasColumnName("药品编码");
            this.Property(t => t.药品通用名).HasColumnName("药品通用名");
            this.Property(t => t.药品商品名).HasColumnName("药品商品名");
            this.Property(t => t.药品生产企业).HasColumnName("药品生产企业");
            this.Property(t => t.给药途径).HasColumnName("给药途径");
            this.Property(t => t.规格).HasColumnName("规格");
            this.Property(t => t.剂型).HasColumnName("剂型");
            this.Property(t => t.用法).HasColumnName("用法");
            this.Property(t => t.包装数量).HasColumnName("包装数量");
            this.Property(t => t.包装).HasColumnName("包装");
            this.Property(t => t.单位).HasColumnName("单位");
            this.Property(t => t.摆药数量).HasColumnName("摆药数量");
            this.Property(t => t.单价).HasColumnName("单价");
            this.Property(t => t.药品金额).HasColumnName("药品金额");
            this.Property(t => t.医师工号).HasColumnName("医师工号");
            this.Property(t => t.医师的职称).HasColumnName("医师的职称");
            this.Property(t => t.审核药师工号).HasColumnName("审核药师工号");
            this.Property(t => t.调剂药师工号).HasColumnName("调剂药师工号");
        }
    }
}
