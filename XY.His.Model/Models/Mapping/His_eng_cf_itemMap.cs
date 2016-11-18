using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class His_eng_cf_itemMap : EntityTypeConfiguration<His_eng_cf_item>
    {
        public His_eng_cf_itemMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Cfid, t.Drug, t.drug_name, t.reg_name, t.Spec, t.Quantity, t.dispense_unit, t.unit_price, t.group_no, t.first_use, t.admin_area, t.admin_method, t.special_promote });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Cfid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Drug)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.drug_name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.reg_name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Manufacturer_name)
                .HasMaxLength(50);

            this.Property(t => t.Spec)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Quantity)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.dispense_unit)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.pack_unit)
                .HasMaxLength(50);

            this.Property(t => t.unit_price)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.group_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.first_use)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.prep_form)
                .HasMaxLength(50);

            this.Property(t => t.admin_route)
                .HasMaxLength(50);

            this.Property(t => t.admin_area)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.admin_frequency)
                .HasMaxLength(50);

            this.Property(t => t.admin_dose)
                .HasMaxLength(60);

            this.Property(t => t.admin_method)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.special_promote)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.skin_test)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("His_eng_cf_item");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Cfid).HasColumnName("Cfid");
            this.Property(t => t.Drug).HasColumnName("Drug");
            this.Property(t => t.drug_name).HasColumnName("drug_name");
            this.Property(t => t.reg_name).HasColumnName("reg_name");
            this.Property(t => t.Manufacturer_name).HasColumnName("Manufacturer_name");
            this.Property(t => t.continue_day).HasColumnName("continue_day");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.content_unit).HasColumnName("content_unit");
            this.Property(t => t.Pack).HasColumnName("Pack");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.dispense_unit).HasColumnName("dispense_unit");
            this.Property(t => t.pack_unit).HasColumnName("pack_unit");
            this.Property(t => t.unit_price).HasColumnName("unit_price");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.group_no).HasColumnName("group_no");
            this.Property(t => t.first_use).HasColumnName("first_use");
            this.Property(t => t.prep_form).HasColumnName("prep_form");
            this.Property(t => t.admin_route).HasColumnName("admin_route");
            this.Property(t => t.admin_area).HasColumnName("admin_area");
            this.Property(t => t.admin_frequency).HasColumnName("admin_frequency");
            this.Property(t => t.admin_dose).HasColumnName("admin_dose");
            this.Property(t => t.admin_method).HasColumnName("admin_method");
            this.Property(t => t.special_promote).HasColumnName("special_promote");
            this.Property(t => t.skin_test).HasColumnName("skin_test");
        }
    }
}
