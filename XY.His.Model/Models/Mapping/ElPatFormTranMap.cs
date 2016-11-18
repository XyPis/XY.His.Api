using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class ElPatFormTranMap : EntityTypeConfiguration<ElPatFormTran>
    {
        public ElPatFormTranMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.RecNo)
                .HasMaxLength(20);

            this.Property(t => t.Reason)
                .HasMaxLength(500);

            this.Property(t => t.FromHospital)
                .HasMaxLength(50);

            this.Property(t => t.ToHospital)
                .HasMaxLength(50);

            this.Property(t => t.Disposal)
                .HasMaxLength(2000);

            this.Property(t => t.Diagnose)
                .HasMaxLength(500);

            this.Property(t => t.Memo)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("ElPatFormTran");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PatFormId).HasColumnName("PatFormId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.RecNo).HasColumnName("RecNo");
            this.Property(t => t.ChangeTime).HasColumnName("ChangeTime");
            this.Property(t => t.ChangeOperId).HasColumnName("ChangeOperId");
            this.Property(t => t.Reason).HasColumnName("Reason");
            this.Property(t => t.FromHospital).HasColumnName("FromHospital");
            this.Property(t => t.ToHospital).HasColumnName("ToHospital");
            this.Property(t => t.RecieveTime).HasColumnName("RecieveTime");
            this.Property(t => t.RecieveOperId).HasColumnName("RecieveOperId");
            this.Property(t => t.Disposal).HasColumnName("Disposal");
            this.Property(t => t.Diagnose).HasColumnName("Diagnose");
            this.Property(t => t.Memo).HasColumnName("Memo");

            // Relationships
            this.HasOptional(t => t.ElPatForm)
                .WithMany(t => t.ElPatFormTrans)
                .HasForeignKey(d => d.PatFormId);

        }
    }
}
