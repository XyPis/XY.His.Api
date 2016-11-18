using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Vw_ypxx
    {
        public string 代码 { get; set; }
        public string 商品名 { get; set; }
        public string 化学名 { get; set; }
        public string 商品名五笔码 { get; set; }
        public string 商品名拼音码 { get; set; }
        public string 化学名五笔码 { get; set; }
        public string 化学名拼音码 { get; set; }
        public string 规格 { get; set; }
        public string 住院单位 { get; set; }
        public decimal 住院价格 { get; set; }
        public string 门诊单位 { get; set; }
        public decimal 门诊价格 { get; set; }
        public decimal 加成率 { get; set; }
        public short 处方类别 { get; set; }
        public decimal 默认用量 { get; set; }
        public string 服用单位 { get; set; }
        public string 默认频率 { get; set; }
        public string 门诊收费类别 { get; set; }
        public string 住院收费类别 { get; set; }
        public short 公费类别 { get; set; }
        public decimal 门诊最小用量 { get; set; }
        public decimal 住院最小用量 { get; set; }
        public string 公费限额类别 { get; set; }
        public bool C150元以上 { get; set; }
        public bool 新项目 { get; set; }
        public bool 内部使用 { get; set; }
        public short 长期医嘱周期 { get; set; }
        public short 医嘱类别 { get; set; }
        public string 默认用法 { get; set; }
        public Nullable<bool> 处方药 { get; set; }
        public Nullable<bool> 毒麻药品 { get; set; }
        public Nullable<bool> 精神药品 { get; set; }
        public Nullable<bool> 抗菌素 { get; set; }
        public Nullable<bool> 院内制剂 { get; set; }
        public Nullable<bool> 贵重药品 { get; set; }
        public string 默认药库 { get; set; }
        public string 默认门诊药房 { get; set; }
        public string 默认住院药房 { get; set; }
        public string 药库单位 { get; set; }
        public string 生产商 { get; set; }
        public string 剂型 { get; set; }
        public string 项目类别 { get; set; }
        public Nullable<short> 显示顺序 { get; set; }
        public Nullable<bool> 招标药品 { get; set; }
        public Nullable<bool> 是否按批次管理 { get; set; }
        public Nullable<bool> 是否节省用药 { get; set; }
        public string 供应公司 { get; set; }
    }
}
