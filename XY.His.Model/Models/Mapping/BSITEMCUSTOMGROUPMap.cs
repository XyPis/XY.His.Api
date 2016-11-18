using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BSITEMCUSTOMGROUPMap : EntityTypeConfiguration<BSITEMCUSTOMGROUP>
    {
        public BSITEMCUSTOMGROUPMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NAME)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.F1)
                .HasMaxLength(200);

            this.Property(t => t.F2)
                .HasMaxLength(200);

            this.Property(t => t.F3)
                .HasMaxLength(200);

            this.Property(t => t.F4)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("BSITEMCUSTOMGROUP");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.NAME).HasColumnName("NAME");
            this.Property(t => t.ORDERBY).HasColumnName("ORDERBY");
            this.Property(t => t.ISACTIVE).HasColumnName("ISACTIVE");
            this.Property(t => t.LSOUTORIN).HasColumnName("LSOUTORIN");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.ICONINDEX).HasColumnName("ICONINDEX");
        }
    }
}
