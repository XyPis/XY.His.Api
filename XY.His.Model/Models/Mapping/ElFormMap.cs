using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class ElFormMap : EntityTypeConfiguration<ElForm>
    {
        public ElFormMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.X)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Y)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Title)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("ElForm");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PatMenuId).HasColumnName("PatMenuId");
            this.Property(t => t.ElId).HasColumnName("ElId");
            this.Property(t => t.X).HasColumnName("X");
            this.Property(t => t.Y).HasColumnName("Y");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.ReadOnly).HasColumnName("ReadOnly");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
        }
    }
}
