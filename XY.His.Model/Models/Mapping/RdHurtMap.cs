using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class RdHurtMap : EntityTypeConfiguration<RdHurt>
    {
        public RdHurtMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .HasMaxLength(12);

            this.Property(t => t.HospitalCode)
                .HasMaxLength(12);

            this.Property(t => t.ElHurtReason)
                .HasMaxLength(50);

            this.Property(t => t.ElHurtPlace)
                .HasMaxLength(50);

            this.Property(t => t.ElHurtActivity)
                .HasMaxLength(50);

            this.Property(t => t.ElHurtNature)
                .HasMaxLength(50);

            this.Property(t => t.ElHurtPosition)
                .HasMaxLength(50);

            this.Property(t => t.HurtClinical)
                .HasMaxLength(50);

            this.Property(t => t.ElHurtEnding)
                .HasMaxLength(50);

            this.Property(t => t.ProductName)
                .HasMaxLength(50);

            this.Property(t => t.ProductNames)
                .HasMaxLength(50);

            this.Property(t => t.ProductType)
                .HasMaxLength(50);

            this.Property(t => t.ProductTypes)
                .HasMaxLength(50);

            this.Property(t => t.Typical)
                .HasMaxLength(50);

            this.Property(t => t.F1)
                .HasMaxLength(50);

            this.Property(t => t.F2)
                .HasMaxLength(50);

            this.Property(t => t.F3)
                .HasMaxLength(50);

            this.Property(t => t.F4)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("RdHurt");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.HospitalCode).HasColumnName("HospitalCode");
            this.Property(t => t.HurtTime).HasColumnName("HurtTime");
            this.Property(t => t.DiagDate).HasColumnName("DiagDate");
            this.Property(t => t.LsHurtReason).HasColumnName("LsHurtReason");
            this.Property(t => t.LsHurtCensus).HasColumnName("LsHurtCensus");
            this.Property(t => t.ElHurtReason).HasColumnName("ElHurtReason");
            this.Property(t => t.LsHurtPlace).HasColumnName("LsHurtPlace");
            this.Property(t => t.ElHurtPlace).HasColumnName("ElHurtPlace");
            this.Property(t => t.LsHurtActivity).HasColumnName("LsHurtActivity");
            this.Property(t => t.ElHurtActivity).HasColumnName("ElHurtActivity");
            this.Property(t => t.LsIsDeliberately).HasColumnName("LsIsDeliberately");
            this.Property(t => t.LsHurtNature).HasColumnName("LsHurtNature");
            this.Property(t => t.ElHurtNature).HasColumnName("ElHurtNature");
            this.Property(t => t.LsHurtPosition).HasColumnName("LsHurtPosition");
            this.Property(t => t.ElHurtPosition).HasColumnName("ElHurtPosition");
            this.Property(t => t.LsHurtDegree).HasColumnName("LsHurtDegree");
            this.Property(t => t.HurtClinical).HasColumnName("HurtClinical");
            this.Property(t => t.LsHurtEnding).HasColumnName("LsHurtEnding");
            this.Property(t => t.ElHurtEnding).HasColumnName("ElHurtEnding");
            this.Property(t => t.LsHurtProduct).HasColumnName("LsHurtProduct");
            this.Property(t => t.LsHurtProducts).HasColumnName("LsHurtProducts");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.ProductNames).HasColumnName("ProductNames");
            this.Property(t => t.ProductType).HasColumnName("ProductType");
            this.Property(t => t.ProductTypes).HasColumnName("ProductTypes");
            this.Property(t => t.Typical).HasColumnName("Typical");
            this.Property(t => t.LocId).HasColumnName("LocId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsPatient)
                .WithMany(t => t.RdHurts)
                .HasForeignKey(d => d.PatId);
            this.HasRequired(t => t.OuHosInfo)
                .WithMany(t => t.RdHurts)
                .HasForeignKey(d => d.MzRegId);

        }
    }
}
