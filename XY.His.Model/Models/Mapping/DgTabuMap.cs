using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class DgTabuMap : EntityTypeConfiguration<DgTabu>
    {
        public DgTabuMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.LClass)
                .HasMaxLength(50);

            this.Property(t => t.Expain)
                .HasMaxLength(500);

            this.Property(t => t.F1)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.F2)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.F3)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.F4)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("DgTabu");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.DrugID).HasColumnName("DrugID");
            this.Property(t => t.DrugID1).HasColumnName("DrugID1");
            this.Property(t => t.DrugID2).HasColumnName("DrugID2");
            this.Property(t => t.DrugID3).HasColumnName("DrugID3");
            this.Property(t => t.DrugID4).HasColumnName("DrugID4");
            this.Property(t => t.LClass).HasColumnName("LClass");
            this.Property(t => t.Expain).HasColumnName("Expain");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsBaseDrug)
                .WithMany(t => t.DgTabus)
                .HasForeignKey(d => d.DrugID);

        }
    }
}
