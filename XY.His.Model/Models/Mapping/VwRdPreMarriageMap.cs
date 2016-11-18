using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwRdPreMarriageMap : EntityTypeConfiguration<VwRdPreMarriage>
    {
        public VwRdPreMarriageMap()
        {
            // Primary Key
            this.HasKey(t => new { t.病人ID, t.姓名, t.性别, t.单位, t.暂缓结婚, t.不能结婚, t.可婚不可育, t.采取医学措施, t.淋病, t.尖锐湿疣, t.非淋尿道炎, t.梅毒, t.艾滋病, t.麻风, t.子宫内膜异位, t.子宫发育异常, t.子宫肌瘤, t.外阴阴道炎, t.宫颈炎, t.盆腔炎, t.卵巢囊肿, t.包皮过长, t.包茎, t.生殖器炎症, t.阴茎异常, t.精索静脉曲张, t.鞘膜积液, t.隐睾, t.先天性聋哑, t.先天性心脏病, t.智能低下, t.白花病, t.唇裂腭裂, t.G6PD缺乏, t.地贫, t.色盲, t.染色体病, t.真假两性畸形, t.成骨发育不全, t.视网膜母细胞瘤, t.二十一三体, t.睾丸发育不全, t.卵巢发育不全, t.心动过速, t.心率失常, t.风湿性心脏病, t.高血压, t.心肌炎, t.肺结核, t.气管炎, t.淋巴结炎, t.胸膜炎, t.消化性溃疡病, t.肝炎, t.胆囊炎, t.结肠炎, t.慢性胃炎, t.神经管能症, t.神经分裂症, t.癫痫病, t.脑炎后遗症, t.小儿麻痹症, t.慢性肾炎, t.肾孟肾炎, t.泌尿系统感染, t.甲亢, t.糖尿病, t.皮肤病, t.乳腺增生, t.乳腺纤维瘤 });

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

            this.Property(t => t.暂缓结婚)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.不能结婚)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.可婚不可育)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.采取医学措施)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.淋病)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.尖锐湿疣)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.非淋尿道炎)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.梅毒)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.艾滋病)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.麻风)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.子宫内膜异位)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.子宫发育异常)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.子宫肌瘤)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.外阴阴道炎)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.宫颈炎)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.盆腔炎)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.卵巢囊肿)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.包皮过长)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.包茎)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.生殖器炎症)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.阴茎异常)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.精索静脉曲张)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.鞘膜积液)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.隐睾)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.先天性聋哑)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.先天性心脏病)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.智能低下)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.白花病)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.唇裂腭裂)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.G6PD缺乏)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.地贫)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.色盲)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.染色体病)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.真假两性畸形)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.成骨发育不全)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.视网膜母细胞瘤)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.二十一三体)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.睾丸发育不全)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.卵巢发育不全)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.心动过速)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.心率失常)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.风湿性心脏病)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.高血压)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.心肌炎)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.肺结核)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.气管炎)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.淋巴结炎)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.胸膜炎)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.消化性溃疡病)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.肝炎)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.胆囊炎)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.结肠炎)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.慢性胃炎)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.神经管能症)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.神经分裂症)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.癫痫病)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.脑炎后遗症)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.小儿麻痹症)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.慢性肾炎)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.肾孟肾炎)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.泌尿系统感染)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.甲亢)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.糖尿病)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.皮肤病)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.乳腺增生)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.乳腺纤维瘤)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VwRdPreMarriage");
            this.Property(t => t.日期).HasColumnName("日期");
            this.Property(t => t.病人ID).HasColumnName("病人ID");
            this.Property(t => t.姓名).HasColumnName("姓名");
            this.Property(t => t.性别).HasColumnName("性别");
            this.Property(t => t.年龄).HasColumnName("年龄");
            this.Property(t => t.单位).HasColumnName("单位");
            this.Property(t => t.暂缓结婚).HasColumnName("暂缓结婚");
            this.Property(t => t.不能结婚).HasColumnName("不能结婚");
            this.Property(t => t.可婚不可育).HasColumnName("可婚不可育");
            this.Property(t => t.采取医学措施).HasColumnName("采取医学措施");
            this.Property(t => t.淋病).HasColumnName("淋病");
            this.Property(t => t.尖锐湿疣).HasColumnName("尖锐湿疣");
            this.Property(t => t.非淋尿道炎).HasColumnName("非淋尿道炎");
            this.Property(t => t.梅毒).HasColumnName("梅毒");
            this.Property(t => t.艾滋病).HasColumnName("艾滋病");
            this.Property(t => t.麻风).HasColumnName("麻风");
            this.Property(t => t.子宫内膜异位).HasColumnName("子宫内膜异位");
            this.Property(t => t.子宫发育异常).HasColumnName("子宫发育异常");
            this.Property(t => t.子宫肌瘤).HasColumnName("子宫肌瘤");
            this.Property(t => t.外阴阴道炎).HasColumnName("外阴阴道炎");
            this.Property(t => t.宫颈炎).HasColumnName("宫颈炎");
            this.Property(t => t.盆腔炎).HasColumnName("盆腔炎");
            this.Property(t => t.卵巢囊肿).HasColumnName("卵巢囊肿");
            this.Property(t => t.包皮过长).HasColumnName("包皮过长");
            this.Property(t => t.包茎).HasColumnName("包茎");
            this.Property(t => t.生殖器炎症).HasColumnName("生殖器炎症");
            this.Property(t => t.阴茎异常).HasColumnName("阴茎异常");
            this.Property(t => t.精索静脉曲张).HasColumnName("精索静脉曲张");
            this.Property(t => t.鞘膜积液).HasColumnName("鞘膜积液");
            this.Property(t => t.隐睾).HasColumnName("隐睾");
            this.Property(t => t.先天性聋哑).HasColumnName("先天性聋哑");
            this.Property(t => t.先天性心脏病).HasColumnName("先天性心脏病");
            this.Property(t => t.智能低下).HasColumnName("智能低下");
            this.Property(t => t.白花病).HasColumnName("白花病");
            this.Property(t => t.唇裂腭裂).HasColumnName("唇裂腭裂");
            this.Property(t => t.G6PD缺乏).HasColumnName("G6PD缺乏");
            this.Property(t => t.地贫).HasColumnName("地贫");
            this.Property(t => t.色盲).HasColumnName("色盲");
            this.Property(t => t.染色体病).HasColumnName("染色体病");
            this.Property(t => t.真假两性畸形).HasColumnName("真假两性畸形");
            this.Property(t => t.成骨发育不全).HasColumnName("成骨发育不全");
            this.Property(t => t.视网膜母细胞瘤).HasColumnName("视网膜母细胞瘤");
            this.Property(t => t.二十一三体).HasColumnName("二十一三体");
            this.Property(t => t.睾丸发育不全).HasColumnName("睾丸发育不全");
            this.Property(t => t.卵巢发育不全).HasColumnName("卵巢发育不全");
            this.Property(t => t.心动过速).HasColumnName("心动过速");
            this.Property(t => t.心率失常).HasColumnName("心率失常");
            this.Property(t => t.风湿性心脏病).HasColumnName("风湿性心脏病");
            this.Property(t => t.高血压).HasColumnName("高血压");
            this.Property(t => t.心肌炎).HasColumnName("心肌炎");
            this.Property(t => t.肺结核).HasColumnName("肺结核");
            this.Property(t => t.气管炎).HasColumnName("气管炎");
            this.Property(t => t.淋巴结炎).HasColumnName("淋巴结炎");
            this.Property(t => t.胸膜炎).HasColumnName("胸膜炎");
            this.Property(t => t.消化性溃疡病).HasColumnName("消化性溃疡病");
            this.Property(t => t.肝炎).HasColumnName("肝炎");
            this.Property(t => t.胆囊炎).HasColumnName("胆囊炎");
            this.Property(t => t.结肠炎).HasColumnName("结肠炎");
            this.Property(t => t.慢性胃炎).HasColumnName("慢性胃炎");
            this.Property(t => t.神经管能症).HasColumnName("神经管能症");
            this.Property(t => t.神经分裂症).HasColumnName("神经分裂症");
            this.Property(t => t.癫痫病).HasColumnName("癫痫病");
            this.Property(t => t.脑炎后遗症).HasColumnName("脑炎后遗症");
            this.Property(t => t.小儿麻痹症).HasColumnName("小儿麻痹症");
            this.Property(t => t.慢性肾炎).HasColumnName("慢性肾炎");
            this.Property(t => t.肾孟肾炎).HasColumnName("肾孟肾炎");
            this.Property(t => t.泌尿系统感染).HasColumnName("泌尿系统感染");
            this.Property(t => t.甲亢).HasColumnName("甲亢");
            this.Property(t => t.糖尿病).HasColumnName("糖尿病");
            this.Property(t => t.皮肤病).HasColumnName("皮肤病");
            this.Property(t => t.乳腺增生).HasColumnName("乳腺增生");
            this.Property(t => t.乳腺纤维瘤).HasColumnName("乳腺纤维瘤");
        }
    }
}
