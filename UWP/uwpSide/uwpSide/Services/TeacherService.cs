using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uwpSide.Interfaces;
using uwpSide.Models;

namespace uwpSide.Services
{
    public class TeacherService : ITeacherService
    {
        public IEnumerable<Teacher> getAllTeachers()
        {
            return MockAPI.MockAPI.getAllTeachersMock();
        }
    }
}
