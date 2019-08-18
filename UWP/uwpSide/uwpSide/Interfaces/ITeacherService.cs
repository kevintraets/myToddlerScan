using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uwpSide.Models;

namespace uwpSide.Interfaces
{
    public interface ITeacherService
    {
        //Next methods are used if the MockAPI is still active.
        IEnumerable<Teacher> getAllTeachers();


        //Next are methods that need to be implemented if a real API exists.
        //Task<IEnumerable<Teacher>> getAllTeachers();
    }
}
