using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ToddlerScanV2.Models;

namespace ToddlerScanV2.MockAPI
{
    public class MockAPI
    {

        //----------------------------API Toddlers---------------------------------------
        private static IEnumerable<Toddler> allToddlersMock = new List<Toddler>
        {
                new Toddler {Id = 1, FirstName = "R2D2", LastName = "", Grade = "1"},
                new Toddler {Id = 2, FirstName = "Jar Jar", LastName = "Binks", Grade = "2"},
                new Toddler {Id = 3, FirstName = "Luke", LastName = "Skywalker", Grade = "3"}
        };

        public static IEnumerable<Toddler> GetAllToddlersMock()
        {
            return allToddlersMock;
        }

        public static Toddler getToddlerByIdMock(int id)
        {
            IEnumerable<Toddler> allToddlers = GetAllToddlersMock();
            Toddler selectedToddler = allToddlers.Where(toddler => toddler.Id.Equals(id)).FirstOrDefault();
            return selectedToddler;
        }

        public static void changeToddlerGradeMock(int id, string grade)
        {
            Toddler toddlerToChangeGrade = getToddlerByIdMock(id);
            toddlerToChangeGrade.Grade = grade;
        }

        //-------------------------------API Users------------------------------------------------
        private static List<User> allUsersMock = new List<User>
        {
            new User {Id = 1, Username = "Yoda", Password = "Force"},
            new User {Id = 2, Username = "Han Solo", Password = "Falcon"},
            new User {Id = 3, Username = "Vader", Password = "DeathStar"},

        };

        public static List<User> getAllUsersMock()
        {
            return allUsersMock;
        }

        public static bool ValidateUser(List<User> allUsers, User userToValidate)
        {
            foreach(User user in allUsers)
            {
                if (user.Username.Equals(userToValidate.Username) && user.Password.Equals(userToValidate.Password))
                    return true;
            }
            return false;
        }

        public static void addUser(User userToSignIn)
        {
            allUsersMock.Add(userToSignIn);
        }
    }
}
