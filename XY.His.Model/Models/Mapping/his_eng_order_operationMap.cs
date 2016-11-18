using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class his_eng_order_operationMap : EntityTypeConfiguration<his_eng_order_operation>
    {
        public his_eng_order_operationMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.name, t.start_time, t.end_time, t.incision_type, t.Inplant });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.code)
                .HasMaxLength(8);

            this.Property(t => t.name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.start_time)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.end_time)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.incision_type)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.incision_status)
                .HasMaxLength(8);

            this.Property(t => t.Inplant)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("his_eng_order_operation");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.order_id).HasColumnName("order_id");
            this.Property(t => t.code).HasColumnName("code");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.start_time).HasColumnName("start_time");
            this.Property(t => t.end_time).HasColumnName("end_time");
            this.Property(t => t.incision_type).HasColumnName("incision_type");
            this.Property(t => t.incision_status).HasColumnName("incision_status");
            this.Property(t => t.Inplant).HasColumnName("Inplant");
        }
    }
}
