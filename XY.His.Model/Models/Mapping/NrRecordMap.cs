using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class NrRecordMap : EntityTypeConfiguration<NrRecord>
    {
        public NrRecordMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Type)
                .HasMaxLength(50);

            this.Property(t => t.Mentality)
                .HasMaxLength(50);

            this.Property(t => t.InItem1)
                .HasMaxLength(50);

            this.Property(t => t.InItem2)
                .HasMaxLength(50);

            this.Property(t => t.OutItem1)
                .HasMaxLength(50);

            this.Property(t => t.OutItem2)
                .HasMaxLength(50);

            this.Property(t => t.UrineProper)
                .HasMaxLength(50);

            this.Property(t => t.UrineColor)
                .HasMaxLength(50);

            this.Property(t => t.SpecialMemo)
                .HasMaxLength(500);

            this.Property(t => t.Breast)
                .HasMaxLength(50);

            this.Property(t => t.Milk)
                .HasMaxLength(50);

            this.Property(t => t.UterusHigh)
                .HasMaxLength(50);

            this.Property(t => t.UterusShrink)
                .HasMaxLength(50);

            this.Property(t => t.Wound)
                .HasMaxLength(50);

            this.Property(t => t.Hand)
                .HasMaxLength(50);

            this.Property(t => t.Foot)
                .HasMaxLength(50);

            this.Property(t => t.Buttocks)
                .HasMaxLength(50);

            this.Property(t => t.Mouth)
                .HasMaxLength(50);

            this.Property(t => t.Face)
                .HasMaxLength(50);

            this.Property(t => t.Breath)
                .HasMaxLength(50);

            this.Property(t => t.Blood)
                .HasMaxLength(50);

            this.Property(t => t.BoxTemp)
                .HasMaxLength(50);

            this.Property(t => t.SPO2)
                .HasMaxLength(50);

            this.Property(t => t.PupilL)
                .HasMaxLength(50);

            this.Property(t => t.PupilR)
                .HasMaxLength(50);

            this.Property(t => t.PupilBright)
                .HasMaxLength(50);

            this.Property(t => t.OxygenBr)
                .HasMaxLength(50);

            this.Property(t => t.OxygenF)
                .HasMaxLength(50);

            this.Property(t => t.OxygenFiO2)
                .HasMaxLength(50);

            this.Property(t => t.OxygenPipeDeep)
                .HasMaxLength(50);

            this.Property(t => t.OxygenCpap)
                .HasMaxLength(50);

            this.Property(t => t.OxygenPipeNose)
                .HasMaxLength(50);

            this.Property(t => t.OxygenVein)
                .HasMaxLength(50);

            this.Property(t => t.LiePose)
                .HasMaxLength(50);

            this.Property(t => t.Skin)
                .HasMaxLength(50);

            this.Property(t => t.Others)
                .HasMaxLength(50);

            this.Property(t => t.Disposal)
                .HasMaxLength(500);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.PupilLReflex)
                .HasMaxLength(50);

            this.Property(t => t.PupilRReflex)
                .HasMaxLength(50);

            this.Property(t => t.ResultMMO)
                .HasMaxLength(50);

            this.Property(t => t.ChannelName)
                .HasMaxLength(50);

            this.Property(t => t.ChannelSituation)
                .HasMaxLength(50);

            this.Property(t => t.Condition)
                .HasMaxLength(50);

            this.Property(t => t.Puncture)
                .HasMaxLength(50);

            this.Property(t => t.Joint)
                .HasMaxLength(50);

            this.Property(t => t.DropIn)
                .HasMaxLength(50);

            this.Property(t => t.Vein)
                .HasMaxLength(50);

            this.Property(t => t.DrugExudation)
                .HasMaxLength(50);

            this.Property(t => t.TumorExudation)
                .HasMaxLength(50);

            this.Property(t => t.Plaster)
                .HasMaxLength(50);

            this.Property(t => t.HDilution)
                .HasMaxLength(50);

            this.Property(t => t.PSaline)
                .HasMaxLength(50);

            this.Property(t => t.OperName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("NrRecord");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.ExamT).HasColumnName("ExamT");
            this.Property(t => t.ExamP).HasColumnName("ExamP");
            this.Property(t => t.ExamR).HasColumnName("ExamR");
            this.Property(t => t.ExamBp).HasColumnName("ExamBp");
            this.Property(t => t.ExamBp2).HasColumnName("ExamBp2");
            this.Property(t => t.Hight).HasColumnName("Hight");
            this.Property(t => t.Mentality).HasColumnName("Mentality");
            this.Property(t => t.InItem1).HasColumnName("InItem1");
            this.Property(t => t.InVolumn1).HasColumnName("InVolumn1");
            this.Property(t => t.InItem2).HasColumnName("InItem2");
            this.Property(t => t.InVolumn2).HasColumnName("InVolumn2");
            this.Property(t => t.InVolumnAll).HasColumnName("InVolumnAll");
            this.Property(t => t.OutItem1).HasColumnName("OutItem1");
            this.Property(t => t.OutVolumn1).HasColumnName("OutVolumn1");
            this.Property(t => t.OutItem2).HasColumnName("OutItem2");
            this.Property(t => t.OutVolumn2).HasColumnName("OutVolumn2");
            this.Property(t => t.OutVolumnAll).HasColumnName("OutVolumnAll");
            this.Property(t => t.UrineFree).HasColumnName("UrineFree");
            this.Property(t => t.UrineProper).HasColumnName("UrineProper");
            this.Property(t => t.UrineColor).HasColumnName("UrineColor");
            this.Property(t => t.OutOther).HasColumnName("OutOther");
            this.Property(t => t.SpecialMemo).HasColumnName("SpecialMemo");
            this.Property(t => t.Breast).HasColumnName("Breast");
            this.Property(t => t.Milk).HasColumnName("Milk");
            this.Property(t => t.UterusHigh).HasColumnName("UterusHigh");
            this.Property(t => t.UterusShrink).HasColumnName("UterusShrink");
            this.Property(t => t.Wound).HasColumnName("Wound");
            this.Property(t => t.Hand).HasColumnName("Hand");
            this.Property(t => t.Foot).HasColumnName("Foot");
            this.Property(t => t.Buttocks).HasColumnName("Buttocks");
            this.Property(t => t.Mouth).HasColumnName("Mouth");
            this.Property(t => t.Face).HasColumnName("Face");
            this.Property(t => t.Breath).HasColumnName("Breath");
            this.Property(t => t.Blood).HasColumnName("Blood");
            this.Property(t => t.BoxTemp).HasColumnName("BoxTemp");
            this.Property(t => t.SPO2).HasColumnName("SPO2");
            this.Property(t => t.PupilL).HasColumnName("PupilL");
            this.Property(t => t.PupilR).HasColumnName("PupilR");
            this.Property(t => t.PupilBright).HasColumnName("PupilBright");
            this.Property(t => t.OxygenBr).HasColumnName("OxygenBr");
            this.Property(t => t.OxygenF).HasColumnName("OxygenF");
            this.Property(t => t.OxygenFiO2).HasColumnName("OxygenFiO2");
            this.Property(t => t.OxygenPipeDeep).HasColumnName("OxygenPipeDeep");
            this.Property(t => t.OxygenCpap).HasColumnName("OxygenCpap");
            this.Property(t => t.OxygenPipeNose).HasColumnName("OxygenPipeNose");
            this.Property(t => t.OxygenVein).HasColumnName("OxygenVein");
            this.Property(t => t.LiePose).HasColumnName("LiePose");
            this.Property(t => t.Skin).HasColumnName("Skin");
            this.Property(t => t.Others).HasColumnName("Others");
            this.Property(t => t.Disposal).HasColumnName("Disposal");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.PupilLReflex).HasColumnName("PupilLReflex");
            this.Property(t => t.PupilRReflex).HasColumnName("PupilRReflex");
            this.Property(t => t.ResultMMO).HasColumnName("ResultMMO");
            this.Property(t => t.ChannelName).HasColumnName("ChannelName");
            this.Property(t => t.ChannelSituation).HasColumnName("ChannelSituation");
            this.Property(t => t.Condition).HasColumnName("Condition");
            this.Property(t => t.Puncture).HasColumnName("Puncture");
            this.Property(t => t.Joint).HasColumnName("Joint");
            this.Property(t => t.DropIn).HasColumnName("DropIn");
            this.Property(t => t.Vein).HasColumnName("Vein");
            this.Property(t => t.DrugExudation).HasColumnName("DrugExudation");
            this.Property(t => t.TumorExudation).HasColumnName("TumorExudation");
            this.Property(t => t.Plaster).HasColumnName("Plaster");
            this.Property(t => t.HDilution).HasColumnName("HDilution");
            this.Property(t => t.PSaline).HasColumnName("PSaline");
            this.Property(t => t.OperName).HasColumnName("OperName");

            // Relationships
            this.HasOptional(t => t.BsLocation)
                .WithMany(t => t.NrRecords)
                .HasForeignKey(d => d.LocationId);
            this.HasOptional(t => t.InHosInfo)
                .WithMany(t => t.NrRecords)
                .HasForeignKey(d => d.HospId);
            this.HasOptional(t => t.OuHosInfo)
                .WithMany(t => t.NrRecords)
                .HasForeignKey(d => d.MzRegId);

        }
    }
}
