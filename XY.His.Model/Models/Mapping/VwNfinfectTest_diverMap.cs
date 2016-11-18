using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwNfinfectTest_diverMap : EntityTypeConfiguration<VwNfinfectTest_diver>
    {
        public VwNfinfectTest_diverMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.HospId, t.Code, t.InfectTime, t.OperTime, t.OperID });

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(30);

            this.Property(t => t.SexName)
                .HasMaxLength(4);

            this.Property(t => t.Company)
                .HasMaxLength(100);

            this.Property(t => t.WorkType)
                .HasMaxLength(50);

            this.Property(t => t.PatType)
                .HasMaxLength(50);

            this.Property(t => t.Bed)
                .HasMaxLength(10);

            this.Property(t => t.Residence)
                .HasMaxLength(50);

            this.Property(t => t.LsInStatusName)
                .HasMaxLength(8);

            this.Property(t => t.LabNo)
                .HasMaxLength(50);

            this.Property(t => t.LsResultName)
                .HasMaxLength(6);

            this.Property(t => t.Bacteria)
                .HasMaxLength(50);

            this.Property(t => t.BaseDrugTest)
                .HasMaxLength(50);

            this.Property(t => t.LabSource)
                .HasMaxLength(50);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HospId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsInfectTypeName)
                .HasMaxLength(10);

            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.LsEffectName)
                .HasMaxLength(4);

            this.Property(t => t.LsCutTypeName)
                .HasMaxLength(6);

            this.Property(t => t.Position)
                .HasMaxLength(50);

            this.Property(t => t.Location)
                .HasMaxLength(30);

            this.Property(t => t.Speciality)
                .HasMaxLength(50);

            this.Property(t => t.LsInfluenceName)
                .HasMaxLength(8);

            this.Property(t => t.BsOPSName)
                .HasMaxLength(50);

            this.Property(t => t.LsClassName)
                .HasMaxLength(9);

            this.Property(t => t.LsASAName)
                .HasMaxLength(5);

            this.Property(t => t.AnaesName)
                .HasMaxLength(50);

            this.Property(t => t.LsInfectRangeName)
                .HasMaxLength(8);

            this.Property(t => t.LsUseTypeName)
                .HasMaxLength(4);

            this.Property(t => t.LsUnionDrugName)
                .HasMaxLength(14);

            this.Property(t => t.LsUsePurposeName)
                .HasMaxLength(9);

            this.Property(t => t.PositionSystem)
                .HasMaxLength(50);

            this.Property(t => t.OperID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OpDoctor)
                .HasMaxLength(40);

            this.Property(t => t.BacteriaGrams)
                .HasMaxLength(20);

            this.Property(t => t.BacteriaShu)
                .HasMaxLength(30);

            this.Property(t => t.BacteriaType)
                .HasMaxLength(20);

            this.Property(t => t.BacteriaStandType)
                .HasMaxLength(20);

            this.Property(t => t.InPatNo)
                .HasMaxLength(13);

            // Table & Column Mappings
            this.ToTable("VwNfinfectTest_diver");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.SexName).HasColumnName("SexName");
            this.Property(t => t.InTime).HasColumnName("InTime");
            this.Property(t => t.OutTime).HasColumnName("OutTime");
            this.Property(t => t.Company).HasColumnName("Company");
            this.Property(t => t.WorkType).HasColumnName("WorkType");
            this.Property(t => t.PatType).HasColumnName("PatType");
            this.Property(t => t.Bed).HasColumnName("Bed");
            this.Property(t => t.Residence).HasColumnName("Residence");
            this.Property(t => t.LsInStatusName).HasColumnName("LsInStatusName");
            this.Property(t => t.LabNo).HasColumnName("LabNo");
            this.Property(t => t.LsResultName).HasColumnName("LsResultName");
            this.Property(t => t.LabTime).HasColumnName("LabTime");
            this.Property(t => t.Bacteria).HasColumnName("Bacteria");
            this.Property(t => t.BaseDrugTest).HasColumnName("BaseDrugTest");
            this.Property(t => t.LabSource).HasColumnName("LabSource");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.LsInfectTypeName).HasColumnName("LsInfectTypeName");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.LsEffectName).HasColumnName("LsEffectName");
            this.Property(t => t.LsCutTypeName).HasColumnName("LsCutTypeName");
            this.Property(t => t.InfectTime).HasColumnName("InfectTime");
            this.Property(t => t.Position).HasColumnName("Position");
            this.Property(t => t.Location).HasColumnName("Location");
            this.Property(t => t.Speciality).HasColumnName("Speciality");
            this.Property(t => t.LsInfluenceName).HasColumnName("LsInfluenceName");
            this.Property(t => t.OPSId).HasColumnName("OPSId");
            this.Property(t => t.BsOPSName).HasColumnName("BsOPSName");
            this.Property(t => t.OPSTime).HasColumnName("OPSTime");
            this.Property(t => t.LsClassName).HasColumnName("LsClassName");
            this.Property(t => t.LsASAName).HasColumnName("LsASAName");
            this.Property(t => t.IsEmergency).HasColumnName("IsEmergency");
            this.Property(t => t.AnaesId).HasColumnName("AnaesId");
            this.Property(t => t.AnaesName).HasColumnName("AnaesName");
            this.Property(t => t.Minutes).HasColumnName("Minutes");
            this.Property(t => t.IsImplant).HasColumnName("IsImplant");
            this.Property(t => t.IsImglass).HasColumnName("IsImglass");
            this.Property(t => t.IsOPSDrug).HasColumnName("IsOPSDrug");
            this.Property(t => t.IsUseDrug).HasColumnName("IsUseDrug");
            this.Property(t => t.LsInfectRangeName).HasColumnName("LsInfectRangeName");
            this.Property(t => t.LsUseTypeName).HasColumnName("LsUseTypeName");
            this.Property(t => t.LsUnionDrugName).HasColumnName("LsUnionDrugName");
            this.Property(t => t.LsUsePurposeName).HasColumnName("LsUsePurposeName");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.PositionSystem).HasColumnName("PositionSystem");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.OpDoctor).HasColumnName("OpDoctor");
            this.Property(t => t.BacteriaGrams).HasColumnName("BacteriaGrams");
            this.Property(t => t.BacteriaShu).HasColumnName("BacteriaShu");
            this.Property(t => t.BacteriaType).HasColumnName("BacteriaType");
            this.Property(t => t.BacteriaStandType).HasColumnName("BacteriaStandType");
            this.Property(t => t.InPatNo).HasColumnName("InPatNo");
        }
    }
}
