using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class InLocNoPayMap : EntityTypeConfiguration<InLocNoPay>
    {
        public InLocNoPayMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("InLocNoPay");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ReportDate).HasColumnName("ReportDate");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.ExecLocId).HasColumnName("ExecLocId");
            this.Property(t => t.FeeId).HasColumnName("FeeId");
            this.Property(t => t.LsInStatus).HasColumnName("LsInStatus");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.Opertime).HasColumnName("Opertime");
        }
    }
}
