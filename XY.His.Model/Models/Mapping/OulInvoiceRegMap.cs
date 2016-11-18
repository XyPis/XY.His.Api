using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class OulInvoiceRegMap : EntityTypeConfiguration<OulInvoiceReg>
    {
        public OulInvoiceRegMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.InvoNo)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OulInvoiceReg");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.InvoNo).HasColumnName("InvoNo");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.InvoTime).HasColumnName("InvoTime");
            this.Property(t => t.RegFee).HasColumnName("RegFee");
            this.Property(t => t.DiagnoFee).HasColumnName("DiagnoFee");
            this.Property(t => t.ZyFee).HasColumnName("ZyFee");
            this.Property(t => t.OtherFee1).HasColumnName("OtherFee1");
            this.Property(t => t.OtherFee2).HasColumnName("OtherFee2");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");
            this.Property(t => t.CancelTime).HasColumnName("CancelTime");
            this.Property(t => t.CancelOperId).HasColumnName("CancelOperId");
            this.Property(t => t.InvoLastId).HasColumnName("InvoLastId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.HospitalId).HasColumnName("HospitalId");
            this.Property(t => t.RegTypeId).HasColumnName("RegTypeId");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.PatTypeId).HasColumnName("PatTypeId");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.CheckTime).HasColumnName("CheckTime");
            this.Property(t => t.CancelCheckTime).HasColumnName("CancelCheckTime");
            this.Property(t => t.DocLocId).HasColumnName("DocLocId");

            // Relationships
            this.HasRequired(t => t.OuHosInfo)
                .WithMany(t => t.OulInvoiceRegs)
                .HasForeignKey(d => d.MzRegId);
            this.HasOptional(t => t.OulInvoiceReg2)
                .WithMany(t => t.OulInvoiceReg1)
                .HasForeignKey(d => d.InvoLastId);

        }
    }
}
