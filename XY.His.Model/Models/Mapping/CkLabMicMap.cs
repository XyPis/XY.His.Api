using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CkLabMicMap : EntityTypeConfiguration<CkLabMic>
    {
        public CkLabMicMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Memo)
                .IsRequired()
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
            this.ToTable("CkLabMic");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.LabId).HasColumnName("LabId");
            this.Property(t => t.BacteriaId).HasColumnName("BacteriaId");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.IsPrint).HasColumnName("IsPrint");
            this.Property(t => t.PrintTime).HasColumnName("PrintTime");
            this.Property(t => t.PrintOperId).HasColumnName("PrintOperId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsBacteria)
                .WithMany(t => t.CkLabMics)
                .HasForeignKey(d => d.BacteriaId);
            this.HasRequired(t => t.CkLab)
                .WithMany(t => t.CkLabMics)
                .HasForeignKey(d => d.LabId);

        }
    }
}
