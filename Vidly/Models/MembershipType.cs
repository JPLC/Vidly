using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }

        public short SignUpFree { get; set; }

        public byte DurationInMonths { get; set; }

        public byte DiscountRate { get; set; }

        [Required]
        public string Name { get; set; }

        public static readonly byte Unknow = 0;
        public static readonly byte PayAsYouGo = 1;
        public static readonly byte Monthly = 2;
        public static readonly byte Quarterly = 3;
        public static readonly byte Annual = 4;
    }
}