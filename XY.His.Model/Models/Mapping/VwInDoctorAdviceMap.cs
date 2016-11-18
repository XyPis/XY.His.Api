using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwInDoctorAdviceMap : EntityTypeConfiguration<VwInDoctorAdvice>
    {
        public VwInDoctorAdviceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.DoctorId, t.HospId, t.PatientName, t.SexName, t.GroupNum, t.ItemId, t.Dosage, t.IsAttach, t.IsSelf, t.LsSpecialUsage, t.LsExecLoc, t.OperID, t.IsEnd, t.AdviceType, t.InPatNo, t.LsMarkType, t.PatTypeId, t.Memo });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DoctorId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DoctorName)
                .HasMaxLength(40);

            this.Property(t => t.LocationName)
                .HasMaxLength(30);

            this.Property(t => t.HospId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PatientName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.BedName)
                .HasMaxLength(10);

            this.Property(t => t.SexName)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.GroupNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.Spec)
                .HasMaxLength(50);

            this.Property(t => t.Dosage)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitTakeName)
                .HasMaxLength(50);

            this.Property(t => t.FrequencyName)
                .HasMaxLength(50);

            this.Property(t => t.UsageName)
                .HasMaxLength(50);

            this.Property(t => t.UnitInName)
                .HasMaxLength(50);

            this.Property(t => t.IsAttach)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IsSelf)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsSpecialUsage)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsExecLoc)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OperID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IsEnd)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AdviceType)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.InPatNo)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.LsMarkType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PatTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.ChkOperTime)
                .HasMaxLength(10);

            this.Property(t => t.AuthOperTime)
                .HasMaxLength(30);

            this.Property(t => t.ChkOperName)
                .HasMaxLength(30);

            this.Property(t => t.AuthOperName)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("VwInDoctorAdvice");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.AdviceTime).HasColumnName("AdviceTime");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.DoctorName).HasColumnName("DoctorName");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.BedId).HasColumnName("BedId");
            this.Property(t => t.BedName).HasColumnName("BedName");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.SexName).HasColumnName("SexName");
            this.Property(t => t.GroupNum).HasColumnName("GroupNum");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.Dosage).HasColumnName("Dosage");
            this.Property(t => t.UnitTakeId).HasColumnName("UnitTakeId");
            this.Property(t => t.UnitTakeName).HasColumnName("UnitTakeName");
            this.Property(t => t.FrequencyId).HasColumnName("FrequencyId");
            this.Property(t => t.FrequencyName).HasColumnName("FrequencyName");
            this.Property(t => t.UsageId).HasColumnName("UsageId");
            this.Property(t => t.UsageName).HasColumnName("UsageName");
            this.Property(t => t.PriceIn).HasColumnName("PriceIn");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.UnitInId).HasColumnName("UnitInId");
            this.Property(t => t.UnitInName).HasColumnName("UnitInName");
            this.Property(t => t.IsAttach).HasColumnName("IsAttach");
            this.Property(t => t.IsSelf).HasColumnName("IsSelf");
            this.Property(t => t.LsSpecialUsage).HasColumnName("LsSpecialUsage");
            this.Property(t => t.LsExecLoc).HasColumnName("LsExecLoc");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.IsEnd).HasColumnName("IsEnd");
            this.Property(t => t.IsOtherFee).HasColumnName("IsOtherFee");
            this.Property(t => t.LsRpType).HasColumnName("LsRpType");
            this.Property(t => t.AdviceType).HasColumnName("AdviceType");
            this.Property(t => t.InPatNo).HasColumnName("InPatNo");
            this.Property(t => t.LsMarkType).HasColumnName("LsMarkType");
            this.Property(t => t.PatTypeId).HasColumnName("PatTypeId");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.ChkOperTime).HasColumnName("ChkOperTime");
            this.Property(t => t.AuthOperTime).HasColumnName("AuthOperTime");
            this.Property(t => t.ChkOperName).HasColumnName("ChkOperName");
            this.Property(t => t.AuthOperName).HasColumnName("AuthOperName");
            this.Property(t => t.FeeZyId).HasColumnName("FeeZyId");
            this.Property(t => t.ExecLocId).HasColumnName("ExecLocId");
            this.Property(t => t.IsAuth).HasColumnName("IsAuth");
        }
    }
}
