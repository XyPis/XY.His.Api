using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class GblTraceMap : EntityTypeConfiguration<GblTrace>
    {
        public GblTraceMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.SqlString)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.WhereCondition)
                .IsRequired()
                .HasMaxLength(600);

            this.Property(t => t.OrderByExpression)
                .IsRequired()
                .HasMaxLength(600);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("GblTrace");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SqlString).HasColumnName("SqlString");
            this.Property(t => t.WhereCondition).HasColumnName("WhereCondition");
            this.Property(t => t.OrderByExpression).HasColumnName("OrderByExpression");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
        }
    }
}
