using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class his_eng_order_diagnoseMap : EntityTypeConfiguration<his_eng_order_diagnose>
    {
        public his_eng_order_diagnoseMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.order_id, t.Name, t.Type, t.dscharge_type, t.icde10 });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.order_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Date)
                .HasMaxLength(100);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.dscharge_type)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.icde10)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("his_eng_order_diagnose");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.order_id).HasColumnName("order_id");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.dscharge_type).HasColumnName("dscharge_type");
            this.Property(t => t.icde10).HasColumnName("icde10");
        }
    }
}
