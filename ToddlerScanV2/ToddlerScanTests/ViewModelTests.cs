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

        public ViewModelTests() { }

        [TestMethod]
        public void Check_If_Name_Is_Empty_On_Startup_In_Login()
        {
            var mockNavigation = new Mock<INavigationService>();
            var mockValidation = new Mock<IValidateUserService>();
            var loginScreen = new LoginViewModel(mockNavigation.Object, mockValidation.Object);
            Assert.IsTrue(loginScreen.Username.Equals(""));
        }

        [TestMethod]
        public void Check_If_Toddler_Change_Grade_Has_A_Value()
        {
            var mockNavigation = new Mock<INavigationService>();
            var changeGrade = new ChangeGradeViewModel(mockNavigation.Object);
            Assert.IsNotNull(changeGrade.changeGradeButtonClicked);
        }

        [TestMethod]
        public void Check_If_Toddlers_Are_Get_On_Initialization()
        {
            var mockNavigation = new Mock<INavigationService>();
            var mockToddlers = new Mock<IToddlerService>();
            var allToddlers = new AllToddlersViewModel(mockNavigation.Object, mockToddlers.Object);
            Assert.IsNotNull(allToddlers.MockToddlers);
        }
    }
}
