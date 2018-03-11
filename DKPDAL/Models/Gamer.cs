using System;
using System.Collections.Generic;

namespace DKPDAL.Models
{
    public class Gamer : DkpEntityModel
    {
       
        public string NickName { get; set; }
        public DateTimeOffset CreationDate { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
    }
}
