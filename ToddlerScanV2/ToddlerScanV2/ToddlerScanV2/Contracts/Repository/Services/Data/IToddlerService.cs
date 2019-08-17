using System;
using System.Collections.Generic;
using System.Text;
using ToddlerScanV2.Models;

namespace ToddlerScanV2.Contracts.Repository.Services.Data
{
    public interface IToddlerService
    {
        //Next are methods that are used if the MockAPI is still active
        IEnumerable<Toddler> getAllToddlers();
        Toddler getToddlerById(int id);
        void changeToddlerGradeByToddlerId(int id, string grade);

        //Next are methods that need to be implemented if a real API exists
        /*
         * Task<IEnumberable<Toddler>> getAllToddlers();
         * Task<Toddler> getToddlerById(int id);
         * Task<Toddler> changeToddlerGradeByToddlerId(int id, string grade);
         */

    }
}
