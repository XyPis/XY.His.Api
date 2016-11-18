using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class OuRecipeTempMap : EntityTypeConfiguration<OuRecipeTemp>
    {
        public OuRecipeTempMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.MzRegNo)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.AddressHome)
                .HasMaxLength(100);

            this.Property(t => t.IllDesc)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Name)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.RecipeNum)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Memo)
                .HasMaxLength(100);

            this.Property(t => t.CardNo)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.ContactPhone)
                .HasMaxLength(100);

            this.Property(t => t.PyCode1)
                .HasMaxLength(1);

            this.Property(t => t.WbCode1)
                .HasMaxLength(1);

            this.Property(t => t.PyCode2)
                .HasMaxLength(1);

            this.Property(t => t.WbCode2)
                .HasMaxLength(1);

            this.Property(t => t.PyCode3)
                .HasMaxLength(1);

            this.Property(t => t.WbCode3)
                .HasMaxLength(1);

            this.Property(t => t.DoctorName)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.LocationName)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.RoomWindowName)
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

            // Table & Column Mappings
            this.ToTable("OuRecipeTemp");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RecipeId).HasColumnName("RecipeId");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.MzRegNo).HasColumnName("MzRegNo");
            this.Property(t => t.RegTime).HasColumnName("RegTime");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.BabyMonth).HasColumnName("BabyMonth");
            this.Property(t => t.AddressHome).HasColumnName("AddressHome");
            this.Property(t => t.IllDesc).HasColumnName("IllDesc");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.LsRepType).HasColumnName("LsRepType");
            this.Property(t => t.RecipeNum).HasColumnName("RecipeNum");
            this.Property(t => t.RecipeTime).HasColumnName("RecipeTime");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.HowMany).HasColumnName("HowMany");
            this.Property(t => t.IsPriority).HasColumnName("IsPriority");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.IsPend).HasColumnName("IsPend");
            this.Property(t => t.IsExecuted).HasColumnName("IsExecuted");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.ContactPhone).HasColumnName("ContactPhone");
            this.Property(t => t.PyCode1).HasColumnName("PyCode1");
            this.Property(t => t.WbCode1).HasColumnName("WbCode1");
            this.Property(t => t.PyCode2).HasColumnName("PyCode2");
            this.Property(t => t.WbCode2).HasColumnName("WbCode2");
            this.Property(t => t.PyCode3).HasColumnName("PyCode3");
            this.Property(t => t.WbCode3).HasColumnName("WbCode3");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.DoctorName).HasColumnName("DoctorName");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.HospitalId).HasColumnName("HospitalId");
            this.Property(t => t.RoomId).HasColumnName("RoomId");
            this.Property(t => t.IsIssue).HasColumnName("IsIssue");
            this.Property(t => t.IsBack).HasColumnName("IsBack");
            this.Property(t => t.RoomWindowName).HasColumnName("RoomWindowName");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.LsReportType).HasColumnName("LsReportType");
            this.Property(t => t.DosageOperId).HasColumnName("DosageOperId");
            this.Property(t => t.DosageTime).HasColumnName("DosageTime");
            this.Property(t => t.F5).HasColumnName("F5");
            this.Property(t => t.F6).HasColumnName("F6");
            this.Property(t => t.F7).HasColumnName("F7");
            this.Property(t => t.F8).HasColumnName("F8");
        }
    }
}
