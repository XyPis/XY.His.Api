using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class ZXYbPatMap : EntityTypeConfiguration<ZXYbPat>
    {
        public ZXYbPatMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.PatId });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.PatId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Astr1)
                .HasMaxLength(50);

            this.Property(t => t.Astr2)
                .HasMaxLength(50);

            this.Property(t => t.Astr3)
                .HasMaxLength(200);

            this.Property(t => t.Astr4)
                .HasMaxLength(50);

            this.Property(t => t.Astr5)
                .HasMaxLength(50);

            this.Property(t => t.Astr6)
                .HasMaxLength(50);

            this.Property(t => t.Astr7)
                .HasMaxLength(50);

            this.Property(t => t.Astr8)
                .HasMaxLength(50);

            this.Property(t => t.Astr9)
                .HasMaxLength(50);

            this.Property(t => t.Astr10)
                .HasMaxLength(50);

            this.Property(t => t.Astr11)
                .HasMaxLength(50);

            this.Property(t => t.Astr12)
                .HasMaxLength(50);

            this.Property(t => t.Astr13)
                .HasMaxLength(50);

            this.Property(t => t.Astr14)
                .HasMaxLength(50);

            this.Property(t => t.Astr15)
                .HasMaxLength(50);

            this.Property(t => t.Astr16)
                .HasMaxLength(50);

            this.Property(t => t.Astr17)
                .HasMaxLength(50);

            this.Property(t => t.Astr18)
                .HasMaxLength(50);

            this.Property(t => t.Astr19)
                .HasMaxLength(50);

            this.Property(t => t.Astr20)
                .HasMaxLength(50);

            this.Property(t => t.Astr21)
                .HasMaxLength(50);

            this.Property(t => t.Astr22)
                .HasMaxLength(50);

            this.Property(t => t.Astr23)
                .HasMaxLength(50);

            this.Property(t => t.Astr24)
                .HasMaxLength(50);

            this.Property(t => t.Astr25)
                .HasMaxLength(50);

            this.Property(t => t.Astr26)
                .HasMaxLength(50);

            this.Property(t => t.Astr27)
                .HasMaxLength(50);

            this.Property(t => t.Astr28)
                .HasMaxLength(50);

            this.Property(t => t.Astr29)
                .HasMaxLength(500);

            this.Property(t => t.Astr30)
                .HasMaxLength(50);

            this.Property(t => t.Astr31)
                .HasMaxLength(50);

            this.Property(t => t.Astr32)
                .HasMaxLength(500);

            this.Property(t => t.Astr33)
                .HasMaxLength(50);

            this.Property(t => t.Astr34)
                .HasMaxLength(50);

            this.Property(t => t.Astr35)
                .HasMaxLength(50);

            this.Property(t => t.Astr36)
                .HasMaxLength(50);

            this.Property(t => t.Astr37)
                .HasMaxLength(50);

            this.Property(t => t.Astr38)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ZXYbPat");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.Astr1).HasColumnName("Astr1");
            this.Property(t => t.Astr2).HasColumnName("Astr2");
            this.Property(t => t.Astr3).HasColumnName("Astr3");
            this.Property(t => t.Astr4).HasColumnName("Astr4");
            this.Property(t => t.Astr5).HasColumnName("Astr5");
            this.Property(t => t.Astr6).HasColumnName("Astr6");
            this.Property(t => t.Astr7).HasColumnName("Astr7");
            this.Property(t => t.Astr8).HasColumnName("Astr8");
            this.Property(t => t.Astr9).HasColumnName("Astr9");
            this.Property(t => t.Astr10).HasColumnName("Astr10");
            this.Property(t => t.Astr11).HasColumnName("Astr11");
            this.Property(t => t.Astr12).HasColumnName("Astr12");
            this.Property(t => t.Astr13).HasColumnName("Astr13");
            this.Property(t => t.Astr14).HasColumnName("Astr14");
            this.Property(t => t.Astr15).HasColumnName("Astr15");
            this.Property(t => t.Astr16).HasColumnName("Astr16");
            this.Property(t => t.Astr17).HasColumnName("Astr17");
            this.Property(t => t.Astr18).HasColumnName("Astr18");
            this.Property(t => t.Astr19).HasColumnName("Astr19");
            this.Property(t => t.Astr20).HasColumnName("Astr20");
            this.Property(t => t.Astr21).HasColumnName("Astr21");
            this.Property(t => t.Astr22).HasColumnName("Astr22");
            this.Property(t => t.Astr23).HasColumnName("Astr23");
            this.Property(t => t.Astr24).HasColumnName("Astr24");
            this.Property(t => t.Astr25).HasColumnName("Astr25");
            this.Property(t => t.Astr26).HasColumnName("Astr26");
            this.Property(t => t.Astr27).HasColumnName("Astr27");
            this.Property(t => t.Astr28).HasColumnName("Astr28");
            this.Property(t => t.Astr29).HasColumnName("Astr29");
            this.Property(t => t.Astr30).HasColumnName("Astr30");
            this.Property(t => t.Astr31).HasColumnName("Astr31");
            this.Property(t => t.Astr32).HasColumnName("Astr32");
            this.Property(t => t.Astr33).HasColumnName("Astr33");
            this.Property(t => t.Astr34).HasColumnName("Astr34");
            this.Property(t => t.Astr35).HasColumnName("Astr35");
            this.Property(t => t.Astr36).HasColumnName("Astr36");
            this.Property(t => t.Astr37).HasColumnName("Astr37");
            this.Property(t => t.Astr38).HasColumnName("Astr38");

            // Relationships
            this.HasRequired(t => t.BsPatient)
                .WithMany(t => t.ZXYbPats)
                .HasForeignKey(d => d.PatId);

        }
    }
}
