using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwInExecuteLateMap : EntityTypeConfiguration<VwInExecuteLate>
    {
        public VwInExecuteLateMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.AdviceId, t.LsMarkType, t.LocationId, t.IsPrint, t.SexName, t.Age, t.OperTime, t.Memo });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AdviceId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsMarkType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LocationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HospNo)
                .HasMaxLength(13);

            this.Property(t => t.PatientName)
                .HasMaxLength(30);

            this.Property(t => t.SexName)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.Age)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Code)
                .HasMaxLength(20);

            this.Property(t => t.ItemName)
                .HasMaxLength(50);

            this.Property(t => t.Spec)
                .HasMaxLength(50);

            this.Property(t => t.LoactionName)
                .HasMaxLength(30);

            this.Property(t => t.BedName)
                .HasMaxLength(10);

            this.Property(t => t.UnitTakeName)
                .HasMaxLength(50);

            this.Property(t => t.UsageName)
                .HasMaxLength(50);

            this.Property(t => t.FrequencyName)
                .HasMaxLength(50);

            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("VwInExecuteLate");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.AdviceTime).HasColumnName("AdviceTime");
            this.Property(t => t.AdviceId).HasColumnName("AdviceId");
            this.Property(t => t.LsMarkType).HasColumnName("LsMarkType");
            this.Property(t => t.UnitTakeId).HasColumnName("UnitTakeId");
            this.Property(t => t.GroupNum).HasColumnName("GroupNum");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.IsPrint).HasColumnName("IsPrint");
            this.Property(t => t.FrequencyId).HasColumnName("FrequencyId");
            this.Property(t => t.LsExecLoc).HasColumnName("LsExecLoc");
            this.Property(t => t.ExecLocId).HasColumnName("ExecLocId");
            this.Property(t => t.HospNo).HasColumnName("HospNo");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.LocIn).HasColumnName("LocIn");
            this.Property(t => t.SexName).HasColumnName("SexName");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.PriceIn).HasColumnName("PriceIn");
            this.Property(t => t.LoactionName).HasColumnName("LoactionName");
            this.Property(t => t.BedName).HasColumnName("BedName");
            this.Property(t => t.UnitTakeName).HasColumnName("UnitTakeName");
            this.Property(t => t.UsageName).HasColumnName("UsageName");
            this.Property(t => t.FrequencyName).HasColumnName("FrequencyName");
            this.Property(t => t.IsPoison).HasColumnName("IsPoison");
            this.Property(t => t.Times).HasColumnName("Times");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.Dosage).HasColumnName("Dosage");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.BedId).HasColumnName("BedId");
            this.Property(t => t.IsPrintLabel).HasColumnName("IsPrintLabel");
            this.Property(t => t.IsPrintReject).HasColumnName("IsPrintReject");
            this.Property(t => t.IsPrintDrug).HasColumnName("IsPrintDrug");
            this.Property(t => t.IsPrintAst).HasColumnName("IsPrintAst");
            this.Property(t => t.IsPrintCure).HasColumnName("IsPrintCure");
            this.Property(t => t.IsPrintNurse).HasColumnName("IsPrintNurse");
            this.Property(t => t.IsPrintExternal).HasColumnName("IsPrintExternal");
            this.Property(t => t.IsPrintPush).HasColumnName("IsPrintPush");
            this.Property(t => t.IsPrintRejSkin).HasColumnName("IsPrintRejSkin");
            this.Property(t => t.IsPrintDietetic).HasColumnName("IsPrintDietetic");
            this.Property(t => t.IsPrintBlood).HasColumnName("IsPrintBlood");
            this.Property(t => t.IsSelected).HasColumnName("IsSelected");
            this.Property(t => t.IsExecuted).HasColumnName("IsExecuted");
            this.Property(t => t.ExecutedTime).HasColumnName("ExecutedTime");
            this.Property(t => t.ExecutedOperId).HasColumnName("ExecutedOperId");
        }
    }
}
