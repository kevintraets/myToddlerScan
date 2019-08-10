using NUnit.Framework;
using uwpSide.Bootstrap;
using uwpSide.Interfaces;
using uwpSide.Services;
using uwpSide.ViewModels;

namespace Tests
{
    public class Tests
    {
        private ITripService tripService;
        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void Test1()
        {
            tripService = AppContainer.Resolve<ITripService>();
            var tripviewModel = new TripViewModel(tripService);
            Assert.IsInstanceOf(typeof(TripViewModel), tripviewModel);
        }
    }
}