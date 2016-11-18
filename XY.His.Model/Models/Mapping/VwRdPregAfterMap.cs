using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwRdPregAfterMap : EntityTypeConfiguration<VwRdPregAfter>
    {
        public VwRdPregAfterMap()
        {
            // Primary Key
            this.HasKey(t => new { t.病人ID, t.姓名, t.性别, t.单位, t.尖疣, t.宫颈炎I度, t.宫颈炎II度, t.宫颈炎III度, t.子宫颈息肉, t.子宫颈癌, t.子宫肌瘤, t.子宫内膜癌, t.附件囊肿或包块, t.卵巢癌, t.更年期, t.乳腺增生, t.乳腺肿块, t.乳腺癌, t.刮片II级以上, t.TCT异常, t.HPV阳性, t.更年期咨询与指导, t.产后计生育咨询与指导, t.亚健康咨询与指导, t.骨密度咨询与指导 });

            // Properties
            this.Property(t => t.日期)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.病人ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.姓名)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.性别)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.单位)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.尖疣)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.宫颈炎I度)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.宫颈炎II度)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.宫颈炎III度)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.子宫颈息肉)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.子宫颈癌)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.子宫肌瘤)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.子宫内膜癌)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.附件囊肿或包块)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.卵巢癌)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.更年期)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.乳腺增生)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.乳腺肿块)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.乳腺癌)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.刮片II级以上)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TCT异常)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HPV阳性)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.更年期咨询与指导)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.产后计生育咨询与指导)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.亚健康咨询与指导)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.骨密度咨询与指导)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VwRdPregAfter");
            this.Property(t => t.日期).HasColumnName("日期");
            this.Property(t => t.病人ID).HasColumnName("病人ID");
            this.Property(t => t.姓名).HasColumnName("姓名");
            this.Property(t => t.性别).HasColumnName("性别");
            this.Property(t => t.年龄).HasColumnName("年龄");
            this.Property(t => t.单位).HasColumnName("单位");
            this.Property(t => t.尖疣).HasColumnName("尖疣");
            this.Property(t => t.宫颈炎I度).HasColumnName("宫颈炎I度");
            this.Property(t => t.宫颈炎II度).HasColumnName("宫颈炎II度");
            this.Property(t => t.宫颈炎III度).HasColumnName("宫颈炎III度");
            this.Property(t => t.子宫颈息肉).HasColumnName("子宫颈息肉");
            this.Property(t => t.子宫颈癌).HasColumnName("子宫颈癌");
            this.Property(t => t.子宫肌瘤).HasColumnName("子宫肌瘤");
            this.Property(t => t.子宫内膜癌).HasColumnName("子宫内膜癌");
            this.Property(t => t.附件囊肿或包块).HasColumnName("附件囊肿或包块");
            this.Property(t => t.卵巢癌).HasColumnName("卵巢癌");
            this.Property(t => t.更年期).HasColumnName("更年期");
            this.Property(t => t.乳腺增生).HasColumnName("乳腺增生");
            this.Property(t => t.乳腺肿块).HasColumnName("乳腺肿块");
            this.Property(t => t.乳腺癌).HasColumnName("乳腺癌");
            this.Property(t => t.刮片II级以上).HasColumnName("刮片II级以上");
            this.Property(t => t.TCT异常).HasColumnName("TCT异常");
            this.Property(t => t.HPV阳性).HasColumnName("HPV阳性");
            this.Property(t => t.更年期咨询与指导).HasColumnName("更年期咨询与指导");
            this.Property(t => t.产后计生育咨询与指导).HasColumnName("产后计生育咨询与指导");
            this.Property(t => t.亚健康咨询与指导).HasColumnName("亚健康咨询与指导");
            this.Property(t => t.骨密度咨询与指导).HasColumnName("骨密度咨询与指导");
        }
    }
}
