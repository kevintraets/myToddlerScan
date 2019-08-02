using System;
using System.Collections.Generic;
using System.Text;
using ToddlerScanV2.Models;

namespace ToddlerScanV2.Contracts.Repository.Services.Data
{
    public interface IValidateUserService
    {
        //Mocking
        List<User> getAllUsers();
        bool ValidateUser(List<User> usersInDatabase, User tryToLoginUser);
        void userSignIn(User userToSignIn);
    }
}
