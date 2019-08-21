using System;
using System.Collections.Generic;
using System.Text;
using ToddlerScanV2.Contracts.Repository.Services.Data;
using ToddlerScanV2.Models;

namespace ToddlerScanV2.Services.Data
{
    public class ValidateUserService : IValidateUserService
    {

        public ValidateUserService() { }

        //Next are the implementations of the MockApi, delete methods when the API exists.
        public List<User> getAllUsers()
        {
            return MockAPI.MockAPI.getAllUsersMock();
        }

        public void userSignIn(User userToSignIn)
        {
            MockAPI.MockAPI.addUser(userToSignIn);
        }

        public bool ValidateUser(List<User> usersInDatabase, User userToValidate)
        {
            return MockAPI.MockAPI.ValidateUser(usersInDatabase, userToValidate);
        }

        //Next are the implementations if a real API exists.
        /* 
         * private IGenericRepository _genericRepository;
         * public ValidateUserService(IGenericRepository genericRepository)
         * {
         *      genericRepository = AppContainer.Resolve<IGenericRepository>();
         *      _genericRepository = genericRepository;
         * }
         * public async Task<IEnumerable<User>> getAllUsers()
         * {
         *   UriBuilder builder = new UriBuilder(ApiConstants.BaseApiUrl);
         *   {
         *       Path = ApiConstants.User;
         *   };
         *   var users = await _genericRepository.GetAsync<List<User>>(builder.ToString());
         * }
         * public async Task<User> userSignIn (User user)
         * {
         *   UriBuilder builder = new UriBuilder(ApiConstants.BaseApiUrl);
         *   {
         *       Path = ApiConstants.User;
         *   };
         *   var userToAdd = await _genericRepository.PostAsync(builder.ToString(), user);
         *   return userToAdd;
         * }
         */
    }
}
