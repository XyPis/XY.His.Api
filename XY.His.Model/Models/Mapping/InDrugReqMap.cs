using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class InDrugReqMap : EntityTypeConfiguration<InDrugReq>
    {
        public InDrugReqMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.RequestNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.F1)
                .HasMaxLength(500);

            this.Property(t => t.F2)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("InDrugReq");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RequestNo).HasColumnName("RequestNo");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.RoomId).HasColumnName("RoomId");
            this.Property(t => t.LsSendStatus).HasColumnName("LsSendStatus");
            this.Property(t => t.IsPrint).HasColumnName("IsPrint");
            this.Property(t => t.ConfirmOperID).HasColumnName("ConfirmOperID");
            this.Property(t => t.ConfirmDate).HasColumnName("ConfirmDate");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");

            // Relationships
            this.HasRequired(t => t.BsLocation)
                .WithMany(t => t.InDrugReqs)
                .HasForeignKey(d => d.LocationId);
            this.HasRequired(t => t.BsRoom)
                .WithMany(t => t.InDrugReqs)
                .HasForeignKey(d => d.RoomId);

        }
    }
}
