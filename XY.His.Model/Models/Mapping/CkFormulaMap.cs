using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CkFormulaMap : EntityTypeConfiguration<CkFormula>
    {
        public CkFormulaMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Formula)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Memo)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("CkFormula");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.TestId).HasColumnName("TestId");
            this.Property(t => t.Formula).HasColumnName("Formula");
            this.Property(t => t.Memo).HasColumnName("Memo");
        }
    }
}
