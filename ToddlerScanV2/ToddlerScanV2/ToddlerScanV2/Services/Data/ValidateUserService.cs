using System;
using System.Collections.Generic;
using System.Text;
using ToddlerScanV2.Contracts.Repository.Services.Data;
using ToddlerScanV2.Models;

namespace ToddlerScanV2.Services.Data
{
    public class ValidateUserService : IValidateUserService
    {
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
    }
}
