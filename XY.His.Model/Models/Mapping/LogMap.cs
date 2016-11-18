using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class LogMap : EntityTypeConfiguration<Log>
    {
        public LogMap()
        {
            // Primary Key
            this.HasKey(t => t.LogID);

            // Properties
            this.Property(t => t.Severity)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.MachineName)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.AppDomainName)
                .IsRequired()
                .HasMaxLength(512);

            this.Property(t => t.ProcessID)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.ProcessName)
                .IsRequired()
                .HasMaxLength(512);

            this.Property(t => t.ThreadName)
                .HasMaxLength(512);

            this.Property(t => t.Win32ThreadId)
                .HasMaxLength(128);

            this.Property(t => t.Message)
                .HasMaxLength(1500);

            // Table & Column Mappings
            this.ToTable("Log");
            this.Property(t => t.LogID).HasColumnName("LogID");
            this.Property(t => t.EventID).HasColumnName("EventID");
            this.Property(t => t.Priority).HasColumnName("Priority");
            this.Property(t => t.Severity).HasColumnName("Severity");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Timestamp).HasColumnName("Timestamp");
            this.Property(t => t.MachineName).HasColumnName("MachineName");
            this.Property(t => t.AppDomainName).HasColumnName("AppDomainName");
            this.Property(t => t.ProcessID).HasColumnName("ProcessID");
            this.Property(t => t.ProcessName).HasColumnName("ProcessName");
            this.Property(t => t.ThreadName).HasColumnName("ThreadName");
            this.Property(t => t.Win32ThreadId).HasColumnName("Win32ThreadId");
            this.Property(t => t.Message).HasColumnName("Message");
            this.Property(t => t.FormattedMessage).HasColumnName("FormattedMessage");
        }
    }
}
