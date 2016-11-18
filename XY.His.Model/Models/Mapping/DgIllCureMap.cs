using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class DgIllCureMap : EntityTypeConfiguration<DgIllCure>
    {
        public DgIllCureMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Memo)
                .HasMaxLength(50);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("DgIllCure");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.IllId).HasColumnName("IllId");
            this.Property(t => t.IllGroupId).HasColumnName("IllGroupId");
            this.Property(t => t.CureId).HasColumnName("CureId");
            this.Property(t => t.DrugId).HasColumnName("DrugId");
            this.Property(t => t.CheckId).HasColumnName("CheckId");
            this.Property(t => t.NurseId).HasColumnName("NurseId");
            this.Property(t => t.LsAdvType).HasColumnName("LsAdvType");
            this.Property(t => t.LsCureType).HasColumnName("LsCureType");
            this.Property(t => t.IsBaby).HasColumnName("IsBaby");
            this.Property(t => t.IsWomen).HasColumnName("IsWomen");
            this.Property(t => t.IsMen).HasColumnName("IsMen");
            this.Property(t => t.IsOlder).HasColumnName("IsOlder");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");
            this.Property(t => t.Dosage).HasColumnName("Dosage");
            this.Property(t => t.UnitTakeId).HasColumnName("UnitTakeId");
            this.Property(t => t.FrequencyId).HasColumnName("FrequencyId");
            this.Property(t => t.UsageId).HasColumnName("UsageId");
            this.Property(t => t.Days).HasColumnName("Days");
            this.Property(t => t.FeeTotality).HasColumnName("FeeTotality");
            this.Property(t => t.UnitId).HasColumnName("UnitId");

            // Relationships
            this.HasOptional(t => t.BsBaseCheck)
                .WithMany(t => t.DgIllCures)
                .HasForeignKey(d => d.CheckId);
            this.HasOptional(t => t.BsBaseCure)
                .WithMany(t => t.DgIllCures)
                .HasForeignKey(d => d.CureId);
            this.HasOptional(t => t.BsBaseDrug)
                .WithMany(t => t.DgIllCures)
                .HasForeignKey(d => d.DrugId);
            this.HasOptional(t => t.BsBaseNurse)
                .WithMany(t => t.DgIllCures)
                .HasForeignKey(d => d.NurseId);
            this.HasOptional(t => t.BsIllness)
                .WithMany(t => t.DgIllCures)
                .HasForeignKey(d => d.IllId);
            this.HasOptional(t => t.DgIllGroup)
                .WithMany(t => t.DgIllCures)
                .HasForeignKey(d => d.IllGroupId);

        }
    }
}
