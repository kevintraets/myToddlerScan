using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uwpSide.Interfaces;
using uwpSide.Models;

namespace uwpSide.Services
{
    public class ToddlerService : IToddlerService
    {
        //Next are the implementations of the MockApi, delete methods when the real API exists.
        public IEnumerable<Toddler> getAllToddlers()
        {
            return MockAPI.MockAPI.GetAllToddlersMock();
        }

        public void addToddler(Toddler toddler)
        {
            MockAPI.MockAPI.addToddler(toddler);
        }

        //Next are the implentations if the real API exists.
        /*
         * private IGenericRepository _genericRepository;
         * public ToddlerService(IGenericRepository genericRepository)
         * {
         *      genericRepository = AppContainer.Resolve<IGenericRepository>();
         *      _genericRepository = genericRepository;
         * }
         * 
         * public async Task<IEnumerable<Toddler>> getAllToddlers() 
         * {
         *      UriBuilder builder = new UriBuilder(ApiConstants.BaseApiUrl)
         *      {
         *          Path = ApiConstants.Toddler;
         *      };
         *      var toddlers = await _genericRepository.GetAsync<IEnumerable<Toddler>>(builder.ToString));
         *      return toddlers;
         * }
         * 
         * public async Task<Toddler> addToddler(Toddler toddler)
         * {
         *      UriBuilder builder = new UriBuilder(ApiConstants.BaseApiUrl)
         *      {
         *          Path = ApiConstants.Toddler;
         *      }
         *      var toddlerToPost = await _genericRepository.PostAsync(builder.ToString(), toddler);
         *      return toddlerToPost;
         * }
         * **/
    }
}
