using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndyBooks.Models
{
    public class Member
    {
        public int MemberID { get; set; }

        // TODO: Create at least three  appropriate properties
        public string MemberName { get; set; }
        public string MemberAddress { get; set; }

        public int LengthOfMembership { get; set; }

        // TODO: Add Property to represent the entity relationship: "A Member can have many Purchases"
        public virtual ICollection<Purchase> MemberPurchases { get; set; }
    }
}