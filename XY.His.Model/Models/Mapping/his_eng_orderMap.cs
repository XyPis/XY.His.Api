using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class his_eng_orderMap : EntityTypeConfiguration<his_eng_order>
    {
        public his_eng_orderMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Sex, t.pay_type, t.Patient_no, t.Name, t.Address, t.id_card, t.birth_weight, t.Allergy_list, t.Pregnancy, t.time_of_preg, t.breast_feeding, t.Marital, t.Occpation, t.Natonality, t.entry_time, t.in_department, t.in_area, t.out_date, t.out_department, t.out_area, t.hi_code, t.hi_name, t.hi_out_come, t.rescue_times, t.rescue_succ_times, t.pathologic_diag, t.pathologic_name, t.bed_fee, t.nurse_fee, t.wm_fee, t.cpd_fee, t.cmh_fee, t.radio_fee, t.exam_fee, t.oxy_fee, t.blood_fee, t.operation_fee, t.check_fee, t.anesth_fee, t.treat_fee, t.other_fee, t.total_fee });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Sex)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.pay_type)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Patient_no)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Address)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.phone_no)
                .HasMaxLength(15);

            this.Property(t => t.id_card)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Height)
                .HasMaxLength(32);

            this.Property(t => t.Weight)
                .HasMaxLength(32);

            this.Property(t => t.birth_weight)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.Allergy_list)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Pregnancy)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.time_of_preg)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.breast_feeding)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.Birthday)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Marital)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.Occpation)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.Natonality)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.entry_time)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_date)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.in_department)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.in_area)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.out_date)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.out_department)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.doc_group)
                .HasMaxLength(20);

            this.Property(t => t.dept_group)
                .HasMaxLength(30);

            this.Property(t => t.out_area)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.hi_code)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.hi_name)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.hi_out_come)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.rescue_times)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.rescue_succ_times)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.pathologic_diag)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.pathologic_name)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.bed_fee)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.nurse_fee)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.wm_fee)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cpd_fee)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cmh_fee)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.radio_fee)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.exam_fee)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.oxy_fee)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.blood_fee)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.operation_fee)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.check_fee)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.anesth_fee)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.treat_fee)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.other_fee)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.total_fee)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("his_eng_order");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.pay_type).HasColumnName("pay_type");
            this.Property(t => t.Patient_no).HasColumnName("Patient_no");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.phone_no).HasColumnName("phone_no");
            this.Property(t => t.id_card).HasColumnName("id_card");
            this.Property(t => t.Height).HasColumnName("Height");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.birth_weight).HasColumnName("birth_weight");
            this.Property(t => t.Allergy_list).HasColumnName("Allergy_list");
            this.Property(t => t.Pregnancy).HasColumnName("Pregnancy");
            this.Property(t => t.time_of_preg).HasColumnName("time_of_preg");
            this.Property(t => t.breast_feeding).HasColumnName("breast_feeding");
            this.Property(t => t.Birthday).HasColumnName("Birthday");
            this.Property(t => t.Marital).HasColumnName("Marital");
            this.Property(t => t.Occpation).HasColumnName("Occpation");
            this.Property(t => t.Natonality).HasColumnName("Natonality");
            this.Property(t => t.entry_time).HasColumnName("entry_time");
            this.Property(t => t.in_date).HasColumnName("in_date");
            this.Property(t => t.in_department).HasColumnName("in_department");
            this.Property(t => t.in_area).HasColumnName("in_area");
            this.Property(t => t.out_date).HasColumnName("out_date");
            this.Property(t => t.out_department).HasColumnName("out_department");
            this.Property(t => t.doc_group).HasColumnName("doc_group");
            this.Property(t => t.dept_group).HasColumnName("dept_group");
            this.Property(t => t.out_area).HasColumnName("out_area");
            this.Property(t => t.hi_code).HasColumnName("hi_code");
            this.Property(t => t.hi_name).HasColumnName("hi_name");
            this.Property(t => t.hi_out_come).HasColumnName("hi_out_come");
            this.Property(t => t.rescue_times).HasColumnName("rescue_times");
            this.Property(t => t.rescue_succ_times).HasColumnName("rescue_succ_times");
            this.Property(t => t.pathologic_diag).HasColumnName("pathologic_diag");
            this.Property(t => t.pathologic_name).HasColumnName("pathologic_name");
            this.Property(t => t.bed_fee).HasColumnName("bed_fee");
            this.Property(t => t.nurse_fee).HasColumnName("nurse_fee");
            this.Property(t => t.wm_fee).HasColumnName("wm_fee");
            this.Property(t => t.cpd_fee).HasColumnName("cpd_fee");
            this.Property(t => t.cmh_fee).HasColumnName("cmh_fee");
            this.Property(t => t.radio_fee).HasColumnName("radio_fee");
            this.Property(t => t.exam_fee).HasColumnName("exam_fee");
            this.Property(t => t.oxy_fee).HasColumnName("oxy_fee");
            this.Property(t => t.blood_fee).HasColumnName("blood_fee");
            this.Property(t => t.operation_fee).HasColumnName("operation_fee");
            this.Property(t => t.check_fee).HasColumnName("check_fee");
            this.Property(t => t.anesth_fee).HasColumnName("anesth_fee");
            this.Property(t => t.treat_fee).HasColumnName("treat_fee");
            this.Property(t => t.other_fee).HasColumnName("other_fee");
            this.Property(t => t.total_fee).HasColumnName("total_fee");
        }
    }
}
