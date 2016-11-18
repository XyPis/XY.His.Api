using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class ZXYBMXDTLMap : EntityTypeConfiguration<ZXYBMXDTL>
    {
        public ZXYBMXDTLMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.HOSPID });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.HOSPID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ASTR1)
                .HasMaxLength(100);

            this.Property(t => t.ASTR2)
                .HasMaxLength(100);

            this.Property(t => t.ASTR3)
                .HasMaxLength(400);

            this.Property(t => t.ASTR4)
                .HasMaxLength(100);

            this.Property(t => t.ASTR5)
                .HasMaxLength(100);

            this.Property(t => t.ASTR6)
                .HasMaxLength(100);

            this.Property(t => t.ASTR7)
                .HasMaxLength(100);

            this.Property(t => t.ASTR8)
                .HasMaxLength(100);

            this.Property(t => t.ASTR9)
                .HasMaxLength(100);

            this.Property(t => t.ASTR10)
                .HasMaxLength(100);

            this.Property(t => t.ASTR11)
                .HasMaxLength(100);

            this.Property(t => t.ASTR12)
                .HasMaxLength(100);

            this.Property(t => t.ASTR13)
                .HasMaxLength(100);

            this.Property(t => t.ASTR14)
                .HasMaxLength(100);

            this.Property(t => t.ASTR15)
                .HasMaxLength(100);

            this.Property(t => t.ASTR24)
                .HasMaxLength(100);

            this.Property(t => t.ASTR25)
                .HasMaxLength(100);

            this.Property(t => t.ASTR26)
                .HasMaxLength(100);

            this.Property(t => t.ASTR27)
                .HasMaxLength(100);

            this.Property(t => t.ASTR28)
                .HasMaxLength(100);

            this.Property(t => t.ASTR29)
                .HasMaxLength(1000);

            this.Property(t => t.ASTR30)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("ZXYBMXDTL");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HOSPID).HasColumnName("HOSPID");
            this.Property(t => t.ASTR1).HasColumnName("ASTR1");
            this.Property(t => t.ASTR2).HasColumnName("ASTR2");
            this.Property(t => t.ASTR3).HasColumnName("ASTR3");
            this.Property(t => t.ASTR4).HasColumnName("ASTR4");
            this.Property(t => t.ASTR5).HasColumnName("ASTR5");
            this.Property(t => t.ASTR6).HasColumnName("ASTR6");
            this.Property(t => t.ASTR7).HasColumnName("ASTR7");
            this.Property(t => t.ASTR8).HasColumnName("ASTR8");
            this.Property(t => t.ASTR9).HasColumnName("ASTR9");
            this.Property(t => t.ASTR10).HasColumnName("ASTR10");
            this.Property(t => t.ASTR11).HasColumnName("ASTR11");
            this.Property(t => t.ASTR12).HasColumnName("ASTR12");
            this.Property(t => t.ASTR13).HasColumnName("ASTR13");
            this.Property(t => t.ASTR14).HasColumnName("ASTR14");
            this.Property(t => t.ASTR15).HasColumnName("ASTR15");
            this.Property(t => t.ASTR16).HasColumnName("ASTR16");
            this.Property(t => t.ASTR17).HasColumnName("ASTR17");
            this.Property(t => t.ASTR18).HasColumnName("ASTR18");
            this.Property(t => t.ASTR19).HasColumnName("ASTR19");
            this.Property(t => t.ASTR20).HasColumnName("ASTR20");
            this.Property(t => t.ASTR21).HasColumnName("ASTR21");
            this.Property(t => t.ASTR22).HasColumnName("ASTR22");
            this.Property(t => t.ASTR23).HasColumnName("ASTR23");
            this.Property(t => t.ASTR24).HasColumnName("ASTR24");
            this.Property(t => t.ASTR25).HasColumnName("ASTR25");
            this.Property(t => t.ASTR26).HasColumnName("ASTR26");
            this.Property(t => t.ASTR27).HasColumnName("ASTR27");
            this.Property(t => t.ASTR28).HasColumnName("ASTR28");
            this.Property(t => t.ASTR29).HasColumnName("ASTR29");
            this.Property(t => t.ASTR30).HasColumnName("ASTR30");
        }
    }
}
