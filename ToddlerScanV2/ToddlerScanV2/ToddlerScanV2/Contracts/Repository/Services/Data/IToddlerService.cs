using System;
using System.Collections.Generic;
using System.Text;
using ToddlerScanV2.Models;

namespace ToddlerScanV2.Contracts.Repository.Services.Data
{
    public interface IToddlerService
    {
        //Mocking
        IEnumerable<Toddler> getAllToddlers();
        Toddler getToddlerById(int id);
        void changeToddlerGradeByToddlerId(int id, string grade);
    }
}
