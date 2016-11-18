using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class mdc_route_match_info_viewMap : EntityTypeConfiguration<mdc_route_match_info_view>
    {
        public mdc_route_match_info_viewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.suser_id, t.suser_name, t.suser_spell, t.suser_spell2, t.suser_code });

            // Properties
            this.Property(t => t.suser_id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.suser_name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.suser_spell)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.suser_spell2)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.suser_code)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ssys_name)
                .HasMaxLength(40);

            this.Property(t => t.smatch_user)
                .HasMaxLength(24);

            this.Property(t => t.smatch_time)
                .HasMaxLength(19);

            // Table & Column Mappings
            this.ToTable("mdc_route_match_info_view");
            this.Property(t => t.suser_id).HasColumnName("suser_id");
            this.Property(t => t.suser_name).HasColumnName("suser_name");
            this.Property(t => t.suser_spell).HasColumnName("suser_spell");
            this.Property(t => t.suser_spell2).HasColumnName("suser_spell2");
            this.Property(t => t.suser_code).HasColumnName("suser_code");
            this.Property(t => t.ssys_name).HasColumnName("ssys_name");
            this.Property(t => t.smatch_user).HasColumnName("smatch_user");
            this.Property(t => t.smatch_time).HasColumnName("smatch_time");
        }
    }
}
