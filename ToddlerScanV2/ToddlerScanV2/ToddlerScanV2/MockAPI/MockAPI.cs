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
                new Toddler {Id = 2, FirstName = "C3PO", LastName = "", Grade = "2"},
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
            foreach (User user in allUsers)
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

        //----------------------------API Scans----------------------------------------
        private static List<Scan> allScans = new List<Scan>
        {
            new Scan
            {
                Id = 1,
                Name = "TatooineScan1",
                TeacherId = 1,
                teacher = new Teacher {Id=1, FirstName="Darth", LastName="Vader"},
                TripId = 3,
                trip = new Trip {
                    Id =3,
                    Date =DateTimeOffset.Now,
                    TeacherId = 1,
                    teacher = new Teacher {Id=1, FirstName="Darth", LastName="Vader"},
                    Title = "Tatooine",
                    Toddlers = new List<Toddler>
                    {
                        new Toddler {Id = 1, FirstName = "R2D2", LastName = "", Grade = "1"},
                        new Toddler {Id = 1, FirstName = "C3PO", LastName = "", Grade = "2"},
                        new Toddler {Id = 3, FirstName = "Luke", LastName = "Skywalker", Grade = "3"}
                    }
                }
            },

             new Scan
             {
                Id = 2,
                Name = "DagobahScan1",
                TeacherId = 2,
                teacher = new Teacher {Id=2, FirstName="Master", LastName="Yoda"},
                TripId = 1,
                trip = new Trip {
                    Id =1,
                    Date =DateTimeOffset.Now,
                    TeacherId = 2,
                    teacher = new Teacher {Id=2, FirstName="Master", LastName="Yoda"},
                    Title = "Dagobah",
                    Toddlers = new List<Toddler>
                    {
                        new Toddler {Id = 1, FirstName = "R2D2", LastName = "", Grade = "1"},
                        new Toddler {Id = 3, FirstName = "Luke", LastName = "Skywalker", Grade = "3"}
                    }
                }
             }

        };
        public static void addScan(Scan scan)
        {
            allScans.Add(scan);
        }

        //-----------------------------API Teachers------------------------------------

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

        public static Teacher getTeacherById(int id)
        {
            return allTeachersMock.Where(teacher => teacher.Id.Equals(id)).FirstOrDefault();
        }

        //------------------------------API Trips---------------------------------------------------------
        private static List<Trip> allTripsMock = new List<Trip>
        {
            new Trip
            {
                Id = 1,
                Title = "Dagobah",
                Date = DateTime.Now,
                TeacherId = 2,
                teacher = new Teacher {Id = 2, FirstName = "Master", LastName = "Yoda"},
                Toddlers = new List<Toddler>
                {
                new Toddler {Id = 1, FirstName = "R2D2", LastName = "", Grade = "1"},
                new Toddler {Id = 3, FirstName = "Luke", LastName = "Skywalker", Grade = "3"}
                }
            },

            new Trip
            {
                Id = 2,
                Title = "Hoth",
                Date = DateTime.Now,
                TeacherId = 1,
                teacher = new Teacher {Id = 1, FirstName = "Han", LastName = "Solo"},
                Toddlers = new List<Toddler>
                {
                new Toddler {Id = 2, FirstName = "C3PO", LastName = "", Grade = "2"},
                new Toddler {Id = 3, FirstName = "Luke", LastName = "Skywalker", Grade = "3"}
                }
            },

            new Trip
            {
                Id = 3,
                Title = "Tatooine",
                Date = DateTime.Now,
                TeacherId = 3,
                teacher = new Teacher {Id = 3, FirstName = "Darth", LastName = "Vader"},
                Toddlers = new List<Toddler>
                {
                new Toddler {Id = 1, FirstName = "R2D2", LastName = "", Grade = "1"},
                new Toddler {Id = 1, FirstName = "C3PO", LastName = "", Grade = "2"},
                new Toddler {Id = 3, FirstName = "Luke", LastName = "Skywalker", Grade = "3"}
                }
            },

            new Trip
            {
                Id = 4,
                Title = "Death Star",
                Date = DateTime.Now,
                TeacherId = 3,
                teacher = new Teacher {Id = 3, FirstName = "Darth", LastName = "Vader"},
                Toddlers = new List<Toddler>
                {
                new Toddler {Id = 1, FirstName = "R2D2", LastName = "", Grade = "1"},
                new Toddler {Id = 3, FirstName = "Luke", LastName = "Skywalker", Grade = "3"}
                }
            }

        };

        public static List<Trip> getAllTripsMock()
        {
            return allTripsMock;
        }

        public static IEnumerable<Toddler> getAllToddlersFromTripByTripId(int id)
        {
            List<Trip> allTrips = getAllTripsMock();
            List<Toddler> toddlers = allTripsMock.Where(trip => trip.Id.Equals(id)).FirstOrDefault().Toddlers;
            return toddlers;
        }

        public static void addTrip(Trip trip)
        {
            allTripsMock.Add(trip);
        }

        public static int getNumberOfTrips()
        {
            return allTripsMock.Count();
        }

        public static Trip getTripById(int id)
        {
            return allTripsMock.Where(trip => trip.Id.Equals(id)).FirstOrDefault();
        }
    }
}
