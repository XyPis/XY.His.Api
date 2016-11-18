using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class InRecFirstPageMap : EntityTypeConfiguration<InRecFirstPage>
    {
        public InRecFirstPageMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.RecNo)
                .HasMaxLength(20);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("InRecFirstPage");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RecNo).HasColumnName("RecNo");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.ModifyOperTime).HasColumnName("ModifyOperTime");
            this.Property(t => t.ModifyOperID).HasColumnName("ModifyOperID");
            this.Property(t => t.IsAuth).HasColumnName("IsAuth");
            this.Property(t => t.AuthOperTime).HasColumnName("AuthOperTime");
            this.Property(t => t.AuthOperId).HasColumnName("AuthOperId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.ConfirmIllDate).HasColumnName("ConfirmIllDate");
            this.Property(t => t.IsOPS).HasColumnName("IsOPS");
            this.Property(t => t.IsBabyCard).HasColumnName("IsBabyCard");
            this.Property(t => t.IsMutiIll).HasColumnName("IsMutiIll");
            this.Property(t => t.InfectTimes).HasColumnName("InfectTimes");
            this.Property(t => t.IsSalvage).HasColumnName("IsSalvage");
            this.Property(t => t.SalvageTimes).HasColumnName("SalvageTimes");
            this.Property(t => t.IsSalvSucess).HasColumnName("IsSalvSucess");
            this.Property(t => t.SalvSucessTimes).HasColumnName("SalvSucessTimes");
            this.Property(t => t.IsFollow).HasColumnName("IsFollow");
            this.Property(t => t.FollowEndDate).HasColumnName("FollowEndDate");
            this.Property(t => t.IsDeadBodyCheck).HasColumnName("IsDeadBodyCheck");
            this.Property(t => t.IsStudyCase).HasColumnName("IsStudyCase");
            this.Property(t => t.LsQuality).HasColumnName("LsQuality");
            this.Property(t => t.ZrDoctorId).HasColumnName("ZrDoctorId");
            this.Property(t => t.ZzDoctorId).HasColumnName("ZzDoctorId");
            this.Property(t => t.ZyDoctorId).HasColumnName("ZyDoctorId");
            this.Property(t => t.SxDoctorId).HasColumnName("SxDoctorId");
            this.Property(t => t.JxDoctorId).HasColumnName("JxDoctorId");
            this.Property(t => t.YjsDoctorId).HasColumnName("YjsDoctorId");
            this.Property(t => t.ZkDoctorId).HasColumnName("ZkDoctorId");
            this.Property(t => t.LsAccMzIll).HasColumnName("LsAccMzIll");
            this.Property(t => t.LsAccZyIll).HasColumnName("LsAccZyIll");
            this.Property(t => t.LsAccOPSIll1).HasColumnName("LsAccOPSIll1");
            this.Property(t => t.LsAccOPSIll2).HasColumnName("LsAccOPSIll2");
            this.Property(t => t.LsAccOPSIll3).HasColumnName("LsAccOPSIll3");
            this.Property(t => t.LsAccOPSIll4).HasColumnName("LsAccOPSIll4");
            this.Property(t => t.IsTjIll).HasColumnName("IsTjIll");
            this.Property(t => t.IsConfirm3D).HasColumnName("IsConfirm3D");
            this.Property(t => t.BabyNum).HasColumnName("BabyNum");
            this.Property(t => t.IsTranNeact).HasColumnName("IsTranNeact");
            this.Property(t => t.IsOxygenNeact).HasColumnName("IsOxygenNeact");
            this.Property(t => t.IsMidFireBurn).HasColumnName("IsMidFireBurn");
            this.Property(t => t.IsSingleIll).HasColumnName("IsSingleIll");
            this.Property(t => t.IsHbsAg).HasColumnName("IsHbsAg");
            this.Property(t => t.IsHCVAb).HasColumnName("IsHCVAb");
            this.Property(t => t.IsHIVAb).HasColumnName("IsHIVAb");
            this.Property(t => t.IsHbsAg3).HasColumnName("IsHbsAg3");
            this.Property(t => t.HeadOperId).HasColumnName("HeadOperId");
            this.Property(t => t.ZkOperId).HasColumnName("ZkOperId");
            this.Property(t => t.ZkDate).HasColumnName("ZkDate");
            this.Property(t => t.IsRH).HasColumnName("IsRH");
            this.Property(t => t.IsOpsFirst).HasColumnName("IsOpsFirst");
            this.Property(t => t.IsCureFirst).HasColumnName("IsCureFirst");
            this.Property(t => t.IsCheckFirst).HasColumnName("IsCheckFirst");
            this.Property(t => t.IsDiagFirst).HasColumnName("IsDiagFirst");
            this.Property(t => t.RedCellNum).HasColumnName("RedCellNum");
            this.Property(t => t.PlaqueNum).HasColumnName("PlaqueNum");
            this.Property(t => t.SerousNum).HasColumnName("SerousNum");
            this.Property(t => t.AllBloodNum).HasColumnName("AllBloodNum");
            this.Property(t => t.OtherBloodNum).HasColumnName("OtherBloodNum");
            this.Property(t => t.ConsultHosputal).HasColumnName("ConsultHosputal");
            this.Property(t => t.ConsultRemote).HasColumnName("ConsultRemote");

            // Relationships
            this.HasOptional(t => t.BsDoctor)
                .WithMany(t => t.InRecFirstPages)
                .HasForeignKey(d => d.JxDoctorId);
            this.HasOptional(t => t.BsDoctor1)
                .WithMany(t => t.InRecFirstPages1)
                .HasForeignKey(d => d.YjsDoctorId);
            this.HasOptional(t => t.BsDoctor2)
                .WithMany(t => t.InRecFirstPages2)
                .HasForeignKey(d => d.ZkDoctorId);
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.InRecFirstPages)
                .HasForeignKey(d => d.OperID);
            this.HasOptional(t => t.BsUser1)
                .WithMany(t => t.InRecFirstPages1)
                .HasForeignKey(d => d.AuthOperId);
            this.HasOptional(t => t.BsUser2)
                .WithMany(t => t.InRecFirstPages2)
                .HasForeignKey(d => d.HeadOperId);
            this.HasOptional(t => t.BsUser3)
                .WithMany(t => t.InRecFirstPages3)
                .HasForeignKey(d => d.ZkOperId);
            this.HasRequired(t => t.InHosInfo)
                .WithMany(t => t.InRecFirstPages)
                .HasForeignKey(d => d.HospId);
            this.HasOptional(t => t.InHosInfo1)
                .WithMany(t => t.InRecFirstPages1)
                .HasForeignKey(d => d.ModifyOperID);

        }
    }
}
