using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class InHosUsageItemMap : EntityTypeConfiguration<InHosUsageItem>
    {
        public InHosUsageItemMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.ItemId, t.AdviceId, t.LsMarkType, t.Totality, t.HospId, t.UsageItemId, t.Times, t.AdviceTime });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AdviceId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsMarkType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Totality)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HospId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UsageMemo)
                .HasMaxLength(100);

            this.Property(t => t.AdviceMemo)
                .HasMaxLength(100);

            this.Property(t => t.UsageItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Times)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("InHosUsageItem");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UsageId).HasColumnName("UsageId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.AdviceId).HasColumnName("AdviceId");
            this.Property(t => t.LsMarkType).HasColumnName("LsMarkType");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.GroupNum).HasColumnName("GroupNum");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.UsageMemo).HasColumnName("UsageMemo");
            this.Property(t => t.AdviceMemo).HasColumnName("AdviceMemo");
            this.Property(t => t.UsageItemId).HasColumnName("UsageItemId");
            this.Property(t => t.Times).HasColumnName("Times");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.AdviceTime).HasColumnName("AdviceTime");
            this.Property(t => t.FrequencyId).HasColumnName("FrequencyId");
        }
    }
}
