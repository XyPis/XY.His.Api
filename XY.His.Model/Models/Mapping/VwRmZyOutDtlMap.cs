using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwRmZyOutDtlMap : EntityTypeConfiguration<VwRmZyOutDtl>
    {
        public VwRmZyOutDtlMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.HospNo, t.PatientName, t.NTime, t.GroupNum, t.Dosage, t.LsMarkType, t.HospId, t.RequestId, t.ItemId, t.UnitReq, t.IsConfirm, t.IsIssued, t.IsPrint, t.AdviceId, t.ForDate, t.ListNum, t.RoomId, t.LocationId, t.UserName });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BedName)
                .HasMaxLength(10);

            this.Property(t => t.HospNo)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.PatientName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.NTime)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GroupNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Code)
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.Spec)
                .HasMaxLength(50);

            this.Property(t => t.Dosage)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsMarkType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HospId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RequestId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitReq)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AdviceId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ListNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RoomId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LocationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("VwRmZyOutDtl");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BedName).HasColumnName("BedName");
            this.Property(t => t.HospNo).HasColumnName("HospNo");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.NTime).HasColumnName("NTime");
            this.Property(t => t.GroupNum).HasColumnName("GroupNum");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.Dosage).HasColumnName("Dosage");
            this.Property(t => t.LsMarkType).HasColumnName("LsMarkType");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.PriceIn).HasColumnName("PriceIn");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.RequestId).HasColumnName("RequestId");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.UnitReq).HasColumnName("UnitReq");
            this.Property(t => t.UsageId).HasColumnName("UsageId");
            this.Property(t => t.FrequencyId).HasColumnName("FrequencyId");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.SpecialityId).HasColumnName("SpecialityId");
            this.Property(t => t.ConfirmOperTime).HasColumnName("ConfirmOperTime");
            this.Property(t => t.ConfirmOperId).HasColumnName("ConfirmOperId");
            this.Property(t => t.IsConfirm).HasColumnName("IsConfirm");
            this.Property(t => t.IsIssued).HasColumnName("IsIssued");
            this.Property(t => t.IsPrint).HasColumnName("IsPrint");
            this.Property(t => t.UnitTake).HasColumnName("UnitTake");
            this.Property(t => t.AdviceId).HasColumnName("AdviceId");
            this.Property(t => t.ForDate).HasColumnName("ForDate");
            this.Property(t => t.ListNum).HasColumnName("ListNum");
            this.Property(t => t.RoomId).HasColumnName("RoomId");
            this.Property(t => t.PatLocationId).HasColumnName("PatLocationId");
            this.Property(t => t.IsInject).HasColumnName("IsInject");
            this.Property(t => t.IsReject).HasColumnName("IsReject");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.IsBack).HasColumnName("IsBack");
        }
    }
}
