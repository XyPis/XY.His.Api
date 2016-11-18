using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class RdNewBirthMap : EntityTypeConfiguration<RdNewBirth>
    {
        public RdNewBirthMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.F1)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.MotherName)
                .HasMaxLength(50);

            this.Property(t => t.FatherName)
                .HasMaxLength(50);

            this.Property(t => t.OtherPlace)
                .HasMaxLength(50);

            this.Property(t => t.DeliverOrgan)
                .HasMaxLength(50);

            this.Property(t => t.SignOrgan)
                .HasMaxLength(50);

            this.Property(t => t.Midwife)
                .HasMaxLength(50);

            this.Property(t => t.MotherAge)
                .HasMaxLength(50);

            this.Property(t => t.MotherIdCard)
                .HasMaxLength(50);

            this.Property(t => t.MotherNation)
                .HasMaxLength(50);

            this.Property(t => t.MotherCountry)
                .HasMaxLength(50);

            this.Property(t => t.FatherIdCard)
                .HasMaxLength(50);

            this.Property(t => t.Weeks)
                .HasMaxLength(50);

            this.Property(t => t.FatherAge)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("RdNewBirth");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.ProvinceId).HasColumnName("ProvinceId");
            this.Property(t => t.RegionId).HasColumnName("RegionId");
            this.Property(t => t.AreaId).HasColumnName("AreaId");
            this.Property(t => t.CommitteeId).HasColumnName("CommitteeId");
            this.Property(t => t.FamilyId).HasColumnName("FamilyId");
            this.Property(t => t.LsStatus).HasColumnName("LsStatus");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.Height).HasColumnName("Height");
            this.Property(t => t.MotherName).HasColumnName("MotherName");
            this.Property(t => t.FatherName).HasColumnName("FatherName");
            this.Property(t => t.LsBornPlace).HasColumnName("LsBornPlace");
            this.Property(t => t.OtherPlace).HasColumnName("OtherPlace");
            this.Property(t => t.DeliverOrgan).HasColumnName("DeliverOrgan");
            this.Property(t => t.SignOrgan).HasColumnName("SignOrgan");
            this.Property(t => t.SignDate).HasColumnName("SignDate");
            this.Property(t => t.Midwife).HasColumnName("Midwife");
            this.Property(t => t.IsDanger).HasColumnName("IsDanger");
            this.Property(t => t.IsCure).HasColumnName("IsCure");
            this.Property(t => t.IsFilter).HasColumnName("IsFilter");
            this.Property(t => t.ChildBirthId).HasColumnName("ChildBirthId");
            this.Property(t => t.MotherAge).HasColumnName("MotherAge");
            this.Property(t => t.MotherIdCard).HasColumnName("MotherIdCard");
            this.Property(t => t.MotherNation).HasColumnName("MotherNation");
            this.Property(t => t.MotherCountry).HasColumnName("MotherCountry");
            this.Property(t => t.FatherIdCard).HasColumnName("FatherIdCard");
            this.Property(t => t.Weeks).HasColumnName("Weeks");
            this.Property(t => t.FatherAge).HasColumnName("FatherAge");
            this.Property(t => t.Fathercountryid).HasColumnName("Fathercountryid");
            this.Property(t => t.Fathernationid).HasColumnName("Fathernationid");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.BirthResult).HasColumnName("BirthResult");
            this.Property(t => t.BirthStyle).HasColumnName("BirthStyle");
            this.Property(t => t.BirthStifle).HasColumnName("BirthStifle");

            // Relationships
            this.HasOptional(t => t.BsArea)
                .WithMany(t => t.RdNewBirths)
                .HasForeignKey(d => d.AreaId);
            this.HasOptional(t => t.BsAreaCommittee)
                .WithMany(t => t.RdNewBirths)
                .HasForeignKey(d => d.CommitteeId);
            this.HasOptional(t => t.BsAreaProvince)
                .WithMany(t => t.RdNewBirths)
                .HasForeignKey(d => d.ProvinceId);
            this.HasOptional(t => t.BsAreaRegion)
                .WithMany(t => t.RdNewBirths)
                .HasForeignKey(d => d.RegionId);
            this.HasRequired(t => t.BsPatient)
                .WithMany(t => t.RdNewBirths)
                .HasForeignKey(d => d.PatId);
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.RdNewBirths)
                .HasForeignKey(d => d.OperID);
            this.HasOptional(t => t.InHosInfo)
                .WithMany(t => t.RdNewBirths)
                .HasForeignKey(d => d.HospId);

        }
    }
}
