using GymApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Models
{
    public class Membership
    {
        public int Id { get; set; }
        public MembershipType Type { get; set; }
        public int Duration { get; set; }
        public decimal Price { get; set; }

        public List<Client>? Clients { get; set; }

    }
}
