using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class viewTestResultCumulateMap : EntityTypeConfiguration<viewTestResultCumulate>
    {
        public viewTestResultCumulateMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OperTime, t.Result, t.Unit, t.TestId, t.PatId });

            // Properties
            this.Property(t => t.ShortName)
                .HasMaxLength(50);

            this.Property(t => t.Result)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Unit)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.TestId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PatId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("viewTestResultCumulate");
            this.Property(t => t.ShortName).HasColumnName("ShortName");
            this.Property(t => t.LsGroup).HasColumnName("LsGroup");
            this.Property(t => t.LabId).HasColumnName("LabId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.Result).HasColumnName("Result");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.TestId).HasColumnName("TestId");
            this.Property(t => t.PatId).HasColumnName("PatId");
        }
    }
}
