using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class DgDrugTipMap : EntityTypeConfiguration<DgDrugTip>
    {
        public DgDrugTipMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.LClass)
                .HasMaxLength(50);

            this.Property(t => t.Expain)
                .HasMaxLength(500);

            this.Property(t => t.F1)
                .HasMaxLength(50);

            this.Property(t => t.F2)
                .HasMaxLength(50);

            this.Property(t => t.F3)
                .HasMaxLength(50);

            this.Property(t => t.F4)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DgDrugTip");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.DrugID).HasColumnName("DrugID");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.AgeFrom).HasColumnName("AgeFrom");
            this.Property(t => t.AgeTo).HasColumnName("AgeTo");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.WorktypeId).HasColumnName("WorktypeId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.IcdId).HasColumnName("IcdId");
            this.Property(t => t.LsWomenStatus).HasColumnName("LsWomenStatus");
            this.Property(t => t.DropSpeed).HasColumnName("DropSpeed");
            this.Property(t => t.LClass).HasColumnName("LClass");
            this.Property(t => t.Expain).HasColumnName("Expain");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.Dosage).HasColumnName("Dosage");

            // Relationships
            this.HasRequired(t => t.BsBaseDrug)
                .WithMany(t => t.DgDrugTips)
                .HasForeignKey(d => d.DrugID);
            this.HasOptional(t => t.BsWorkType)
                .WithMany(t => t.DgDrugTips)
                .HasForeignKey(d => d.WorktypeId);

        }
    }
}
