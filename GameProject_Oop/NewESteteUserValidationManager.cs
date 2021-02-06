using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject_Oop
{
    class NewESteteUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
