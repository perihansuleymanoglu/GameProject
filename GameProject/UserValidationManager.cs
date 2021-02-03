using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.BirthYear == 1997 && gamer.FirstName == "Perihan" && gamer.LastName =="Süleymanoğlu" && gamer.IdentityNumber== 987463)
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
