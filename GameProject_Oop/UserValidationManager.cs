using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject_Oop
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1995 && gamer.FirstName == "Furkan"
                && gamer.LastName == "Yilmaz" && gamer.IdentityNumber == 12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
