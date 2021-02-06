using System;

namespace GameProject_Oop
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewESteteUserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1995, FirstName = "Furkan", LastName = "Yilmaz", IdentityNumber = 12345 });

        }
    }
}
