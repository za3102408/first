using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VerivoxTask.Models;

namespace VerivoxTests
{
    [TestClass]
    public class BasicElectricityTariffTests
    {
        [TestMethod]
        public void CalculateAnnualCosts_AverageConsumption_Returns830()
        {
            var currentConsumption = 3500;
            decimal expectedCost = 830;

            var tariff = new BasicElecticityTariff(currentConsumption);
            var actualCost = tariff.AnnualCosts;

            Assert.AreEqual(expectedCost, actualCost);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateAnnualCosts_ConsumptionLowerThan0_ThrowsArgumentException()
        {
            var currentConsumption = -2000;
            var tariff = new BasicElecticityTariff(currentConsumption);

        }

        [TestMethod]
        public void CalculateAnnualCosts_ConsumptionEquals0_Returns60()
        {
            var currentConsumption = 0;
            decimal expectedCost = 60;

            var tariff = new BasicElecticityTariff(currentConsumption);
            var actualCost = tariff.AnnualCosts;

            Assert.AreEqual(expectedCost, actualCost);
        }
    }
}
