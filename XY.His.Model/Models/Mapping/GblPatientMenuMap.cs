using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class GblPatientMenuMap : EntityTypeConfiguration<GblPatientMenu>
    {
        public GblPatientMenuMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .HasMaxLength(40);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FormName)
                .HasMaxLength(50);

            this.Property(t => t.TableName)
                .HasMaxLength(50);

            this.Property(t => t.PyCode)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.WbCode)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.SearchConfig)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("GblPatientMenu");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.LsType).HasColumnName("LsType");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ParentID).HasColumnName("ParentID");
            this.Property(t => t.IsTitle).HasColumnName("IsTitle");
            this.Property(t => t.FormName).HasColumnName("FormName");
            this.Property(t => t.TableName).HasColumnName("TableName");
            this.Property(t => t.IsForNew).HasColumnName("IsForNew");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.WbCode).HasColumnName("WbCode");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");
            this.Property(t => t.IsAuth).HasColumnName("IsAuth");
            this.Property(t => t.IsPrint).HasColumnName("IsPrint");
            this.Property(t => t.SearchConfig).HasColumnName("SearchConfig");

            // Relationships
            this.HasOptional(t => t.GblPatientMenu2)
                .WithMany(t => t.GblPatientMenu1)
                .HasForeignKey(d => d.ParentID);

        }
    }
}
