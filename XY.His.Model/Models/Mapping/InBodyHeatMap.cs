using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class InBodyHeatMap : EntityTypeConfiguration<InBodyHeat>
    {
        public InBodyHeatMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.AnimalHeat)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.HeatType)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Pulse)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Heart)
                .HasMaxLength(50);

            this.Property(t => t.Breath)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Stool)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Urine)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Weight)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Bldpress0)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Bldpress1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FluidM)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TotalIn)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UrineM)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.OtherM)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TotalOut)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MemoUp)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MemoDn)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Others)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.F1)
                .HasMaxLength(50);

            this.Property(t => t.F2)
                .HasMaxLength(50);

            this.Property(t => t.F3)
                .HasMaxLength(50);

            this.Property(t => t.F4)
                .HasMaxLength(50);

            this.Property(t => t.CwInject)
                .HasMaxLength(50);

            this.Property(t => t.JmInject)
                .HasMaxLength(50);

            this.Property(t => t.CwHeight)
                .HasMaxLength(50);

            this.Property(t => t.MemoUp1)
                .HasMaxLength(50);

            this.Property(t => t.MemoDn1)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("InBodyHeat");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.AnimalHeat).HasColumnName("AnimalHeat");
            this.Property(t => t.HeatType).HasColumnName("HeatType");
            this.Property(t => t.Pulse).HasColumnName("Pulse");
            this.Property(t => t.Heart).HasColumnName("Heart");
            this.Property(t => t.Breath).HasColumnName("Breath");
            this.Property(t => t.Stool).HasColumnName("Stool");
            this.Property(t => t.Urine).HasColumnName("Urine");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.Bldpress0).HasColumnName("Bldpress0");
            this.Property(t => t.Bldpress1).HasColumnName("Bldpress1");
            this.Property(t => t.FluidM).HasColumnName("FluidM");
            this.Property(t => t.TotalIn).HasColumnName("TotalIn");
            this.Property(t => t.UrineM).HasColumnName("UrineM");
            this.Property(t => t.OtherM).HasColumnName("OtherM");
            this.Property(t => t.TotalOut).HasColumnName("TotalOut");
            this.Property(t => t.MemoUp).HasColumnName("MemoUp");
            this.Property(t => t.MemoDn).HasColumnName("MemoDn");
            this.Property(t => t.SpinTest).HasColumnName("SpinTest");
            this.Property(t => t.LowerTemp).HasColumnName("LowerTemp");
            this.Property(t => t.IsRecheck).HasColumnName("IsRecheck");
            this.Property(t => t.IsOutSide).HasColumnName("IsOutSide");
            this.Property(t => t.IsMachine).HasColumnName("IsMachine");
            this.Property(t => t.Others).HasColumnName("Others");
            this.Property(t => t.IsOps).HasColumnName("IsOps");
            this.Property(t => t.BirthTime).HasColumnName("BirthTime");
            this.Property(t => t.IsReject).HasColumnName("IsReject");
            this.Property(t => t.DeadTime).HasColumnName("DeadTime");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.BG).HasColumnName("BG");
            this.Property(t => t.CwInject).HasColumnName("CwInject");
            this.Property(t => t.JmInject).HasColumnName("JmInject");
            this.Property(t => t.CwHeight).HasColumnName("CwHeight");
            this.Property(t => t.OperationTime).HasColumnName("OperationTime");
            this.Property(t => t.IsLeave).HasColumnName("IsLeave");
            this.Property(t => t.MemoUp1).HasColumnName("MemoUp1");
            this.Property(t => t.MemoDn1).HasColumnName("MemoDn1");
            this.Property(t => t.RecordTime).HasColumnName("RecordTime");

            // Relationships
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.InBodyHeats)
                .HasForeignKey(d => d.OperId);
            this.HasRequired(t => t.InHosInfo)
                .WithMany(t => t.InBodyHeats)
                .HasForeignKey(d => d.HospId);

        }
    }
}
