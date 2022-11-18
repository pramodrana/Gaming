using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class Game
    {
        public Game()
        {
            GameCategories = new HashSet<GameCategory>();
        }

        public long GameId { get; set; }
        public string? GameName { get; set; }
        public long GameCode { get; set; }
        public DateTime? InsertedOn { get; set; }
        public long? InsertedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public long? UpdatedBy { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<GameCategory> GameCategories { get; set; }
    }
}
