using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class ElFormDtlMap : EntityTypeConfiguration<ElFormDtl>
    {
        public ElFormDtlMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Title)
                .HasMaxLength(50);

            this.Property(t => t.DefultValue)
                .HasMaxLength(50);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.FontColor)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ElFormDtl");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PatMenuId).HasColumnName("PatMenuId");
            this.Property(t => t.ElId).HasColumnName("ElId");
            this.Property(t => t.NColumn).HasColumnName("NColumn");
            this.Property(t => t.NRow).HasColumnName("NRow");
            this.Property(t => t.ColumnSpan).HasColumnName("ColumnSpan");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.IsReadOnly).HasColumnName("IsReadOnly");
            this.Property(t => t.IsRequire).HasColumnName("IsRequire");
            this.Property(t => t.DefultValue).HasColumnName("DefultValue");
            this.Property(t => t.LsAlignment).HasColumnName("LsAlignment");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IsInherit).HasColumnName("IsInherit");
            this.Property(t => t.ColWidth).HasColumnName("ColWidth");
            this.Property(t => t.FontSize).HasColumnName("FontSize");
            this.Property(t => t.FontColor).HasColumnName("FontColor");

            // Relationships
            this.HasOptional(t => t.ElBaseFiled)
                .WithMany(t => t.ElFormDtls)
                .HasForeignKey(d => d.ElId);
            this.HasRequired(t => t.GblPatientMenu)
                .WithMany(t => t.ElFormDtls)
                .HasForeignKey(d => d.PatMenuId);

        }
    }
}
