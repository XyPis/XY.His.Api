using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class PsDrugActionMap : EntityTypeConfiguration<PsDrugAction>
    {
        public PsDrugActionMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ApplyNo)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.ClincHandle)
                .HasMaxLength(500);

            this.Property(t => t.Memo)
                .HasMaxLength(200);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("PsDrugAction");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ApplyNo).HasColumnName("ApplyNo");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");
            this.Property(t => t.CancelTime).HasColumnName("CancelTime");
            this.Property(t => t.CancelOperId).HasColumnName("CancelOperId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.ReactTime).HasColumnName("ReactTime");
            this.Property(t => t.LsTransType).HasColumnName("LsTransType");
            this.Property(t => t.ClincHandle).HasColumnName("ClincHandle");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.BsDoctor)
                .WithMany(t => t.PsDrugActions)
                .HasForeignKey(d => d.DoctorId);
            this.HasOptional(t => t.BsItem)
                .WithMany(t => t.PsDrugActions)
                .HasForeignKey(d => d.ItemId);
            this.HasOptional(t => t.BsLocation)
                .WithMany(t => t.PsDrugActions)
                .HasForeignKey(d => d.LocationId);
            this.HasRequired(t => t.BsPatient)
                .WithMany(t => t.PsDrugActions)
                .HasForeignKey(d => d.PatId);
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.PsDrugActions)
                .HasForeignKey(d => d.OperId);
            this.HasOptional(t => t.BsUser1)
                .WithMany(t => t.PsDrugActions1)
                .HasForeignKey(d => d.CancelOperId);
            this.HasOptional(t => t.InHosInfo)
                .WithMany(t => t.PsDrugActions)
                .HasForeignKey(d => d.HospId);
            this.HasOptional(t => t.OuHosInfo)
                .WithMany(t => t.PsDrugActions)
                .HasForeignKey(d => d.MzRegId);

        }
    }
}
