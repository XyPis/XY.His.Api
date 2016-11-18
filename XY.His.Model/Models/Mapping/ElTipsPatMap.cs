using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class ElTipsPatMap : EntityTypeConfiguration<ElTipsPat>
    {
        public ElTipsPatMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Tips)
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
            this.ToTable("ElTipsPat");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospitalId).HasColumnName("HospitalId");
            this.Property(t => t.TipId).HasColumnName("TipId");
            this.Property(t => t.Tips).HasColumnName("Tips");
            this.Property(t => t.PatFormId).HasColumnName("PatFormId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.ActiveDays).HasColumnName("ActiveDays");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.BsHospital)
                .WithMany(t => t.ElTipsPats)
                .HasForeignKey(d => d.HospitalId);
            this.HasOptional(t => t.ElTip)
                .WithMany(t => t.ElTipsPats)
                .HasForeignKey(d => d.TipId);

        }
    }
}
