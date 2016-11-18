using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwOuInvoiceInvItemSumMap : EntityTypeConfiguration<VwOuInvoiceInvItemSum>
    {
        public VwOuInvoiceInvItemSumMap()
        {
            // Primary Key
            this.HasKey(t => new { t.日期, t.费别, t.金额, t.科室, t.ID, t.Expr1 });

            // Properties
            this.Property(t => t.费别)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.金额)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.科室)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.医生)
                .HasMaxLength(40);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Expr1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VwOuInvoiceInvItemSum");
            this.Property(t => t.日期).HasColumnName("日期");
            this.Property(t => t.费别).HasColumnName("费别");
            this.Property(t => t.金额).HasColumnName("金额");
            this.Property(t => t.科室).HasColumnName("科室");
            this.Property(t => t.医生).HasColumnName("医生");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Expr1).HasColumnName("Expr1");
        }
    }
}
