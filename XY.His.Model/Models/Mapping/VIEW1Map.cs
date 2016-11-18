using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VIEW1Map : EntityTypeConfiguration<VIEW1>
    {
        public VIEW1Map()
        {
            // Primary Key
            this.HasKey(t => new { t.RegOperTime, t.Name, t.AdviceId, t.LsMarkType, t.Totality, t.Amount, t.LsPerform, t.IsCancel, t.AdviceTime, t.HospId, t.OperTime, t.LocationId, t.ID, t.Expr1, t.OperId });

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AdviceId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsMarkType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Totality)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Amount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsPerform)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HospId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LocationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OperId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VIEW1");
            this.Property(t => t.RegOperTime).HasColumnName("RegOperTime");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.AdviceId).HasColumnName("AdviceId");
            this.Property(t => t.LsMarkType).HasColumnName("LsMarkType");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.LsPerform).HasColumnName("LsPerform");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");
            this.Property(t => t.AdviceTime).HasColumnName("AdviceTime");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Expr1).HasColumnName("Expr1");
            this.Property(t => t.OperId).HasColumnName("OperId");
        }
    }
}
