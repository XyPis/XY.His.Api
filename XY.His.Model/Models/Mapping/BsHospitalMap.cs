using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsHospitalMap : EntityTypeConfiguration<BsHospital>
    {
        public BsHospitalMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(6);

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

            this.Property(t => t.Address)
                .HasMaxLength(50);

            this.Property(t => t.Phone)
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .HasMaxLength(30);

            this.Property(t => t.Memo)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("BsHospital");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.AreaId).HasColumnName("AreaId");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.WbCode).HasColumnName("WbCode");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.Area).HasColumnName("Area");
            this.Property(t => t.Farthest).HasColumnName("Farthest");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.ResidentPopulation).HasColumnName("ResidentPopulation");
            this.Property(t => t.TentPopulation).HasColumnName("TentPopulation");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");

            // Relationships
            this.HasRequired(t => t.BsArea)
                .WithMany(t => t.BsHospitals)
                .HasForeignKey(d => d.AreaId);

        }
    }
}
