using System;
using System.Collections.Generic;
using System.Text;
using ToddlerScanV2.Contracts.Repository.Services.Data;
using ToddlerScanV2.Models;

namespace ToddlerScanV2.Services.Data
{
    public class TeacherService : ITeacherService
    {
        //Next are the implementations of the MockApi, delete methods when the API exists.

        public Teacher getTeacherById(int id)
        {
            return MockAPI.MockAPI.getTeacherById(id);
        }

        //Next are the implementations if a real API exists.
        /*
         * private IGenericRepository _genericRepository;
         * public TeacherService(IGenericRepository genericRepository)
         * {
         *      genericRepository = AppContainer.Resolve<IGenericRepository>();
         *      _genericRepository = genericRepository;
         * }
         * 
         * public async Task<Teacher> getTeacherById(int id) 
         * {
         *      UriBuilder builder = new UriBuilder(ApiConstants.BaseApiUrl)
         *      {
         *          Path = $"{ApiConstants.Trip/{id};
         *      };
         *      
         *      return await _genericRepository.GetAsync<Teacher>(builder.ToString());
         * }
         */
    }
}
