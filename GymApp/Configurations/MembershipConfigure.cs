using GymApp.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Configurations
{
    public class MembershipConfigure
    {
        public static void MembershipConfigureMethod(EntityTypeBuilder<Membership> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasData(
                new Membership
                {
                    Id = 1,
                    Type = Enums.MembershipType.Standard,
                    Duration = 12,
                    Price = 2000
                },
                new Membership
                {
                    Id = 2,
                    Type = Enums.MembershipType.Premium,
                    Duration = 6,
                    Price = 3500
                },
                new Membership
                {
                    Id = 3,
                    Type = Enums.MembershipType.Standard,
                    Duration = 3,
                    Price = 700
                },
                new Membership
                {
                    Id = 4,
                    Type = Enums.MembershipType.Premium,
                    Duration = 12,
                    Price = 5000
                },
                new Membership
                {
                    Id = 5,
                    Type = Enums.MembershipType.Standard,
                    Duration = 6,
                    Price = 1200
                },
                new Membership
                {
                    Id = 6,
                    Type = Enums.MembershipType.Premium,
                    Duration = 3,
                    Price = 1500
                },
                new Membership
                {
                    Id = 7,
                    Type = Enums.MembershipType.Standard,
                    Duration = 12,
                    Price = 2500
                },
                new Membership
                {
                    Id = 8,
                    Type = Enums.MembershipType.Premium,
                    Duration = 6,
                    Price = 4000
                },
                new Membership
                {
                    Id = 9,
                    Type = Enums.MembershipType.Standard,
                    Duration = 3,
                    Price = 800
                },
                new Membership
                {
                    Id = 10,
                    Type = Enums.MembershipType.Premium,
                    Duration = 12,
                    Price = 6000
                },
                new Membership
                {
                    Id = 11,
                    Type = Enums.MembershipType.Standard,
                    Duration = 6,
                    Price = 1500
                },
                new Membership
                {
                    Id = 12,
                    Type = Enums.MembershipType.Premium,
                    Duration = 3,
                    Price = 2000
                },
                new Membership
                {
                    Id = 13,
                    Type = Enums.MembershipType.Standard,
                    Duration = 12,
                    Price = 3000
                },
                new Membership
                {
                    Id = 14,
                    Type = Enums.MembershipType.Premium,
                    Duration = 6,
                    Price = 4500
                },
                new Membership
                {
                    Id = 15,
                    Type = Enums.MembershipType.Standard,
                    Duration = 3,
                    Price = 900
                }
                );
        }
    }
}
