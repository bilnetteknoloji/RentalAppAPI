using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Core.Domain
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string About { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string address { get; set; } = null!;

        public string SecondPersonName { get; set; } = null!;
        public string SecondPersonLastName { get; set; } = null!;
        public string SecondPersonPhoneNumber { get; set; } = null!;
        public string SecondPersonEmail { get; set; } = null!;


        public int IlceId { get; set; }

        public DateTime Creadet { get; set; } = DateTime.Now;
        public DateTime Modified { get; set; } = DateTime.Now;
        public bool Status { get; set; }
    }
}
