using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class his_eng_order_examMap : EntityTypeConfiguration<his_eng_order_exam>
    {
        public his_eng_order_examMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.sample_id, t.sample_type, t.sample_name, t.Sample, t.exam_item_id, t.exam_item_name, t.send_time, t.check_doc_id });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sample_id)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.sample_type)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.sample_name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Sample)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.exam_item_id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.exam_item_name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Department)
                .HasMaxLength(30);

            this.Property(t => t.doc_name)
                .HasMaxLength(20);

            this.Property(t => t.receive_doc_id)
                .HasMaxLength(10);

            this.Property(t => t.report_doc_id)
                .HasMaxLength(10);

            this.Property(t => t.check_doc_id)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("his_eng_order_exam");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.order_id).HasColumnName("order_id");
            this.Property(t => t.sample_id).HasColumnName("sample_id");
            this.Property(t => t.sample_type).HasColumnName("sample_type");
            this.Property(t => t.sample_name).HasColumnName("sample_name");
            this.Property(t => t.Sample).HasColumnName("Sample");
            this.Property(t => t.exam_item_id).HasColumnName("exam_item_id");
            this.Property(t => t.exam_item_name).HasColumnName("exam_item_name");
            this.Property(t => t.Department).HasColumnName("Department");
            this.Property(t => t.doc_name).HasColumnName("doc_name");
            this.Property(t => t.send_time).HasColumnName("send_time");
            this.Property(t => t.receive_time).HasColumnName("receive_time");
            this.Property(t => t.report_time).HasColumnName("report_time");
            this.Property(t => t.receive_doc_id).HasColumnName("receive_doc_id");
            this.Property(t => t.report_doc_id).HasColumnName("report_doc_id");
            this.Property(t => t.check_doc_id).HasColumnName("check_doc_id");
        }
    }
}
