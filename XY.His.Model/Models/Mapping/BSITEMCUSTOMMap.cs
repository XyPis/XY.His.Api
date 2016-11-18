using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BSITEMCUSTOMMap : EntityTypeConfiguration<BSITEMCUSTOM>
    {
        public BSITEMCUSTOMMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CUSTOMTYPE)
                .HasMaxLength(100);

            this.Property(t => t.MEMO)
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
            this.ToTable("BSITEMCUSTOM");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ITEMID).HasColumnName("ITEMID");
            this.Property(t => t.REPORTID).HasColumnName("REPORTID");
            this.Property(t => t.CUSTOMTYPE).HasColumnName("CUSTOMTYPE");
            this.Property(t => t.ORDERBY).HasColumnName("ORDERBY");
            this.Property(t => t.ICONINDEX).HasColumnName("ICONINDEX");
            this.Property(t => t.MEMO).HasColumnName("MEMO");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.BSITEMCUSTOMGROUP)
                .WithMany(t => t.BSITEMCUSTOMs)
                .HasForeignKey(d => d.REPORTID);

        }
    }
}
