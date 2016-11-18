using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class ElInoculateMap : EntityTypeConfiguration<ElInoculate>
    {
        public ElInoculateMap()
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
            this.ToTable("ElInoculate");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.HospitalId).HasColumnName("HospitalId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.NTime).HasColumnName("NTime");
            this.Property(t => t.PlanTime).HasColumnName("PlanTime");
            this.Property(t => t.PlanOperId).HasColumnName("PlanOperId");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.IsInoculate).HasColumnName("IsInoculate");
            this.Property(t => t.InoTime).HasColumnName("InoTime");
            this.Property(t => t.InoOperId).HasColumnName("InoOperId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.ElInoculates)
                .HasForeignKey(d => d.ItemId);
            this.HasRequired(t => t.BsPatient)
                .WithMany(t => t.ElInoculates)
                .HasForeignKey(d => d.PatId);
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.ElInoculates)
                .HasForeignKey(d => d.PlanOperId);
            this.HasOptional(t => t.BsUser1)
                .WithMany(t => t.ElInoculates1)
                .HasForeignKey(d => d.InoOperId);

        }
    }
}
