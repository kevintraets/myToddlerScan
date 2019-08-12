using System;
using System.Collections.Generic;
using System.Text;
using ToddlerScanV2.Contracts.Repository.Services.Data;
using ToddlerScanV2.Models;

namespace ToddlerScanV2.Services.Data
{
    public class ToddlerService : IToddlerService
    {
        public ToddlerService() { }


        //Mocking
        public void changeToddlerGradeByToddlerId(int id, string grade)
        {
            MockAPI.MockAPI.changeToddlerGradeMock(id, grade);
        }

        public IEnumerable<Toddler> getAllToddlers()
        {
           return MockAPI.MockAPI.GetAllToddlersMock();
        }

        public Toddler getToddlerById(int id)
        {
            return MockAPI.MockAPI.getToddlerByIdMock(id);
        }
    }
}
