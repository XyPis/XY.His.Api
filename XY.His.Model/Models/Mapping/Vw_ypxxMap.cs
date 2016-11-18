using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_ypxxMap : EntityTypeConfiguration<Vw_ypxx>
    {
        public Vw_ypxxMap()
        {
            // Primary Key
            this.HasKey(t => new { t.代码, t.商品名, t.化学名, t.商品名五笔码, t.商品名拼音码, t.化学名五笔码, t.规格, t.住院价格, t.门诊价格, t.加成率, t.处方类别, t.默认用量, t.公费类别, t.门诊最小用量, t.住院最小用量, t.C150元以上, t.新项目, t.内部使用, t.长期医嘱周期, t.医嘱类别, t.项目类别 });

            // Properties
            this.Property(t => t.代码)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.商品名)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.化学名)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.商品名五笔码)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.商品名拼音码)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.化学名五笔码)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.化学名拼音码)
                .HasMaxLength(20);

            this.Property(t => t.规格)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.住院单位)
                .HasMaxLength(50);

            this.Property(t => t.住院价格)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.门诊单位)
                .HasMaxLength(50);

            this.Property(t => t.门诊价格)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.加成率)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.处方类别)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.默认用量)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.服用单位)
                .HasMaxLength(50);

            this.Property(t => t.默认频率)
                .HasMaxLength(50);

            this.Property(t => t.门诊收费类别)
                .HasMaxLength(50);

            this.Property(t => t.住院收费类别)
                .HasMaxLength(50);

            this.Property(t => t.公费类别)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.门诊最小用量)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.住院最小用量)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.公费限额类别)
                .HasMaxLength(50);

            this.Property(t => t.长期医嘱周期)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.医嘱类别)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.默认用法)
                .HasMaxLength(50);

            this.Property(t => t.默认药库)
                .HasMaxLength(50);

            this.Property(t => t.默认门诊药房)
                .HasMaxLength(50);

            this.Property(t => t.默认住院药房)
                .HasMaxLength(50);

            this.Property(t => t.药库单位)
                .HasMaxLength(50);

            this.Property(t => t.生产商)
                .HasMaxLength(50);

            this.Property(t => t.剂型)
                .HasMaxLength(50);

            this.Property(t => t.项目类别)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.供应公司)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Vw_ypxx");
            this.Property(t => t.代码).HasColumnName("代码");
            this.Property(t => t.商品名).HasColumnName("商品名");
            this.Property(t => t.化学名).HasColumnName("化学名");
            this.Property(t => t.商品名五笔码).HasColumnName("商品名五笔码");
            this.Property(t => t.商品名拼音码).HasColumnName("商品名拼音码");
            this.Property(t => t.化学名五笔码).HasColumnName("化学名五笔码");
            this.Property(t => t.化学名拼音码).HasColumnName("化学名拼音码");
            this.Property(t => t.规格).HasColumnName("规格");
            this.Property(t => t.住院单位).HasColumnName("住院单位");
            this.Property(t => t.住院价格).HasColumnName("住院价格");
            this.Property(t => t.门诊单位).HasColumnName("门诊单位");
            this.Property(t => t.门诊价格).HasColumnName("门诊价格");
            this.Property(t => t.加成率).HasColumnName("加成率");
            this.Property(t => t.处方类别).HasColumnName("处方类别");
            this.Property(t => t.默认用量).HasColumnName("默认用量");
            this.Property(t => t.服用单位).HasColumnName("服用单位");
            this.Property(t => t.默认频率).HasColumnName("默认频率");
            this.Property(t => t.门诊收费类别).HasColumnName("门诊收费类别");
            this.Property(t => t.住院收费类别).HasColumnName("住院收费类别");
            this.Property(t => t.公费类别).HasColumnName("公费类别");
            this.Property(t => t.门诊最小用量).HasColumnName("门诊最小用量");
            this.Property(t => t.住院最小用量).HasColumnName("住院最小用量");
            this.Property(t => t.公费限额类别).HasColumnName("公费限额类别");
            this.Property(t => t.C150元以上).HasColumnName("150元以上");
            this.Property(t => t.新项目).HasColumnName("新项目");
            this.Property(t => t.内部使用).HasColumnName("内部使用");
            this.Property(t => t.长期医嘱周期).HasColumnName("长期医嘱周期");
            this.Property(t => t.医嘱类别).HasColumnName("医嘱类别");
            this.Property(t => t.默认用法).HasColumnName("默认用法");
            this.Property(t => t.处方药).HasColumnName("处方药");
            this.Property(t => t.毒麻药品).HasColumnName("毒麻药品");
            this.Property(t => t.精神药品).HasColumnName("精神药品");
            this.Property(t => t.抗菌素).HasColumnName("抗菌素");
            this.Property(t => t.院内制剂).HasColumnName("院内制剂");
            this.Property(t => t.贵重药品).HasColumnName("贵重药品");
            this.Property(t => t.默认药库).HasColumnName("默认药库");
            this.Property(t => t.默认门诊药房).HasColumnName("默认门诊药房");
            this.Property(t => t.默认住院药房).HasColumnName("默认住院药房");
            this.Property(t => t.药库单位).HasColumnName("药库单位");
            this.Property(t => t.生产商).HasColumnName("生产商");
            this.Property(t => t.剂型).HasColumnName("剂型");
            this.Property(t => t.项目类别).HasColumnName("项目类别");
            this.Property(t => t.显示顺序).HasColumnName("显示顺序");
            this.Property(t => t.招标药品).HasColumnName("招标药品");
            this.Property(t => t.是否按批次管理).HasColumnName("是否按批次管理");
            this.Property(t => t.是否节省用药).HasColumnName("是否节省用药");
            this.Property(t => t.供应公司).HasColumnName("供应公司");
        }
    }
}
