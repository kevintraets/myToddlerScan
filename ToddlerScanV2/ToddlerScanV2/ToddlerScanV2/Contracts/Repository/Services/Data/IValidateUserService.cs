using System;
using System.Collections.Generic;
using System.Text;
using ToddlerScanV2.Models;

namespace ToddlerScanV2.Contracts.Repository.Services.Data
{
    public interface IValidateUserService
    {
        //Next are methods that are used if the MockAPI is still active
        List<User> getAllUsers();
        bool ValidateUser(List<User> usersInDatabase, User tryToLoginUser);
        void userSignIn(User userToSignIn);

        //Next are methods that need to be implemented if a real API exists
        /*
         * Task<IEnumberable<User>> getAllUsers();
         * Task<bool> ValidateUser(List<User> userInDatabase, User tryToLoginUser);
         * Task<User> userSignIn(User user);
         */
    }
}
