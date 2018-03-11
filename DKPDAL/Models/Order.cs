using System;
using System.Collections.Generic;

namespace DKPDAL.Models
{
    public class Order : DkpEntityModel
    {
        
        public DateTimeOffset CreationDate { get; set; }
        public Gamer Gamer { get; set; }
        public ICollection<GameItem> Items { get; set; }
    }
}
