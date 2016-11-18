using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class OuLeadRegMap : EntityTypeConfiguration<OuLeadReg>
    {
        public OuLeadRegMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OuLeadReg");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.RegTypeId).HasColumnName("RegTypeId");
            this.Property(t => t.IsPriority).HasColumnName("IsPriority");
            this.Property(t => t.IsElder).HasColumnName("IsElder");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.BsDoctor)
                .WithMany(t => t.OuLeadRegs)
                .HasForeignKey(d => d.DoctorId);
            this.HasRequired(t => t.BsLocation)
                .WithMany(t => t.OuLeadRegs)
                .HasForeignKey(d => d.LocationId);
            this.HasRequired(t => t.BsPatient)
                .WithMany(t => t.OuLeadRegs)
                .HasForeignKey(d => d.PatId);
            this.HasRequired(t => t.BsRegType)
                .WithMany(t => t.OuLeadRegs)
                .HasForeignKey(d => d.RegTypeId);
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.OuLeadRegs)
                .HasForeignKey(d => d.OperId);
            this.HasOptional(t => t.OuHosInfo)
                .WithMany(t => t.OuLeadRegs)
                .HasForeignKey(d => d.MzRegId);

        }
    }
}
