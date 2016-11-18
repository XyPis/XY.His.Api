using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class YbPatSeqMap : EntityTypeConfiguration<YbPatSeq>
    {
        public YbPatSeqMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.YbSeq)
                .HasMaxLength(50);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.F5)
                .HasMaxLength(100);

            this.Property(t => t.F6)
                .HasMaxLength(100);

            this.Property(t => t.F7)
                .HasMaxLength(100);

            this.Property(t => t.F8)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("YbPatSeq");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.YbSeq).HasColumnName("YbSeq");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.F5).HasColumnName("F5");
            this.Property(t => t.F6).HasColumnName("F6");
            this.Property(t => t.F7).HasColumnName("F7");
            this.Property(t => t.F8).HasColumnName("F8");

            // Relationships
            this.HasOptional(t => t.InHosInfo)
                .WithMany(t => t.YbPatSeqs)
                .HasForeignKey(d => d.HospId);
            this.HasOptional(t => t.OuHosInfo)
                .WithMany(t => t.YbPatSeqs)
                .HasForeignKey(d => d.MzRegId);

        }
    }
}
