using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Team_3_mueseum.Model{
    public class Membership
    {
        [Column("membership_id")]
        public int Id { get; set; } 

        [Column("type")]
        public int Type { get; set; }

        [Column("fee")]
        public decimal Fee { get; set; }

        [Column("expiry_date")]
        public DateTime ExpiryDate { get; set; }
    }
}