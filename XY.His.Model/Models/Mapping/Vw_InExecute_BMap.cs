using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_InExecute_BMap : EntityTypeConfiguration<Vw_InExecute_B>
    {
        public Vw_InExecute_BMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OperDate, t.ID, t.OperTime, t.OperId, t.LocationId, t.AdviceId, t.LsMarkType, t.Memo, t.IsPrint });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.OperId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LocationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AdviceId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsMarkType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

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

            this.Property(t => t.SkinTest)
                .HasMaxLength(20);

            this.Property(t => t.NurseMemo)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Vw_InExecute_B");
            this.Property(t => t.OperDate).HasColumnName("OperDate");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.AdviceId).HasColumnName("AdviceId");
            this.Property(t => t.LsMarkType).HasColumnName("LsMarkType");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.IsPrint).HasColumnName("IsPrint");
            this.Property(t => t.PrintOperTime).HasColumnName("PrintOperTime");
            this.Property(t => t.PrintOperId).HasColumnName("PrintOperId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.AdviceTime).HasColumnName("AdviceTime");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.GroupNum).HasColumnName("GroupNum");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.Dosage).HasColumnName("Dosage");
            this.Property(t => t.UnitTakeId).HasColumnName("UnitTakeId");
            this.Property(t => t.FrequencyId).HasColumnName("FrequencyId");
            this.Property(t => t.UsageId).HasColumnName("UsageId");
            this.Property(t => t.PriceIn).HasColumnName("PriceIn");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.UnitInId).HasColumnName("UnitInId");
            this.Property(t => t.IsUrgent).HasColumnName("IsUrgent");
            this.Property(t => t.IsAttach).HasColumnName("IsAttach");
            this.Property(t => t.IsSelf).HasColumnName("IsSelf");
            this.Property(t => t.LsSpecialUsage).HasColumnName("LsSpecialUsage");
            this.Property(t => t.LsExecLoc).HasColumnName("LsExecLoc");
            this.Property(t => t.IsSkin).HasColumnName("IsSkin");
            this.Property(t => t.SkinTime).HasColumnName("SkinTime");
            this.Property(t => t.SkinTest).HasColumnName("SkinTest");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.ExecLocId).HasColumnName("ExecLocId");
            this.Property(t => t.IsExecuted).HasColumnName("IsExecuted");
            this.Property(t => t.ExecutedTime).HasColumnName("ExecutedTime");
            this.Property(t => t.ExecutedOperId).HasColumnName("ExecutedOperId");
            this.Property(t => t.IsMinus).HasColumnName("IsMinus");
            this.Property(t => t.NurseMemo).HasColumnName("NurseMemo");
            this.Property(t => t.MemoTime).HasColumnName("MemoTime");
            this.Property(t => t.MemoOperId).HasColumnName("MemoOperId");
            this.Property(t => t.FirstDay).HasColumnName("FirstDay");
            this.Property(t => t.LastDay).HasColumnName("LastDay");
            this.Property(t => t.IsLastLong).HasColumnName("IsLastLong");
        }
    }
}
