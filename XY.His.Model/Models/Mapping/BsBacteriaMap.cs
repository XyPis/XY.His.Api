using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsBacteriaMap : EntityTypeConfiguration<BsBacteria>
    {
        public BsBacteriaMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PyCode)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.WbCode)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BsBacteria");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.TypeId).HasColumnName("TypeId");
            this.Property(t => t.GramsId).HasColumnName("GramsId");
            this.Property(t => t.ShuId).HasColumnName("ShuId");
            this.Property(t => t.StandTypeId).HasColumnName("StandTypeId");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.WbCode).HasColumnName("WbCode");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");

            // Relationships
            this.HasOptional(t => t.BsBacteriaGram)
                .WithMany(t => t.BsBacterias)
                .HasForeignKey(d => d.GramsId);
            this.HasRequired(t => t.BsBacteriaShu)
                .WithMany(t => t.BsBacterias)
                .HasForeignKey(d => d.ShuId);
            this.HasRequired(t => t.BsBacteriaStandType)
                .WithMany(t => t.BsBacterias)
                .HasForeignKey(d => d.StandTypeId);
            this.HasRequired(t => t.BsBacteriaType)
                .WithMany(t => t.BsBacterias)
                .HasForeignKey(d => d.TypeId);

        }
    }
}
