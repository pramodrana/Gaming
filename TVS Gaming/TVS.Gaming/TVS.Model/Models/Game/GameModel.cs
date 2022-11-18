using System;
using System.Collections.Generic;
using TVS.Model.Models.GameCategory;

namespace TVS.Model.Models.Game
{
    public partial class GameModel
    {
        public GameModel()
        {
            GameCategories = new HashSet<GameCategoryModel>();
        }

        public long GameId { get; set; }
        public string? GameName { get; set; }
        public long GameCode { get; set; }
        public DateTime? InsertedOn { get; set; }
        public long? InsertedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public long? UpdatedBy { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<GameCategoryModel> GameCategories { get; set; }
    }
}
