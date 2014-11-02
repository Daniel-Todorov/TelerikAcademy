namespace Cars.Tests.JustMock
{
    using System;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Cars.Contracts;
    using Cars.Tests.JustMock.Mocks;
    using Cars.Controllers;
    using System.Collections.Generic;
    using Cars.Models;


    [TestClass]
    public class CarsControllerTests
    {
        private ICarsRepository carsData;
        private CarsController controller;

        public CarsControllerTests()
            : this(new MoqCarsRepository())
        {
        }

        public CarsControllerTests(ICarsRepositoryMock carsDataMock)
        {
            this.carsData = carsDataMock.CarsData;
        }

        [TestInitialize]
        public void CreateController()
        {
            this.controller = new CarsController(this.carsData);
        }

        [TestMethod]
        public void IndexShouldReturnAllCars()
        {
            var model = (ICollection<Car>)this.GetModel(() => this.controller.Index());

            Assert.AreEqual(4, model.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarIsNull()
        {
            var model = (Car)this.GetModel(() => this.controller.Add(null));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarMakeIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarModelIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        public void AddingCarShouldReturnADetail()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));

            Assert.AreEqual(1, model.Id);
            Assert.AreEqual("BMW", model.Make);
            Assert.AreEqual("A4", model.Model);
            Assert.AreEqual(2009, model.Year);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SortWithEmptyStringShouldReturnAgumentExceptionError()
        {
            var cars = (ICollection<Car>)this.GetModel(() => this.controller.Sort(""));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SortWithInvalidStringShouldReturnAgumentExceptionError()
        {
            var cars = (ICollection<Car>)this.GetModel(() => this.controller.Sort("saddfdfdfg"));
        }

        [TestMethod]
        public void SortByYearShouldProduceFirstCarInTheCollectionToBeWithYear2010()
        {
            var cars = (ICollection<Car>)this.GetModel(() => this.controller.Sort("year"));

            Assert.AreEqual(2010, cars.First().Year, "The year of the first element of the sorted car list must be 2010");
        }

        [TestMethod]
        public void SortByMakeShouldProduceFirstCarInTheCollectionToBeWithMakeAudi()
        {
            var cars = (ICollection<Car>)this.GetModel(() => this.controller.Sort("make"));

            Assert.AreEqual("Audi", cars.First().Make, "The year of the first element of the sorted car list must be Audi");
        }

        [TestMethod]
        public void SearchBMW()
        {
            var bmvs = (ICollection<Car>)this.GetModel(() => this.controller.Search("BMW"));

            Assert.AreEqual(2, bmvs.Count);
        }

        private object GetModel(Func<IView> funcView)
        {
            var view = funcView();
            return view.Model;
        }
    }
}
