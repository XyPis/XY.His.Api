using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class OpsApplyMap : EntityTypeConfiguration<OpsApply>
    {
        public OpsApplyMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ApplyNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Assistant)
                .HasMaxLength(50);

            this.Property(t => t.Diagnose)
                .HasMaxLength(1000);

            this.Property(t => t.BedNo)
                .HasMaxLength(50);

            this.Property(t => t.BloodGroup)
                .HasMaxLength(50);

            this.Property(t => t.Blood)
                .HasMaxLength(50);

            this.Property(t => t.OpsBody)
                .HasMaxLength(50);

            this.Property(t => t.OpsPos)
                .HasMaxLength(50);

            this.Property(t => t.OtherTools)
                .HasMaxLength(50);

            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.PlanMemo)
                .HasMaxLength(500);

            this.Property(t => t.FinishMemo)
                .HasMaxLength(500);

            this.Property(t => t.BloodSum)
                .HasMaxLength(50);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.BloodRpt)
                .HasMaxLength(500);

            this.Property(t => t.Sensitive)
                .HasMaxLength(500);

            this.Property(t => t.SeqNum)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OpsApply");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ApplyNo).HasColumnName("ApplyNo");
            this.Property(t => t.ApplyTime).HasColumnName("ApplyTime");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.OpsId).HasColumnName("OpsId");
            this.Property(t => t.OpsOtherId).HasColumnName("OpsOtherId");
            this.Property(t => t.AnaeId).HasColumnName("AnaeId");
            this.Property(t => t.Assistant).HasColumnName("Assistant");
            this.Property(t => t.Diagnose).HasColumnName("Diagnose");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.BedNo).HasColumnName("BedNo");
            this.Property(t => t.LsHbsAg).HasColumnName("LsHbsAg");
            this.Property(t => t.LsAsepsis).HasColumnName("LsAsepsis");
            this.Property(t => t.BloodGroup).HasColumnName("BloodGroup");
            this.Property(t => t.Blood).HasColumnName("Blood");
            this.Property(t => t.OpsBody).HasColumnName("OpsBody");
            this.Property(t => t.OpsPos).HasColumnName("OpsPos");
            this.Property(t => t.OtherTools).HasColumnName("OtherTools");
            this.Property(t => t.IsUrgent).HasColumnName("IsUrgent");
            this.Property(t => t.IsCalled).HasColumnName("IsCalled");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.PlanOperId).HasColumnName("PlanOperId");
            this.Property(t => t.PlanTime).HasColumnName("PlanTime");
            this.Property(t => t.PlanMemo).HasColumnName("PlanMemo");
            this.Property(t => t.IsFinish).HasColumnName("IsFinish");
            this.Property(t => t.FinishTime).HasColumnName("FinishTime");
            this.Property(t => t.FinishOperId).HasColumnName("FinishOperId");
            this.Property(t => t.FinishMemo).HasColumnName("FinishMemo");
            this.Property(t => t.BeginTime).HasColumnName("BeginTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.BloodSum).HasColumnName("BloodSum");
            this.Property(t => t.LsCutClass).HasColumnName("LsCutClass");
            this.Property(t => t.LsCure).HasColumnName("LsCure");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.BloodRpt).HasColumnName("BloodRpt");
            this.Property(t => t.Sensitive).HasColumnName("Sensitive");
            this.Property(t => t.OpsRoomId).HasColumnName("OpsRoomId");
            this.Property(t => t.SeqNum).HasColumnName("SeqNum");

            // Relationships
            this.HasOptional(t => t.BsAnae)
                .WithMany(t => t.OpsApplies)
                .HasForeignKey(d => d.AnaeId);
            this.HasOptional(t => t.BsDoctor)
                .WithMany(t => t.OpsApplies)
                .HasForeignKey(d => d.DoctorId);
            this.HasOptional(t => t.BsLocation)
                .WithMany(t => t.OpsApplies)
                .HasForeignKey(d => d.LocationId);
            this.HasOptional(t => t.BsOP)
                .WithMany(t => t.OpsApplies)
                .HasForeignKey(d => d.OpsId);
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.OpsApplies)
                .HasForeignKey(d => d.OperId);
            this.HasOptional(t => t.InHosInfo)
                .WithMany(t => t.OpsApplies)
                .HasForeignKey(d => d.HospId);
            this.HasOptional(t => t.OuHosInfo)
                .WithMany(t => t.OpsApplies)
                .HasForeignKey(d => d.MzRegId);

        }
    }
}
