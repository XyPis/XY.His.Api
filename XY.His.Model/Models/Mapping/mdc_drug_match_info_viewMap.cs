using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class mdc_drug_match_info_viewMap : EntityTypeConfiguration<mdc_drug_match_info_view>
    {
        public mdc_drug_match_info_viewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.suser_id, t.suser_name, t.suser_spell, t.suser_spell2, t.suser_code, t.suser_type, t.suser_spec, t.suser_unit });

            // Properties
            this.Property(t => t.suser_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.suser_name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.suser_spell)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.suser_spell2)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.suser_code)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.suser_type)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.suser_spec)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.suser_unit)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ssys_name)
                .HasMaxLength(255);

            this.Property(t => t.ssys_type)
                .HasMaxLength(32);

            this.Property(t => t.sstrength)
                .HasMaxLength(255);

            this.Property(t => t.ssys_unit)
                .HasMaxLength(32);

            this.Property(t => t.sunitrate)
                .HasMaxLength(32);

            this.Property(t => t.smatch_user)
                .HasMaxLength(24);

            this.Property(t => t.smatch_time)
                .HasMaxLength(19);

            this.Property(t => t.shas_his_info)
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("mdc_drug_match_info_view");
            this.Property(t => t.suser_id).HasColumnName("suser_id");
            this.Property(t => t.suser_name).HasColumnName("suser_name");
            this.Property(t => t.suser_spell).HasColumnName("suser_spell");
            this.Property(t => t.suser_spell2).HasColumnName("suser_spell2");
            this.Property(t => t.suser_code).HasColumnName("suser_code");
            this.Property(t => t.suser_type).HasColumnName("suser_type");
            this.Property(t => t.suser_spec).HasColumnName("suser_spec");
            this.Property(t => t.suser_unit).HasColumnName("suser_unit");
            this.Property(t => t.ssys_name).HasColumnName("ssys_name");
            this.Property(t => t.ssys_type).HasColumnName("ssys_type");
            this.Property(t => t.sstrength).HasColumnName("sstrength");
            this.Property(t => t.ssys_unit).HasColumnName("ssys_unit");
            this.Property(t => t.sunitrate).HasColumnName("sunitrate");
            this.Property(t => t.smatch_user).HasColumnName("smatch_user");
            this.Property(t => t.smatch_time).HasColumnName("smatch_time");
            this.Property(t => t.shas_his_info).HasColumnName("shas_his_info");
        }
    }
}
