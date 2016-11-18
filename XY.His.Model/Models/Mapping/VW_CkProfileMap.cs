using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VW_CkProfileMap : EntityTypeConfiguration<VW_CkProfile>
    {
        public VW_CkProfileMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.PROFILEID, t.TESTID });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PROFILEID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TESTID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PROFILENAME)
                .HasMaxLength(100);

            this.Property(t => t.TESTNAME)
                .HasMaxLength(100);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("VW_CkProfile");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PROFILEID).HasColumnName("PROFILEID");
            this.Property(t => t.TESTID).HasColumnName("TESTID");
            this.Property(t => t.PROFILENAME).HasColumnName("PROFILENAME");
            this.Property(t => t.TESTNAME).HasColumnName("TESTNAME");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.ITEMID).HasColumnName("ITEMID");
        }
    }
}
