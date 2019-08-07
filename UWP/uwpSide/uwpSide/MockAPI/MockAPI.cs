using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uwpSide.Models;

namespace uwpSide.MockAPI
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



        //-------------------------------API Teachers------------------------------------------------
        private static List<Teacher> allTeachersMock = new List<Teacher>
        {
            new Teacher {Id = 1, FirstName = "Master", LastName = "Yoda"},
            new Teacher {Id = 2, FirstName = "Han", LastName = "Solo"},
            new Teacher {Id = 3, FirstName = "Darth", LastName = "Vader"},

        };

        public static List<Teacher> getAllTeachersMock()
        {
            return allTeachersMock;
        }


        public static void addTeacher(Teacher TeacherToSignIn)
        {
            allTeachersMock.Add(TeacherToSignIn);
        }

        //------------------------------API Trips---------------------------------------------------------
        private static List<Trip> allTripsMock = new List<Trip>
        {
            new Trip
            {
                Id = 1,
                Title = "Zee",
                Date = DateTime.Now,
                TeacherId = 2,
                teacher = new Teacher {Id = 2, FirstName = "Han", LastName = "Yoda"},
                Toddlers = new List<Toddler>
                {
                new Toddler {Id = 1, FirstName = "R2D2", LastName = "", Grade = "1"},
                new Toddler {Id = 3, FirstName = "Luke", LastName = "Skywalker", Grade = "3"}
                }
            },

            new Trip
            {
                Id = 2,
                Title = "Ardennen",
                Date = DateTime.Now,
                TeacherId = 1,
                teacher = new Teacher {Id = 1, FirstName = "Master", LastName = "Yoda"},
                Toddlers = new List<Toddler>
                {
                new Toddler {Id = 2, FirstName = "Jar Jar", LastName = "Binks", Grade = "2"},
                new Toddler {Id = 3, FirstName = "Luke", LastName = "Skywalker", Grade = "3"}
                }
            },

            new Trip
            {
                Id = 3,
                Title = "Zoo",
                Date = DateTime.Now,
                TeacherId = 3,
                teacher = new Teacher {Id = 3, FirstName = "Darth", LastName = "Vader"},
                Toddlers = new List<Toddler>
                {
                new Toddler {Id = 1, FirstName = "R2D2", LastName = "", Grade = "1"},
                new Toddler {Id = 2, FirstName = "Jar Jar", LastName = "Binks", Grade = "2"},
                new Toddler {Id = 3, FirstName = "Luke", LastName = "Skywalker", Grade = "3"}
                }
            }

        };

        private static List<Trip> getAllTripsMock()
        {
            return allTripsMock;
        }

        private static List<Toddler> getAllToddlersFromTripByTripId(int id)
        {
            List<Trip> allTrips = getAllTripsMock();
            List<Toddler> toddlers = allTripsMock.Where(trip => trip.Id.Equals(id)).FirstOrDefault().Toddlers;
            return toddlers;
        }
    }
}
