using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class PsExecuteMap : EntityTypeConfiguration<PsExecute>
    {
        public PsExecuteMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ApplyId)
                .HasMaxLength(50);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("PsExecute");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ApplyId).HasColumnName("ApplyId");
            this.Property(t => t.RecipeId).HasColumnName("RecipeId");
            this.Property(t => t.IsExecuted).HasColumnName("IsExecuted");
            this.Property(t => t.ExecutedTime).HasColumnName("ExecutedTime");
            this.Property(t => t.ExecutedOperId).HasColumnName("ExecutedOperId");
            this.Property(t => t.ExecLocId).HasColumnName("ExecLocId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
        }
    }
}
