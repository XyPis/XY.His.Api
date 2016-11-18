using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsCompanyMap : EntityTypeConfiguration<BsCompany>
    {
        public BsCompanyMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.CODE)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CompAddre)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.CompCorpo)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.CompPhone)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.Bank)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.BankAccount)
                .IsRequired()
                .HasMaxLength(16);

            this.Property(t => t.PyCode)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.WbCode)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BsCompany");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CODE).HasColumnName("CODE");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.CompAddre).HasColumnName("CompAddre");
            this.Property(t => t.CompCorpo).HasColumnName("CompCorpo");
            this.Property(t => t.CompPhone).HasColumnName("CompPhone");
            this.Property(t => t.Bank).HasColumnName("Bank");
            this.Property(t => t.BankAccount).HasColumnName("BankAccount");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.WbCode).HasColumnName("WbCode");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");
        }
    }
}
