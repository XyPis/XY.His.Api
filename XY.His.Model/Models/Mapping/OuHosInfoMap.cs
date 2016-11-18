using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class OuHosInfoMap : EntityTypeConfiguration<OuHosInfo>
    {
        public OuHosInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.MzRegNo)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.CardNo)
                .HasMaxLength(19);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.MedicareNo)
                .HasMaxLength(18);

            this.Property(t => t.RoomNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CancelMemo)
                .HasMaxLength(100);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.RegDate)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.AgeString)
                .HasMaxLength(50);

            this.Property(t => t.ContactPhone)
                .HasMaxLength(150);

            this.Property(t => t.LinkmanName)
                .HasMaxLength(150);

            this.Property(t => t.F5)
                .HasMaxLength(100);

            this.Property(t => t.F6)
                .HasMaxLength(1000);

            this.Property(t => t.F7)
                .HasMaxLength(100);

            this.Property(t => t.F8)
                .HasMaxLength(100);

            this.Property(t => t.GoodRecipe)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OuHosInfo");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.MzRegNo).HasColumnName("MzRegNo");
            this.Property(t => t.RegTime).HasColumnName("RegTime");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.IsBaby).HasColumnName("IsBaby");
            this.Property(t => t.AgeDay).HasColumnName("AgeDay");
            this.Property(t => t.Height).HasColumnName("Height");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.PatTypeId).HasColumnName("PatTypeId");
            this.Property(t => t.MedicareNo).HasColumnName("MedicareNo");
            this.Property(t => t.RegTypeId).HasColumnName("RegTypeId");
            this.Property(t => t.IsPriority).HasColumnName("IsPriority");
            this.Property(t => t.IsElder).HasColumnName("IsElder");
            this.Property(t => t.LineOrder).HasColumnName("LineOrder");
            this.Property(t => t.RegFee).HasColumnName("RegFee");
            this.Property(t => t.ZyFee).HasColumnName("ZyFee");
            this.Property(t => t.DiagnoFee).HasColumnName("DiagnoFee");
            this.Property(t => t.OtherFee1).HasColumnName("OtherFee1");
            this.Property(t => t.OtherFee2).HasColumnName("OtherFee2");
            this.Property(t => t.PaySel).HasColumnName("PaySel");
            this.Property(t => t.TallyDiag).HasColumnName("TallyDiag");
            this.Property(t => t.FactGet).HasColumnName("FactGet");
            this.Property(t => t.RegDept).HasColumnName("RegDept");
            this.Property(t => t.DiagnDept).HasColumnName("DiagnDept");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.RoomNo).HasColumnName("RoomNo");
            this.Property(t => t.IsFreeDiag).HasColumnName("IsFreeDiag");
            this.Property(t => t.IsFreeReg).HasColumnName("IsFreeReg");
            this.Property(t => t.IsInPatient).HasColumnName("IsInPatient");
            this.Property(t => t.IsPreReg).HasColumnName("IsPreReg");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");
            this.Property(t => t.CancelTime).HasColumnName("CancelTime");
            this.Property(t => t.CancelOperId).HasColumnName("CancelOperId");
            this.Property(t => t.CancelMemo).HasColumnName("CancelMemo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.TimeSpanId).HasColumnName("TimeSpanId");
            this.Property(t => t.RegDate).HasColumnName("RegDate");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.AgeString).HasColumnName("AgeString");
            this.Property(t => t.ContactPhone).HasColumnName("ContactPhone");
            this.Property(t => t.LinkmanName).HasColumnName("LinkmanName");
            this.Property(t => t.TallyTime).HasColumnName("TallyTime");
            this.Property(t => t.CancelTallyTime).HasColumnName("CancelTallyTime");
            this.Property(t => t.F5).HasColumnName("F5");
            this.Property(t => t.F6).HasColumnName("F6");
            this.Property(t => t.F7).HasColumnName("F7");
            this.Property(t => t.F8).HasColumnName("F8");
            this.Property(t => t.TimeSpanSubId).HasColumnName("TimeSpanSubId");
            this.Property(t => t.DiagRoomId).HasColumnName("DiagRoomId");
            this.Property(t => t.CallDoctorId).HasColumnName("CallDoctorId");
            this.Property(t => t.CallOrder).HasColumnName("CallOrder");
            this.Property(t => t.IsFirstCheck).HasColumnName("IsFirstCheck");
            this.Property(t => t.IsGoodRecipe).HasColumnName("IsGoodRecipe");
            this.Property(t => t.GoodRecipe).HasColumnName("GoodRecipe");

            // Relationships
            this.HasOptional(t => t.BsDoctor)
                .WithMany(t => t.OuHosInfoes)
                .HasForeignKey(d => d.DoctorId);
            this.HasRequired(t => t.BsLocation)
                .WithMany(t => t.OuHosInfoes)
                .HasForeignKey(d => d.RegDept);
            this.HasOptional(t => t.BsLocation1)
                .WithMany(t => t.OuHosInfoes1)
                .HasForeignKey(d => d.DiagnDept);
            this.HasRequired(t => t.BsPatient)
                .WithMany(t => t.OuHosInfoes)
                .HasForeignKey(d => d.PatId);
            this.HasRequired(t => t.BsPatType)
                .WithMany(t => t.OuHosInfoes)
                .HasForeignKey(d => d.PatTypeId);
            this.HasOptional(t => t.BsRegSpanSub)
                .WithMany(t => t.OuHosInfoes)
                .HasForeignKey(d => d.TimeSpanSubId);
            this.HasOptional(t => t.BsRegTimeSpan)
                .WithMany(t => t.OuHosInfoes)
                .HasForeignKey(d => d.TimeSpanId);
            this.HasRequired(t => t.BsRegType)
                .WithMany(t => t.OuHosInfoes)
                .HasForeignKey(d => d.RegTypeId);

        }
    }
}
