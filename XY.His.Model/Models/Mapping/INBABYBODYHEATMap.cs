using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class INBABYBODYHEATMap : EntityTypeConfiguration<INBABYBODYHEAT>
    {
        public INBABYBODYHEATMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.heattype)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.breath)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.stool)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.urine)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.weight)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.bldpress0)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.bldpress1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.fluidm)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.totalin)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.urinem)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.otherm)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.totalout)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.memoup)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.memodn)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.others)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.f1)
                .HasMaxLength(50);

            this.Property(t => t.f2)
                .HasMaxLength(50);

            this.Property(t => t.f3)
                .HasMaxLength(50);

            this.Property(t => t.f4)
                .HasMaxLength(50);

            this.Property(t => t.cwinject)
                .HasMaxLength(50);

            this.Property(t => t.jminject)
                .HasMaxLength(50);

            this.Property(t => t.cwheight)
                .HasMaxLength(50);

            this.Property(t => t.f5)
                .HasMaxLength(50);

            this.Property(t => t.f6)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("INBABYBODYHEAT");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.hospid).HasColumnName("hospid");
            this.Property(t => t.opertime).HasColumnName("opertime");
            this.Property(t => t.operid).HasColumnName("operid");
            this.Property(t => t.animalheat).HasColumnName("animalheat");
            this.Property(t => t.heattype).HasColumnName("heattype");
            this.Property(t => t.pulse).HasColumnName("pulse");
            this.Property(t => t.heart).HasColumnName("heart");
            this.Property(t => t.breath).HasColumnName("breath");
            this.Property(t => t.stool).HasColumnName("stool");
            this.Property(t => t.urine).HasColumnName("urine");
            this.Property(t => t.weight).HasColumnName("weight");
            this.Property(t => t.bldpress0).HasColumnName("bldpress0");
            this.Property(t => t.bldpress1).HasColumnName("bldpress1");
            this.Property(t => t.fluidm).HasColumnName("fluidm");
            this.Property(t => t.totalin).HasColumnName("totalin");
            this.Property(t => t.urinem).HasColumnName("urinem");
            this.Property(t => t.otherm).HasColumnName("otherm");
            this.Property(t => t.totalout).HasColumnName("totalout");
            this.Property(t => t.memoup).HasColumnName("memoup");
            this.Property(t => t.memodn).HasColumnName("memodn");
            this.Property(t => t.spintest).HasColumnName("spintest");
            this.Property(t => t.lowertemp).HasColumnName("lowertemp");
            this.Property(t => t.isrecheck).HasColumnName("isrecheck");
            this.Property(t => t.isoutside).HasColumnName("isoutside");
            this.Property(t => t.ismachine).HasColumnName("ismachine");
            this.Property(t => t.others).HasColumnName("others");
            this.Property(t => t.isops).HasColumnName("isops");
            this.Property(t => t.birthtime).HasColumnName("birthtime");
            this.Property(t => t.isreject).HasColumnName("isreject");
            this.Property(t => t.deadtime).HasColumnName("deadtime");
            this.Property(t => t.locationid).HasColumnName("locationid");
            this.Property(t => t.f1).HasColumnName("f1");
            this.Property(t => t.f2).HasColumnName("f2");
            this.Property(t => t.f3).HasColumnName("f3");
            this.Property(t => t.f4).HasColumnName("f4");
            this.Property(t => t.bg).HasColumnName("bg");
            this.Property(t => t.cwinject).HasColumnName("cwinject");
            this.Property(t => t.jminject).HasColumnName("jminject");
            this.Property(t => t.cwheight).HasColumnName("cwheight");
            this.Property(t => t.ismotherfeed).HasColumnName("ismotherfeed");
            this.Property(t => t.ishumanfeed).HasColumnName("ishumanfeed");
            this.Property(t => t.ubsstool).HasColumnName("ubsstool");
            this.Property(t => t.umbilical).HasColumnName("umbilical");
            this.Property(t => t.f5).HasColumnName("f5");
            this.Property(t => t.f6).HasColumnName("f6");
        }
    }
}
