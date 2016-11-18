using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsInfectionMap : EntityTypeConfiguration<BsInfection>
    {
        public BsInfectionMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.f1)
                .HasMaxLength(100);

            this.Property(t => t.f2)
                .HasMaxLength(100);

            this.Property(t => t.f3)
                .HasMaxLength(100);

            this.Property(t => t.f4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BsInfection");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.f1).HasColumnName("f1");
            this.Property(t => t.f2).HasColumnName("f2");
            this.Property(t => t.f3).HasColumnName("f3");
            this.Property(t => t.f4).HasColumnName("f4");
            this.Property(t => t.isactive).HasColumnName("isactive");
            this.Property(t => t.orderby).HasColumnName("orderby");
        }
    }
}
