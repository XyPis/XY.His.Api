using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwOuRoomRecipeA
    {
        public string RoomName { get; set; }
        public string LocationName { get; set; }
        public string RecipeNum { get; set; }
        public Nullable<System.DateTime> OutTime { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public int roomid { get; set; }
    }
}
