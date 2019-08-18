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
        //Next are the implementations of the MockApi, delete methods when real API exists.
        public IEnumerable<Teacher> getAllTeachers()
        {
            return MockAPI.MockAPI.getAllTeachersMock();
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
         * public async Task<IEnumerable<Teacher>> getAllTeachers() 
         * {
         *      UriBuilder builder = new UriBuilder(ApiConstants.BaseApiUrl)
         *      {
         *          Path = ApiConstants.Teacher;
         *      };
         *      var teachers = await _genericRepository.GetAsync<IEnumerable<Teacher>>(builder.ToString());
         *      return teachers;
         * }
         * **/
    }
}
