using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ToddlerScanV2.Models;

namespace ToddlerScanV2.MockAPI
{
    public class MockAPI
    {
        private static IEnumerable<Toddler> allToddlersMock = new List<Toddler>
        {
                new Toddler {Id = 1, FirstName = "MockOne", LastName = "MockLastOne", Grade = "1"},
                new Toddler {Id = 2, FirstName = "MockTwo", LastName = "MockLastTwo", Grade = "2"},
                new Toddler {Id = 3, FirstName = "MockThree", LastName = "MockLastThree", Grade = "3"}
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
    }
}
