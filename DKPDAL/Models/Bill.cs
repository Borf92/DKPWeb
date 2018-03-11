using System;

namespace DKPDAL.Models
{
    public class Bill : DkpEntityModel
    {
        
        public string Number { get; set; }
        public DateTimeOffset CreationDate { get; set; }
        public decimal Balance { get; set; }
    }
}
