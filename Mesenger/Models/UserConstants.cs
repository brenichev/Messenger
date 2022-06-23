using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mesenger.Models
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel() { EmailAddress = "p1@mail.com", Password = "pass" },
            new UserModel() { EmailAddress = "p2@mail.com", Password = "pass2" },
        };
    }
}
