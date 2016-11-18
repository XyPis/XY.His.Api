using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class ElPatFormValueMap : EntityTypeConfiguration<ElPatFormValue>
    {
        public ElPatFormValueMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ElValue)
                .HasMaxLength(4000);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("ElPatFormValue");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PatFormId).HasColumnName("PatFormId");
            this.Property(t => t.ElId).HasColumnName("ElId");
            this.Property(t => t.ElValue).HasColumnName("ElValue");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.LsType).HasColumnName("LsType");
            this.Property(t => t.ClassId).HasColumnName("ClassId");

            // Relationships
            this.HasOptional(t => t.ElBaseFiled)
                .WithMany(t => t.ElPatFormValues)
                .HasForeignKey(d => d.ElId);
            this.HasOptional(t => t.ElPatForm)
                .WithMany(t => t.ElPatFormValues)
                .HasForeignKey(d => d.PatFormId);
            this.HasOptional(t => t.GblElClass)
                .WithMany(t => t.ElPatFormValues)
                .HasForeignKey(d => d.ClassId);

        }
    }
}
