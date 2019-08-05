using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ToddlerScanV2.Contracts.Repository.Services.Data;
using ToddlerScanV2.Contracts.Repository.Services.General;
using ToddlerScanV2.Models;
using ToddlerScanV2.Services.Data;
using ToddlerScanV2.Services.General;
using ToddlerScanV2.ViewModels;

namespace ToddlerScanTests
{
    [TestClass]
    public class ViewModelTests
    {
        private Mock<INavigationService> mockNavigation;
        private Mock<IValidateUserService> mockValidation;
        private Mock<IToddlerService> mockToddlers;

        [TestInitialize]
        public void Setup()
        {
            mockNavigation = new Mock<INavigationService>();
            mockValidation = new Mock<IValidateUserService>();
            mockToddlers = new Mock<IToddlerService>();
        }

        public ViewModelTests() { }

        //LoginViewModel
        [TestMethod]
        public void Check_If_Name_Is_Empty_On_Startup_In_Login()
        {
            var loginScreen = new LoginViewModel(mockNavigation.Object, mockValidation.Object);
            Assert.IsTrue(loginScreen.Username.Equals(""));
        }

        [TestMethod]
        public void Check_If_Password_Is_Empty_On_Startup_In_Login()
        {
            var loginScreen = new LoginViewModel(mockNavigation.Object, mockValidation.Object);
            Assert.IsTrue(loginScreen.Password.Equals(""));
        }

        [TestMethod]
        public void Check_If_User_Has_Value_On_Submit()
        {
            var loginScreen = new LoginViewModel(mockNavigation.Object, mockValidation.Object);
            Assert.IsNotNull(loginScreen.loginButtonPressed);
        }

        //ChangeGradeViewModel
        [TestMethod]
        public void Check_If_Toddler_Change_Grade_Has_A_Value()
        {
            var changeGrade = new ChangeGradeViewModel(mockNavigation.Object);
            Assert.IsNotNull(changeGrade.changeGradeButtonClicked);
        }

        public void Check_If_Toddler_Value_On_Initialization()
        {
            var changeGrade = new ChangeGradeViewModel(mockNavigation.Object);
            Assert.IsNotNull(changeGrade.SelectedToddler);
        }

        //AllToddlersViewModel
        [TestMethod]
        public void Check_If_Toddlers_Are_Get_On_Initialization()
        {
            var allToddlers = new AllToddlersViewModel(mockNavigation.Object, mockToddlers.Object);
            Assert.IsNotNull(allToddlers.MockToddlers);
        }
    }
}
