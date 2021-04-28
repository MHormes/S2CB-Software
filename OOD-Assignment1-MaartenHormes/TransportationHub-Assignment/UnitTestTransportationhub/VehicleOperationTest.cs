using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TransportationHub_Assignment;

namespace UnitTestTransportationhub
{
    [TestClass]
    public class VehicleOperationTest
    {
        [TestMethod]
        public void TestAddingNewVehiclesOfEachType()
        {
            TransportationHub t = new TransportationHub("Test");
            t.AddVehicle(0, 5, 0, 0, "Car", "123-AB-1", 0.5);
            t.AddVehicle(1, 5, 150, 150, "Van", "456-AB-1", 0.5);
            t.AddVehicle(2, 0, 200, 200, "Truck", "789-AB-1", 0.5);

            List<Vehicle> test = t.GetAllVehicles();

            Assert.AreEqual("123-AB-1" , test[0].LicensePlate);
            Assert.AreEqual("456-AB-1", test[1].LicensePlate);
            Assert.AreEqual("789-AB-1", test[2].LicensePlate);
        }

        [TestMethod]
        [ExpectedException(typeof(NoVehicleTypeSelectedException))]
        public void TestAddingNewVehiclesWithoutTypeSelected()
        {
            TransportationHub t = new TransportationHub("Test");
            t.AddVehicle(-1, 5, 0, 0, "Car", "123-AB-1", 0.5);
        }


        [TestMethod]
        [ExpectedException(typeof(LicensePlateException))]
        public void TestAddingNewVehicleWithIncorrectLicense()
        {
            TransportationHub t = new TransportationHub("Test");
            t.AddVehicle(0, 5, 0, 0, "Car", "13-AB-1", 0.5);
        }


        [TestMethod]
        public void TestGettingAvailableVehicles()
        {
            TransportationHub t = new TransportationHub("Test");
            t.AddVehicle(0, 5, 0, 0, "Car", "123-AB-1", 0.5);
            t.AddVehicle(2, 0, 200, 200, "Truck", "789-AB-1", 0.5);

            Vehicle vPass = t.GetAvailableVehicle(true, 5, 0, 0);
            Vehicle vCargo = t.GetAvailableVehicle(false, 0, 150, 150);

            Assert.AreEqual("123-AB-1", vPass.LicensePlate);
            Assert.AreEqual("789-AB-1", vCargo.LicensePlate);
        }

        [TestMethod]
        public void TestGettingAvailableVehiclesWithoutAnyVehicle()
        {
            TransportationHub t = new TransportationHub("Test");

            Vehicle v = t.GetAvailableVehicle(true, 0, 0, 0);
            Assert.AreEqual(null, v);
        }

        [TestMethod]
        public void TestListSortingVehicles()
        {
            TransportationHub t = new TransportationHub("Test");
            t.AddVehicle(0, 5, 0, 0, "Car", "123-AB-1", 0.5);
            t.AddVehicle(2, 0, 200, 200, "Truck", "789-AB-1", 0.5);
            t.AddVehicle(1, 5, 150, 150, "Van", "456-AB-1", 0.5);

            List<Vehicle> test = t.GetAllVehicles();
            Assert.AreEqual("789-AB-1", test[2].LicensePlate);

        }

        [TestMethod]
        public void TestSaveAllVehicles()
        {
            TransportationHub t = new TransportationHub("Test");
            t.AddVehicle(0, 5, 0, 0, "Car", "123-AB-1", 0.5);
            t.AddVehicle(1, 5, 150, 150, "Van", "456-AB-1", 0.5);
            t.AddVehicle(2, 0, 200, 200, "Truck", "789-AB-1", 0.5);

            Assert.AreEqual(null, t.SaveAllVehicles());
        }

        [TestMethod]
        public void TestLoadAllVehicles()
        {
            TransportationHub t = new TransportationHub("Test");
            t.AddVehicle(0, 5, 0, 0, "Car", "123-AB-1", 0.5);
            t.AddVehicle(1, 5, 150, 150, "Van", "456-AB-1", 0.5);
            t.AddVehicle(2, 0, 200, 200, "Truck", "789-AB-1", 0.5);
            t.SaveAllVehicles();
            Assert.AreEqual(null, t.LoadAllVehicles());
        }
    }
}
