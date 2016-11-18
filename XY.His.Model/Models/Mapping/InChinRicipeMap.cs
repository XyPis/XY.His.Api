using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class InChinRicipeMap : EntityTypeConfiguration<InChinRicipe>
    {
        public InChinRicipeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.RecipeNo)
                .IsRequired()
                .HasMaxLength(12);

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
            this.ToTable("InChinRicipe");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RecipeNo).HasColumnName("RecipeNo");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.DrugNum).HasColumnName("DrugNum");
            this.Property(t => t.DecoctNum).HasColumnName("DecoctNum");
            this.Property(t => t.IsConfirm).HasColumnName("IsConfirm");
            this.Property(t => t.LsCookSelf).HasColumnName("LsCookSelf");
            this.Property(t => t.ConfirmOperID).HasColumnName("ConfirmOperID");
            this.Property(t => t.ConfirmOperTime).HasColumnName("ConfirmOperTime");
            this.Property(t => t.IsBack).HasColumnName("IsBack");
            this.Property(t => t.IsPrint).HasColumnName("IsPrint");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.FrequencyId).HasColumnName("FrequencyId");
            this.Property(t => t.UsageId).HasColumnName("UsageId");
            this.Property(t => t.IsPriority).HasColumnName("IsPriority");
            this.Property(t => t.IsAuth).HasColumnName("IsAuth");
            this.Property(t => t.BackTime).HasColumnName("BackTime");
            this.Property(t => t.CookMinute).HasColumnName("CookMinute");
            this.Property(t => t.LsFire).HasColumnName("LsFire");
            this.Property(t => t.AdviceLocationId).HasColumnName("AdviceLocationId");

            // Relationships
            this.HasRequired(t => t.BsDoctor)
                .WithMany(t => t.InChinRicipes)
                .HasForeignKey(d => d.DoctorId);
            this.HasOptional(t => t.BsFrequency)
                .WithMany(t => t.InChinRicipes)
                .HasForeignKey(d => d.FrequencyId);
            this.HasRequired(t => t.BsLocation)
                .WithMany(t => t.InChinRicipes)
                .HasForeignKey(d => d.LocationId);
            this.HasOptional(t => t.BsUsage)
                .WithMany(t => t.InChinRicipes)
                .HasForeignKey(d => d.UsageId);
            this.HasRequired(t => t.InHosInfo)
                .WithMany(t => t.InChinRicipes)
                .HasForeignKey(d => d.HospId);

        }
    }
}
