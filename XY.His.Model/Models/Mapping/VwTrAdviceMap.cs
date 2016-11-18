using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwTrAdviceMap : EntityTypeConfiguration<VwTrAdvice>
    {
        public VwTrAdviceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.OperTime, t.LsMarkType, t.InPatNo, t.ItemId, t.OperId, t.UserName, t.ItemName, t.PatientName, t.Type, t.AdviceId, t.HospId });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsMarkType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InPatNo)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.ItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OperId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ItemName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PatientName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Before)
                .HasMaxLength(50);

            this.Property(t => t.After)
                .HasMaxLength(50);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.AdviceId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HospId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VwTrAdvice");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.LsMarkType).HasColumnName("LsMarkType");
            this.Property(t => t.InPatNo).HasColumnName("InPatNo");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Before).HasColumnName("Before");
            this.Property(t => t.After).HasColumnName("After");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.AdviceId).HasColumnName("AdviceId");
            this.Property(t => t.HospId).HasColumnName("HospId");
        }
    }
}
