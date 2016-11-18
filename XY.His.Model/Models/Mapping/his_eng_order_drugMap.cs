using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class his_eng_order_drugMap : EntityTypeConfiguration<his_eng_order_drug>
    {
        public his_eng_order_drugMap()
        {
            // Primary Key
            this.HasKey(t => new { t.order_id, t.Type, t.end_time, t.first_execute_time, t.group_no, t.co_admin, t.drug_id, t.drug_name, t.reg_name, t.Manufacturer_name, t.admin_method, t.admin_goal, t.Pharm_pre_id, t.Pharm_chk_id, t.Qty, t.qty_unit });

            // Properties
            this.Property(t => t.Id)
                .HasMaxLength(32);

            this.Property(t => t.order_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.start_time)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.end_time)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.first_execute_time)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.group_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.co_admin)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.drug_id)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.drug_name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.reg_name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Manufacturer_name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.content_unit)
                .HasMaxLength(50);

            this.Property(t => t.pack_unit)
                .HasMaxLength(50);

            this.Property(t => t.dispense_unit)
                .HasMaxLength(50);

            this.Property(t => t.admin_route)
                .HasMaxLength(50);

            this.Property(t => t.prep_form)
                .HasMaxLength(50);

            this.Property(t => t.admin_dose)
                .HasMaxLength(60);

            this.Property(t => t.admin_frequency)
                .HasMaxLength(50);

            this.Property(t => t.admin_method)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.admin_goal)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.doc_id)
                .HasMaxLength(10);

            this.Property(t => t.doc_name)
                .HasMaxLength(30);

            this.Property(t => t.doc_title)
                .HasMaxLength(50);

            this.Property(t => t.Pharm_pre_id)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.Pharm_chk_id)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.Qty)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.qty_unit)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("his_eng_order_drug");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.order_id).HasColumnName("order_id");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.start_time).HasColumnName("start_time");
            this.Property(t => t.end_time).HasColumnName("end_time");
            this.Property(t => t.continue_day).HasColumnName("continue_day");
            this.Property(t => t.first_execute_time).HasColumnName("first_execute_time");
            this.Property(t => t.group_no).HasColumnName("group_no");
            this.Property(t => t.co_admin).HasColumnName("co_admin");
            this.Property(t => t.drug_id).HasColumnName("drug_id");
            this.Property(t => t.drug_name).HasColumnName("drug_name");
            this.Property(t => t.reg_name).HasColumnName("reg_name");
            this.Property(t => t.Manufacturer_name).HasColumnName("Manufacturer_name");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.content_unit).HasColumnName("content_unit");
            this.Property(t => t.Pack).HasColumnName("Pack");
            this.Property(t => t.pack_unit).HasColumnName("pack_unit");
            this.Property(t => t.dispense_unit).HasColumnName("dispense_unit");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.unit_price).HasColumnName("unit_price");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.admin_route).HasColumnName("admin_route");
            this.Property(t => t.prep_form).HasColumnName("prep_form");
            this.Property(t => t.admin_dose).HasColumnName("admin_dose");
            this.Property(t => t.admin_frequency).HasColumnName("admin_frequency");
            this.Property(t => t.admin_method).HasColumnName("admin_method");
            this.Property(t => t.admin_goal).HasColumnName("admin_goal");
            this.Property(t => t.doc_id).HasColumnName("doc_id");
            this.Property(t => t.doc_name).HasColumnName("doc_name");
            this.Property(t => t.doc_title).HasColumnName("doc_title");
            this.Property(t => t.Pharm_pre_id).HasColumnName("Pharm_pre_id");
            this.Property(t => t.Pharm_chk_id).HasColumnName("Pharm_chk_id");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.qty_unit).HasColumnName("qty_unit");
        }
    }
}
