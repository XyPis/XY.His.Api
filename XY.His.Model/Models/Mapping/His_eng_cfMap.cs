using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class His_eng_cfMap : EntityTypeConfiguration<His_eng_cf>
    {
        public His_eng_cfMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.depart_id, t.Department, t.pres_type, t.pres_date_time, t.Sex, t.pay_type, t.pres_no, t.Name, t.Address, t.Id_card, t.Birth_weight, t.Ccr, t.allergy_list, t.Pregnancy, t.time_of_preg, t.breast_feeding, t.Dialysis, t.prox_name, t.prox_id_card, t.doc_id, t.doc_name, t.doc_title, t.doc_group, t.dept_group, t.pres_source, t.Pharm_audt_id, t.Pharm_audt_name, t.Pharm_pre_ID, t.Pharm_pre_name, t.Pharm_chk_id, t.Pharm_chk_name });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.depart_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Department)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Age)
                .HasMaxLength(50);

            this.Property(t => t.pres_type)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.pay_type)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.patient_no)
                .HasMaxLength(19);

            this.Property(t => t.pres_no)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Diagnose)
                .HasMaxLength(500);

            this.Property(t => t.Address)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Phone_no)
                .HasMaxLength(15);

            this.Property(t => t.Id_card)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Height)
                .HasMaxLength(32);

            this.Property(t => t.Weight)
                .HasMaxLength(32);

            this.Property(t => t.Birth_weight)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.Ccr)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.allergy_list)
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

            this.Property(t => t.Dialysis)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.prox_name)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.prox_id_card)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.doc_id)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.doc_name)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.doc_title)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.doc_group)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.dept_group)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.pres_source)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.Pharm_audt_id)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.Pharm_audt_name)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.Pharm_pre_ID)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Pharm_pre_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Pharm_chk_id)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.Pharm_chk_name)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.Pharm_delv_id)
                .HasMaxLength(10);

            this.Property(t => t.Pharm_delv_name)
                .HasMaxLength(30);

            this.Property(t => t.corres_cf_presno)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("His_eng_cf");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.depart_id).HasColumnName("depart_id");
            this.Property(t => t.Department).HasColumnName("Department");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.pres_type).HasColumnName("pres_type");
            this.Property(t => t.pres_date_time).HasColumnName("pres_date_time");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.pay_type).HasColumnName("pay_type");
            this.Property(t => t.patient_no).HasColumnName("patient_no");
            this.Property(t => t.pres_no).HasColumnName("pres_no");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Diagnose).HasColumnName("Diagnose");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.Phone_no).HasColumnName("Phone_no");
            this.Property(t => t.Id_card).HasColumnName("Id_card");
            this.Property(t => t.Height).HasColumnName("Height");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.Birth_weight).HasColumnName("Birth_weight");
            this.Property(t => t.Ccr).HasColumnName("Ccr");
            this.Property(t => t.allergy_list).HasColumnName("allergy_list");
            this.Property(t => t.Pregnancy).HasColumnName("Pregnancy");
            this.Property(t => t.time_of_preg).HasColumnName("time_of_preg");
            this.Property(t => t.breast_feeding).HasColumnName("breast_feeding");
            this.Property(t => t.Dialysis).HasColumnName("Dialysis");
            this.Property(t => t.prox_name).HasColumnName("prox_name");
            this.Property(t => t.prox_id_card).HasColumnName("prox_id_card");
            this.Property(t => t.doc_id).HasColumnName("doc_id");
            this.Property(t => t.doc_name).HasColumnName("doc_name");
            this.Property(t => t.doc_title).HasColumnName("doc_title");
            this.Property(t => t.doc_group).HasColumnName("doc_group");
            this.Property(t => t.dept_group).HasColumnName("dept_group");
            this.Property(t => t.Total_amount).HasColumnName("Total_amount");
            this.Property(t => t.pres_source).HasColumnName("pres_source");
            this.Property(t => t.Pharm_audt_id).HasColumnName("Pharm_audt_id");
            this.Property(t => t.Pharm_audt_name).HasColumnName("Pharm_audt_name");
            this.Property(t => t.Pharm_pre_ID).HasColumnName("Pharm_pre_ID");
            this.Property(t => t.Pharm_pre_name).HasColumnName("Pharm_pre_name");
            this.Property(t => t.Pharm_chk_id).HasColumnName("Pharm_chk_id");
            this.Property(t => t.Pharm_chk_name).HasColumnName("Pharm_chk_name");
            this.Property(t => t.Pharm_delv_id).HasColumnName("Pharm_delv_id");
            this.Property(t => t.Pharm_delv_name).HasColumnName("Pharm_delv_name");
            this.Property(t => t.corres_cf_presno).HasColumnName("corres_cf_presno");
        }
    }
}
