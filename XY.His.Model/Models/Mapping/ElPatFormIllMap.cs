using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class ElPatFormIllMap : EntityTypeConfiguration<ElPatFormIll>
    {
        public ElPatFormIllMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.IllDesc)
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
            this.ToTable("ElPatFormIll");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PatFormId).HasColumnName("PatFormId");
            this.Property(t => t.ListNum).HasColumnName("ListNum");
            this.Property(t => t.IcdId).HasColumnName("IcdId");
            this.Property(t => t.IllDesc).HasColumnName("IllDesc");
            this.Property(t => t.LsInOut).HasColumnName("LsInOut");
            this.Property(t => t.LsWestChin).HasColumnName("LsWestChin");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.BsIllness)
                .WithMany(t => t.ElPatFormIlls)
                .HasForeignKey(d => d.IcdId);

        }
    }
}
