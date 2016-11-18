using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Category
    {
        public Category()
        {
            this.CategoryLogs = new List<CategoryLog>();
        }

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<CategoryLog> CategoryLogs { get; set; }
    }
}
