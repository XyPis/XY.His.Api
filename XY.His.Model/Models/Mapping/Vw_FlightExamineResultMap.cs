using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_FlightExamineResultMap : EntityTypeConfiguration<Vw_FlightExamineResult>
    {
        public Vw_FlightExamineResultMap()
        {
            // Primary Key
            this.HasKey(t => new { t.LabId, t.TestId, t.打印序号, t.Name, t.Code, t.Result, t.Unit, t.结果正常标志, t.OperTime });

            // Properties
            this.Property(t => t.LabId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TestId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.打印序号)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Result)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Unit)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.结果正常标志)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("Vw_FlightExamineResult");
            this.Property(t => t.LabId).HasColumnName("LabId");
            this.Property(t => t.TestId).HasColumnName("TestId");
            this.Property(t => t.打印序号).HasColumnName("打印序号");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Result).HasColumnName("Result");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.结果正常标志).HasColumnName("结果正常标志");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
        }
    }
}
