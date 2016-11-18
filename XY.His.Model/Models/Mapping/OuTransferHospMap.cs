using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class OuTransferHospMap : EntityTypeConfiguration<OuTransferHosp>
    {
        public OuTransferHospMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.InPatNo)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.Reason)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.ReturnMemo)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("OuTransferHosp");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.InPatNo).HasColumnName("InPatNo");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.HospitalId).HasColumnName("HospitalId");
            this.Property(t => t.OutTime).HasColumnName("OutTime");
            this.Property(t => t.Reason).HasColumnName("Reason");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.ReturnTime).HasColumnName("ReturnTime");
            this.Property(t => t.ReturnMemo).HasColumnName("ReturnMemo");
            this.Property(t => t.ReturnOperTime).HasColumnName("ReturnOperTime");
            this.Property(t => t.ReturnOperID).HasColumnName("ReturnOperID");

            // Relationships
            this.HasRequired(t => t.BsHospital)
                .WithMany(t => t.OuTransferHosps)
                .HasForeignKey(d => d.HospitalId);
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.OuTransferHosps)
                .HasForeignKey(d => d.OperID);
            this.HasOptional(t => t.BsUser1)
                .WithMany(t => t.OuTransferHosps1)
                .HasForeignKey(d => d.ReturnOperID);
            this.HasOptional(t => t.InHosInfo)
                .WithMany(t => t.OuTransferHosps)
                .HasForeignKey(d => d.HospId);
            this.HasOptional(t => t.OuHosInfo)
                .WithMany(t => t.OuTransferHosps)
                .HasForeignKey(d => d.MzRegId);

        }
    }
}
