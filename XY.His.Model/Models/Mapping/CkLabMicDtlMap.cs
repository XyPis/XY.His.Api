using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CkLabMicDtlMap : EntityTypeConfiguration<CkLabMicDtl>
    {
        public CkLabMicDtlMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Result)
                .HasMaxLength(100);

            this.Property(t => t.LsMic)
                .HasMaxLength(50);

            this.Property(t => t.Memo)
                .HasMaxLength(500);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("CkLabMicDtl");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.MicId).HasColumnName("MicId");
            this.Property(t => t.DrugId).HasColumnName("DrugId");
            this.Property(t => t.Result).HasColumnName("Result");
            this.Property(t => t.LsMic).HasColumnName("LsMic");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.BsBaseDrug)
                .WithMany(t => t.CkLabMicDtls)
                .HasForeignKey(d => d.DrugId);
            this.HasRequired(t => t.CkLabMic)
                .WithMany(t => t.CkLabMicDtls)
                .HasForeignKey(d => d.MicId);

        }
    }
}
