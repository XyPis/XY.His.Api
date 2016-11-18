using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwInDepositMap : EntityTypeConfiguration<VwInDeposit>
    {
        public VwInDepositMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.BillNo, t.OperTime, t.OperID, t.Amount, t.Remain, t.IsFirst, t.Remark, t.IsCancel, t.IsFall, t.HospId, t.InPatNo, t.PatientName, t.SexName, t.PatTypeId, t.NTime, t.LocIn, t.LsInStatus, t.CardNo });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BillNo)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.OperID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Amount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Remain)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Remark)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LsCancelTypeName)
                .HasMaxLength(4);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.IsFall)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.HospId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InPatNo)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.PatientName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.SexName)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.Age)
                .HasMaxLength(40);

            this.Property(t => t.PatTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PatTypeName)
                .HasMaxLength(50);

            this.Property(t => t.BedName)
                .HasMaxLength(10);

            this.Property(t => t.NTime)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LocationName)
                .HasMaxLength(30);

            this.Property(t => t.DoctorName)
                .HasMaxLength(40);

            this.Property(t => t.LocIn)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LocInName)
                .HasMaxLength(30);

            this.Property(t => t.LsInStatus)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsInStatusName)
                .HasMaxLength(8);

            this.Property(t => t.CardNo)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.OperName)
                .HasMaxLength(30);

            this.Property(t => t.CancelOperName)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("VwInDeposit");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BillNo).HasColumnName("BillNo");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.Remain).HasColumnName("Remain");
            this.Property(t => t.IsFirst).HasColumnName("IsFirst");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");
            this.Property(t => t.LsCancelType).HasColumnName("LsCancelType");
            this.Property(t => t.IsHangCancel).HasColumnName("IsHangCancel");
            this.Property(t => t.LsCancelTypeName).HasColumnName("LsCancelTypeName");
            this.Property(t => t.CancelOperTime).HasColumnName("CancelOperTime");
            this.Property(t => t.CancelOperId).HasColumnName("CancelOperId");
            this.Property(t => t.InvoId).HasColumnName("InvoId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.IsFall).HasColumnName("IsFall");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.InPatNo).HasColumnName("InPatNo");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.SexName).HasColumnName("SexName");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.PatTypeId).HasColumnName("PatTypeId");
            this.Property(t => t.PatTypeName).HasColumnName("PatTypeName");
            this.Property(t => t.BedName).HasColumnName("BedName");
            this.Property(t => t.NTime).HasColumnName("NTime");
            this.Property(t => t.InDays).HasColumnName("InDays");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.DoctorName).HasColumnName("DoctorName");
            this.Property(t => t.LocIn).HasColumnName("LocIn");
            this.Property(t => t.LocInName).HasColumnName("LocInName");
            this.Property(t => t.LsInStatus).HasColumnName("LsInStatus");
            this.Property(t => t.LsInStatusName).HasColumnName("LsInStatusName");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.OperName).HasColumnName("OperName");
            this.Property(t => t.CancelOperName).HasColumnName("CancelOperName");
        }
    }
}
