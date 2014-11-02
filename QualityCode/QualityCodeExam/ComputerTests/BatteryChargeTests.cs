using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Computers;

namespace ComputerTests
{
    [TestClass]
    public class BatteryChargeTests
    {
        [TestMethod]
        public void CheckIfDefaultPowerIs50()
        {
            LaptopBattery battery = new LaptopBattery();

            Assert.AreEqual(50, battery.CurrentBatteryPower());
        }

        [TestMethod]
        public void ChargeWithSupernegativePowerExpectZero()
        {
            LaptopBattery battery = new LaptopBattery();
            battery.Charge(-200);

            Assert.AreEqual(0, battery.CurrentBatteryPower());
        }

        [TestMethod]
        public void ChargeWithSuperpositivePowerExpectHundred()
        {
            LaptopBattery battery = new LaptopBattery();
            battery.Charge(200);

            Assert.AreEqual(100, battery.CurrentBatteryPower());
        }

        [TestMethod]
        public void ChargeWithPositivePowerExpect75()
        {
            LaptopBattery battery = new LaptopBattery();
            battery.Charge(25);

            Assert.AreEqual(75, battery.CurrentBatteryPower());
        }

        [TestMethod]
        public void ChargeWithNegativePowerExpect25()
        {
            LaptopBattery battery = new LaptopBattery();
            battery.Charge(-25);

            Assert.AreEqual(25, battery.CurrentBatteryPower());
        }
    }
}
