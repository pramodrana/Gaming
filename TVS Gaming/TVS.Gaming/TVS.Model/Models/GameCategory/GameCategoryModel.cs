using System;
using System.Collections.Generic;

namespace TVS.Model.Models.GameCategory
{
    public partial class GameCategoryModel
    {     
        public long GameCategoryId { get; set; }
        public string? GameCategoryName { get; set; }
        public long? GameId { get; set; }
        public long GameCategoryCode { get; set; }
        public DateTime? InsertedOn { get; set; }
        public long? InsertedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public long? UpdatedBy { get; set; }
        public long HelpCoins { get; set; }
        public long FlipCoins { get; set; }
        public string? IsActive { get; set; }
    }
}
