using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Domain.BS.Mapping
{
    public class BsUsageMap : EntityTypeConfiguration<BsUsage>
    {
        public BsUsageMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PrintName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.WbCode)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.PyCode)
                .IsRequired()
                .HasMaxLength(6);

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

            // Table & Column Mappings
            this.ToTable("BsUsage");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.PrintName).HasColumnName("PrintName");
            this.Property(t => t.WbCode).HasColumnName("WbCode");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.LsUseArea).HasColumnName("LsUseArea");
            this.Property(t => t.LsPrnFormType).HasColumnName("LsPrnFormType");
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
            this.Property(t => t.IsMzDrop).HasColumnName("IsMzDrop");
            this.Property(t => t.IsMzReject).HasColumnName("IsMzReject");
            this.Property(t => t.IsMzCure).HasColumnName("IsMzCure");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");
            this.Property(t => t.IsPrintAtomization).HasColumnName("IsPrintAtomization");
            this.Property(t => t.F5).HasColumnName("F5");
            this.Property(t => t.F6).HasColumnName("F6");
            this.Property(t => t.F7).HasColumnName("F7");
            this.Property(t => t.LsInOutType).HasColumnName("LsInOutType");
            this.Property(t => t.IsDrugTwoDay).HasColumnName("IsDrugTwoDay");
        }
    }
}
