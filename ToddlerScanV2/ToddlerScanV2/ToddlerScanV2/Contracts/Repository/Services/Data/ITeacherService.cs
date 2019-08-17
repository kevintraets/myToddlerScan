using System;
using System.Collections.Generic;
using System.Text;
using ToddlerScanV2.Models;

namespace ToddlerScanV2.Contracts.Repository.Services.Data
{
    public interface ITeacherService
    {
        //Next are methods that are used if the MockAPI is still active
        Teacher getTeacherById(int id);

        //Next are methods that need to be implemented if a real API exists

        //Task<Teacher> getTeacherById(int id);


    }
}
