using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class DhOuRecipeDtlMap : EntityTypeConfiguration<DhOuRecipeDtl>
    {
        public DhOuRecipeDtlMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemCode)
                .HasMaxLength(50);

            this.Property(t => t.ItemName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.DrugName)
                .HasMaxLength(100);

            this.Property(t => t.Spec)
                .HasMaxLength(50);

            this.Property(t => t.FormName)
                .HasMaxLength(50);

            this.Property(t => t.SkinTest)
                .HasMaxLength(20);

            this.Property(t => t.Memo)
                .HasMaxLength(500);

            this.Property(t => t.OperName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AuthName)
                .HasMaxLength(50);

            this.Property(t => t.ExecOperName)
                .HasMaxLength(50);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("DhOuRecipeDtl");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RecipeId).HasColumnName("RecipeId");
            this.Property(t => t.ListNum).HasColumnName("ListNum");
            this.Property(t => t.ItemCode).HasColumnName("ItemCode");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.GroupNum).HasColumnName("GroupNum");
            this.Property(t => t.DrugName).HasColumnName("DrugName");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.FormName).HasColumnName("FormName");
            this.Property(t => t.PriceIn).HasColumnName("PriceIn");
            this.Property(t => t.Dosage).HasColumnName("Dosage");
            this.Property(t => t.UnitTakeId).HasColumnName("UnitTakeId");
            this.Property(t => t.FrequencyId).HasColumnName("FrequencyId");
            this.Property(t => t.UsageId).HasColumnName("UsageId");
            this.Property(t => t.Days).HasColumnName("Days");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.UnitDiagId).HasColumnName("UnitDiagId");
            this.Property(t => t.IsAttach).HasColumnName("IsAttach");
            this.Property(t => t.IsSelf).HasColumnName("IsSelf");
            this.Property(t => t.IsSkin).HasColumnName("IsSkin");
            this.Property(t => t.SkinTime).HasColumnName("SkinTime");
            this.Property(t => t.SkinTest).HasColumnName("SkinTest");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperName).HasColumnName("OperName");
            this.Property(t => t.AuthTime).HasColumnName("AuthTime");
            this.Property(t => t.AuthName).HasColumnName("AuthName");
            this.Property(t => t.IsExec).HasColumnName("IsExec");
            this.Property(t => t.ExecTime).HasColumnName("ExecTime");
            this.Property(t => t.ExecOperName).HasColumnName("ExecOperName");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
        }
    }
}
