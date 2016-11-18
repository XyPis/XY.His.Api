using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VW_InChinRicipeSendMap : EntityTypeConfiguration<VW_InChinRicipeSend>
    {
        public VW_InChinRicipeSendMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.RecipeId, t.ItemCode, t.ItemName, t.Spec, t.Dosage, t.UnitTakeId, t.ItemId, t.LsDecoctWay, t.Memo, t.OperId, t.OperTime, t.DoctorId, t.PriceIn, t.HospNo, t.Sex, t.DrugNum, t.DecoctNum, t.RecipeNo, t.PatTypeName, t.PhoneHome, t.AddressHome, t.IllDesc, t.LsCookSelf, t.PatientName, t.HospId, t.LocationId, t.IsConfirm, t.IsBack, t.RicipeMemo });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RecipeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemCode)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ItemName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Spec)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Dosage)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitTakeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsDecoctWay)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.OperId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DoctorId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PriceIn)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HospNo)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Sex)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.DrugNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DecoctNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RecipeNo)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.PatTypeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PhoneHome)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.AddressHome)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.IllDesc)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.LsCookSelf)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BedName)
                .HasMaxLength(10);

            this.Property(t => t.PatientName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.HospId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LocationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RicipeMemo)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("VW_InChinRicipeSend");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RecipeId).HasColumnName("RecipeId");
            this.Property(t => t.ItemCode).HasColumnName("ItemCode");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.Dosage).HasColumnName("Dosage");
            this.Property(t => t.UnitTakeId).HasColumnName("UnitTakeId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.LsDecoctWay).HasColumnName("LsDecoctWay");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.PriceIn).HasColumnName("PriceIn");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.HospNo).HasColumnName("HospNo");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.DrugNum).HasColumnName("DrugNum");
            this.Property(t => t.DecoctNum).HasColumnName("DecoctNum");
            this.Property(t => t.RecipeNo).HasColumnName("RecipeNo");
            this.Property(t => t.PatTypeName).HasColumnName("PatTypeName");
            this.Property(t => t.PhoneHome).HasColumnName("PhoneHome");
            this.Property(t => t.AddressHome).HasColumnName("AddressHome");
            this.Property(t => t.IllDesc).HasColumnName("IllDesc");
            this.Property(t => t.LsCookSelf).HasColumnName("LsCookSelf");
            this.Property(t => t.BedName).HasColumnName("BedName");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.IsConfirm).HasColumnName("IsConfirm");
            this.Property(t => t.IsBack).HasColumnName("IsBack");
            this.Property(t => t.RicipeMemo).HasColumnName("RicipeMemo");
            this.Property(t => t.ConfirmOperTime).HasColumnName("ConfirmOperTime");
        }
    }
}
