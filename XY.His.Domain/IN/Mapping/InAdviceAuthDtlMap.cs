using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Domain.IN.Mapping
{
    public class InAdviceAuthDtlMap : EntityTypeConfiguration<InAdviceAuthDtl>
    {
        public InAdviceAuthDtlMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.SkinTest)
                .HasMaxLength(100);

            this.Property(t => t.Memo)
                .HasMaxLength(200);

            this.Property(t => t.SN)
                .HasMaxLength(100);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.F5)
                .HasMaxLength(100);

            this.Property(t => t.F6)
                .HasMaxLength(100);

            this.Property(t => t.F7)
                .HasMaxLength(100);

            this.Property(t => t.F8)
                .HasMaxLength(100);

            this.Property(t => t.AdviceName)
                .HasMaxLength(100);

            this.Property(t => t.Name)
                .HasMaxLength(100);

            this.Property(t => t.Code)
                .HasMaxLength(100);

            this.Property(t => t.Spec)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("AdviceAuthDtl");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.LsMarkType).HasColumnName("LsMarkType");
            this.Property(t => t.AdviceTime).HasColumnName("AdviceTime");
            this.Property(t => t.AdviceId).HasColumnName("AdviceId");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.GroupNum).HasColumnName("GroupNum");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.FormId).HasColumnName("FormId");
            this.Property(t => t.PriceIn).HasColumnName("PriceIn");
            this.Property(t => t.UnitTakeId).HasColumnName("UnitTakeId");
            this.Property(t => t.FrequencyId).HasColumnName("FrequencyId");
            this.Property(t => t.UsageId).HasColumnName("UsageId");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.ToTalityAll).HasColumnName("ToTalityAll");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.UnitInId).HasColumnName("UnitInId");
            this.Property(t => t.IsAttach).HasColumnName("IsAttach");
            this.Property(t => t.IsSelf).HasColumnName("IsSelf");
            this.Property(t => t.LsSpecialUsage).HasColumnName("LsSpecialUsage");
            this.Property(t => t.LsExecLoc).HasColumnName("LsExecLoc");
            this.Property(t => t.SkinTime).HasColumnName("SkinTime");
            this.Property(t => t.IsSkin).HasColumnName("IsSkin");
            this.Property(t => t.SkinTest).HasColumnName("SkinTest");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.IsPrinted).HasColumnName("IsPrinted");
            this.Property(t => t.IsChk).HasColumnName("IsChk");
            this.Property(t => t.ChkOperTime).HasColumnName("ChkOperTime");
            this.Property(t => t.ChkOperID).HasColumnName("ChkOperID");
            this.Property(t => t.IsEnd).HasColumnName("IsEnd");
            this.Property(t => t.EndOperTime).HasColumnName("EndOperTime");
            this.Property(t => t.EndOperID).HasColumnName("EndOperID");
            this.Property(t => t.EndDoctorID).HasColumnName("EndDoctorID");
            this.Property(t => t.IsAuth).HasColumnName("IsAuth");
            this.Property(t => t.AuthOperTime).HasColumnName("AuthOperTime");
            this.Property(t => t.AuthOperId).HasColumnName("AuthOperId");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.IsOtherFee).HasColumnName("IsOtherFee");
            this.Property(t => t.IsBeforeops).HasColumnName("IsBeforeops");
            this.Property(t => t.LsRpType).HasColumnName("LsRpType");
            this.Property(t => t.IsInject).HasColumnName("IsInject");
            this.Property(t => t.SN).HasColumnName("SN");
            this.Property(t => t.FirstDay).HasColumnName("FirstDay");
            this.Property(t => t.LastDay).HasColumnName("LastDay");
            this.Property(t => t.ExecLocId).HasColumnName("ExecLocId");
            this.Property(t => t.OriAdviceId).HasColumnName("OriAdviceId");
            this.Property(t => t.InfeeCheck).HasColumnName("InfeeCheck");
            this.Property(t => t.Adcolor).HasColumnName("Adcolor");
            this.Property(t => t.IsManual).HasColumnName("IsManual");
            this.Property(t => t.IsArrearage).HasColumnName("IsArrearage");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.F5).HasColumnName("F5");
            this.Property(t => t.F6).HasColumnName("F6");
            this.Property(t => t.F7).HasColumnName("F7");
            this.Property(t => t.F8).HasColumnName("F8");
            this.Property(t => t.IsTodayIn).HasColumnName("IsTodayIn");
            this.Property(t => t.DrugReqId1).HasColumnName("DrugReqId1");
            this.Property(t => t.DrugReqId2).HasColumnName("DrugReqId2");
            this.Property(t => t.DetailId1).HasColumnName("DetailId1");
            this.Property(t => t.DetailId2).HasColumnName("DetailId2");
            this.Property(t => t.AdviceName).HasColumnName("AdviceName");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.ExecuteId).HasColumnName("ExecuteId");
            this.Property(t => t.ExecuteId2).HasColumnName("ExecuteId2");
            this.Property(t => t.Dosage).HasColumnName("Dosage");
            this.Property(t => t.ExecDoctorId).HasColumnName("ExecDoctorId");

            // Relationships

        }
    }
}
