using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class DDLExecSqlMap : EntityTypeConfiguration<DDLExecSql>
    {
        public DDLExecSqlMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.EventType)
                .HasMaxLength(90);

            this.Property(t => t.SchemaName)
                .HasMaxLength(30);

            this.Property(t => t.ObjType)
                .HasMaxLength(30);

            this.Property(t => t.ObjName)
                .HasMaxLength(50);

            this.Property(t => t.Terminal)
                .HasMaxLength(99);

            // Table & Column Mappings
            this.ToTable("DDLExecSql");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.EventType).HasColumnName("EventType");
            this.Property(t => t.SchemaName).HasColumnName("SchemaName");
            this.Property(t => t.ObjType).HasColumnName("ObjType");
            this.Property(t => t.ObjName).HasColumnName("ObjName");
            this.Property(t => t.SqlText).HasColumnName("SqlText");
            this.Property(t => t.ExecDate).HasColumnName("ExecDate");
            this.Property(t => t.Terminal).HasColumnName("Terminal");
        }
    }
}
