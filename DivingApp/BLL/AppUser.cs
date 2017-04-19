using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class AppUser : IModel
    {
        public int AppUserID
        { get; set; }

        public string Name
        { get; set; }

        public string Address
        { get; set; }

        public int Phone
        { get; set; }

        public string Email
        { get; set; }

        public string City
        { get; set; }

        public string Country
        { get; set; }

        public DateTime RegisteredDate
        { get; set; }

        public string Username
        { get; set; }

        public string Password
        { get; set; }

        public string PhotoPath
        { get; set; }
    }
}
