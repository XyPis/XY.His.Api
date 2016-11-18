using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwRdWomenSurveyMap : EntityTypeConfiguration<VwRdWomenSurvey>
    {
        public VwRdWomenSurveyMap()
        {
            // Primary Key
            this.HasKey(t => new { t.病人ID, t.姓名, t.性别, t.单位, t.白斑, t.外阴尖疣, t.细菌性阴道炎, t.真菌, t.滴虫, t.老年性阴道炎, t.支原体, t.衣原体, t.阴道尖疣, t.宫颈肥大, t.宫颈纳囊, t.I度糜烂, t.II度糜烂, t.III度糜烂, t.宫颈息肉, t.宫颈尖疣, t.宫颈Ca, t.子宫压痛, t.子宫内膜Ca, t.附件压痛, t.脱垂I度, t.脱垂II度, t.子宫肌瘤, t.子宫腺肌症, t.附件囊肿, t.混合性包块, t.卵巢Ca, t.HPV阳性, t.刮片II以上, t.TCP异常, t.淋病, t.ASCUS, t.LSIL, t.HSIL, t.乳腺炎, t.乳腺囊肿, t.可疑癌, t.乳腺增生, t.乳腺纤维瘤, t.乳腺肿块, t.乳腺Ca });

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

            this.Property(t => t.白斑)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.外阴尖疣)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.细菌性阴道炎)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.真菌)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.滴虫)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.老年性阴道炎)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.支原体)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.衣原体)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.阴道尖疣)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.宫颈肥大)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.宫颈纳囊)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.I度糜烂)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.II度糜烂)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.III度糜烂)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.宫颈息肉)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.宫颈尖疣)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.宫颈Ca)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.子宫压痛)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.子宫内膜Ca)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.附件压痛)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.脱垂I度)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.脱垂II度)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.子宫肌瘤)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.子宫腺肌症)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.附件囊肿)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.混合性包块)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.卵巢Ca)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HPV阳性)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.刮片II以上)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TCP异常)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.淋病)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ASCUS)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LSIL)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HSIL)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.乳腺炎)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.乳腺囊肿)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.可疑癌)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.乳腺增生)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.乳腺纤维瘤)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.乳腺肿块)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.乳腺Ca)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VwRdWomenSurvey");
            this.Property(t => t.日期).HasColumnName("日期");
            this.Property(t => t.病人ID).HasColumnName("病人ID");
            this.Property(t => t.姓名).HasColumnName("姓名");
            this.Property(t => t.性别).HasColumnName("性别");
            this.Property(t => t.年龄).HasColumnName("年龄");
            this.Property(t => t.单位).HasColumnName("单位");
            this.Property(t => t.白斑).HasColumnName("白斑");
            this.Property(t => t.外阴尖疣).HasColumnName("外阴尖疣");
            this.Property(t => t.细菌性阴道炎).HasColumnName("细菌性阴道炎");
            this.Property(t => t.真菌).HasColumnName("真菌");
            this.Property(t => t.滴虫).HasColumnName("滴虫");
            this.Property(t => t.老年性阴道炎).HasColumnName("老年性阴道炎");
            this.Property(t => t.支原体).HasColumnName("支原体");
            this.Property(t => t.衣原体).HasColumnName("衣原体");
            this.Property(t => t.阴道尖疣).HasColumnName("阴道尖疣");
            this.Property(t => t.宫颈肥大).HasColumnName("宫颈肥大");
            this.Property(t => t.宫颈纳囊).HasColumnName("宫颈纳囊");
            this.Property(t => t.I度糜烂).HasColumnName("I度糜烂");
            this.Property(t => t.II度糜烂).HasColumnName("II度糜烂");
            this.Property(t => t.III度糜烂).HasColumnName("III度糜烂");
            this.Property(t => t.宫颈息肉).HasColumnName("宫颈息肉");
            this.Property(t => t.宫颈尖疣).HasColumnName("宫颈尖疣");
            this.Property(t => t.宫颈Ca).HasColumnName("宫颈Ca");
            this.Property(t => t.子宫压痛).HasColumnName("子宫压痛");
            this.Property(t => t.子宫内膜Ca).HasColumnName("子宫内膜Ca");
            this.Property(t => t.附件压痛).HasColumnName("附件压痛");
            this.Property(t => t.脱垂I度).HasColumnName("脱垂I度");
            this.Property(t => t.脱垂II度).HasColumnName("脱垂II度");
            this.Property(t => t.子宫肌瘤).HasColumnName("子宫肌瘤");
            this.Property(t => t.子宫腺肌症).HasColumnName("子宫腺肌症");
            this.Property(t => t.附件囊肿).HasColumnName("附件囊肿");
            this.Property(t => t.混合性包块).HasColumnName("混合性包块");
            this.Property(t => t.卵巢Ca).HasColumnName("卵巢Ca");
            this.Property(t => t.HPV阳性).HasColumnName("HPV阳性");
            this.Property(t => t.刮片II以上).HasColumnName("刮片II以上");
            this.Property(t => t.TCP异常).HasColumnName("TCP异常");
            this.Property(t => t.淋病).HasColumnName("淋病");
            this.Property(t => t.ASCUS).HasColumnName("ASCUS");
            this.Property(t => t.LSIL).HasColumnName("LSIL");
            this.Property(t => t.HSIL).HasColumnName("HSIL");
            this.Property(t => t.乳腺炎).HasColumnName("乳腺炎");
            this.Property(t => t.乳腺囊肿).HasColumnName("乳腺囊肿");
            this.Property(t => t.可疑癌).HasColumnName("可疑癌");
            this.Property(t => t.乳腺增生).HasColumnName("乳腺增生");
            this.Property(t => t.乳腺纤维瘤).HasColumnName("乳腺纤维瘤");
            this.Property(t => t.乳腺肿块).HasColumnName("乳腺肿块");
            this.Property(t => t.乳腺Ca).HasColumnName("乳腺Ca");
        }
    }
}
