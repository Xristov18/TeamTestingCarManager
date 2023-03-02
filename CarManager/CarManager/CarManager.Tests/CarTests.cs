using NUnit.Framework;
using System;
using CarManager;

namespace CarManager.Tests
{
    [TestFixture]
    public class CarTests
    {
        
        
            [SetUp]
            public void Setup()
            {
            }

            [Test]
            public void ConstructorShouldInitializeCorrectly()
            {
            //public Car(string make, string model, double fuelConsumption, double fuelCapacity)
            string make = "aaa";
            string model = "bbb";
            double fuelConsumption = 5;
            double fuelCapacity = 40;
            Car car = new Car(make, model, fuelConsumption, fuelCapacity);
            Assert.AreEqual(make, car.Make);
            Assert.AreEqual(model, car.Model);
            Assert.AreEqual(fuelConsumption, car.FuelConsumption);
            Assert.AreEqual(fuelCapacity, car.FuelCapacity);
            Assert.AreEqual(0, car.FuelAmount);
            


            }

            [Test]
            public void ModelShouldThrowArgExWhenNameIsNull()
            {
            string make = "aaa";
            string model = null;
            double fuelConsumption = 5;
            double fuelCapacity = 40;

            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));

            }

            [Test]
            public void MakeShouldThrowArgExWhenNameIsNull()
            {
            string make = null;
            string model = "A3";
            double fuelConsumption = 5;
            double fuelCapacity = 40;

            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));


            }

        [Test]
            public void FuelConsumptionShouldThrowArgExWhenIsBellowZero()
            {

            string make = "aaa";
            string model = "A3";
            double fuelConsumption = -1;
            double fuelCapacity = 40;

            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));
            }
    

            [Test]
            public void FuelConsumptionShouldThrowArgExWhenIsZero()
            {
            string make = "aaa";
            string model = "A3";
            double fuelConsumption = 0;
            double fuelCapacity = 40;

            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity)); 
            }

            [Test]
            public void FuelCapacityShouldThrowArgExWhenIsZero()
            {
            string make = "aaa";
            string model = "A3";
            double fuelConsumption = 5;
            double fuelCapacity = 0;
            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));
            }

            [Test]
            public void FuelCapacityShouldThrowArgExWhenIsBellowZero()
            {
            string make = "aaa";
            string model = "A3";
            double fuelConsumption = 5;
            double fuelCapacity = -1;
            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));
            }
         

        [TestCase (null, "A3", 20, 100)]
        [TestCase ("Audi", null, 20, 100)]
        [TestCase ("Audi", "A3", 0, 100)]
        [TestCase ("Audi", "A3", 20, -1)]
        public void ValidateAllProperties(string make, string model, double fuelConsumption, double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Car car = new Car(make, model, fuelConsumption, fuelCapacity);
            });
        }


            [Test]
            public void ShouldRefuelNormally()
            {
               string make = "aaa";
               string model = "bbb";
               double fuelConsumption = 5;
               double fuelCapacity = 40;
               double fuelToRefuel = 30;
               Car car = new Car(make, model, fuelConsumption, fuelCapacity);
               car.Refuel(fuelToRefuel);

            }

            [Test]
            public void ShouldRefuelUntillTotalFuelCapacity()
            {
                //TO DO
            }

            [Test]
            //TO DO
            public void ShouldRefuelThrowArgExWhenInputAmountIsBellowZero(double inputAmount)
            {
                //TO DO
            }

            [Test]
            public void ShouldDriveNormally()
            {
                Car car = new Car("Vw", "Golf", 2, 100);
                //TO DO
            }

            [Test]
            public void DriveShouldThrowInvalidOperationExceptionWhenFuelAmountIsNotEnough()
            {
                //TO DO
            }
        }

    }
