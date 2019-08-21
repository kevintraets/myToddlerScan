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


        //Next are the implementations of the MockApi, delete methods when the API exists.
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

        //Next are the implementations if a real API exists.
        /*
         * private IGenericRepository _genericRepository;
         * public ToddlerService(IGenericRepository genericRepository)
         * {
         *      genericRepository = AppContainer.Resolve<IGenericRepository>();
         *      _genericRepository = genericRepository
         * }
         * 
         * public async Task<IEnumberable<Toddler>> getAllToddlers()
         * {
         *      UriBuilder builder = new UriBuilder(ApiConstants.BaseApiUrl)
         *      {
         *          Path = ApiConstants.Toddler;
         *      };
         *      var toddlers = await _genericRepository.GetAsync<List<Toddler>>(builder.ToString());
         *      return toddlers;
         * }
         * public async Task<Toddler> getToddlerById(int id)
         * {
         *      UriBuilder builder = new UriBuilder(ApiConstants.BaseApiUrl)
         *      {
         *          Path = $"{ApiConstants.Toddler}/{id}";
         *      }
         *      return await _genericRepository.GetAsync<Toddler>(builder.ToString());
         * }
         */
    }
}
