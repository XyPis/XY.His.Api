using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class DhOuRecipeMap : EntityTypeConfiguration<DhOuRecipe>
    {
        public DhOuRecipeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.MzRegNo)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.CardNo)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.Illness)
                .HasMaxLength(500);

            this.Property(t => t.MedicareNo)
                .HasMaxLength(50);

            this.Property(t => t.PatTypeName)
                .HasMaxLength(100);

            this.Property(t => t.RegTypeName)
                .HasMaxLength(100);

            this.Property(t => t.DiagnDeptName)
                .HasMaxLength(100);

            this.Property(t => t.DoctorName)
                .HasMaxLength(100);

            this.Property(t => t.DoctorCode)
                .HasMaxLength(50);

            this.Property(t => t.DocLevel)
                .HasMaxLength(50);

            this.Property(t => t.RoomNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RecipeNum)
                .HasMaxLength(20);

            this.Property(t => t.Memo)
                .HasMaxLength(200);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.IcdCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DhOuRecipe");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospitalId).HasColumnName("HospitalId");
            this.Property(t => t.RecId).HasColumnName("RecId");
            this.Property(t => t.MzRegNo).HasColumnName("MzRegNo");
            this.Property(t => t.RegTime).HasColumnName("RegTime");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.Illness).HasColumnName("Illness");
            this.Property(t => t.MedicareNo).HasColumnName("MedicareNo");
            this.Property(t => t.PatTypeName).HasColumnName("PatTypeName");
            this.Property(t => t.RegTypeName).HasColumnName("RegTypeName");
            this.Property(t => t.DiagnDeptName).HasColumnName("DiagnDeptName");
            this.Property(t => t.DoctorName).HasColumnName("DoctorName");
            this.Property(t => t.DoctorCode).HasColumnName("DoctorCode");
            this.Property(t => t.DocLevel).HasColumnName("DocLevel");
            this.Property(t => t.RoomNo).HasColumnName("RoomNo");
            this.Property(t => t.LsRepType).HasColumnName("LsRepType");
            this.Property(t => t.RecipeNum).HasColumnName("RecipeNum");
            this.Property(t => t.RecipeTime).HasColumnName("RecipeTime");
            this.Property(t => t.HowMany).HasColumnName("HowMany");
            this.Property(t => t.IsPriority).HasColumnName("IsPriority");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IcdCode).HasColumnName("IcdCode");
        }
    }
}
