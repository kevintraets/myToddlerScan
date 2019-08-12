using System;
using System.Collections.Generic;
using System.Text;
using ToddlerScanV2.Contracts.Repository.Services.Data;
using ToddlerScanV2.Models;

namespace ToddlerScanV2.Services.Data
{
    public class TeacherService : ITeacherService
    {
        public Teacher getTeacherById(int id)
        {
            return MockAPI.MockAPI.getTeacherById(id);
        }
    }
}
