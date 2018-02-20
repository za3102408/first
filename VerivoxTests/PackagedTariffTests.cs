using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VerivoxTask.Models;


namespace VerivoxTests
{
    [TestClass]
    public class PackagedTariffTests
    {
        [TestMethod]
        public void CalculateAnnualCosts_ConsumptionUnder4000_Returns800()
        {
            var currentConsumption = 3500;
            decimal expectedCost = 800;

            var tariff = new PackagedTariff(currentConsumption);
            var actualCost = tariff.AnnualCosts;

            Assert.AreEqual(expectedCost, actualCost);
        }

        [TestMethod]
        public void CalculateAnnualCosts_ConsumptionAbove4000_ReturnsCalculatedCost()
        {
            var currentConsumption = 4500;
            decimal expectedCost = 950;

            var tariff = new PackagedTariff(currentConsumption);
            var actualCost = tariff.AnnualCosts;

            Assert.AreEqual(expectedCost, actualCost);
        }

        [TestMethod]
        public void CalculateAnnualCosts_ConsumptionEquals0_Returns800()
        {
            var currentConsumption = 0;
            decimal expectedCost = 800;

            var tariff = new PackagedTariff(currentConsumption);
            var actualCost = tariff.AnnualCosts;

            Assert.AreEqual(expectedCost, actualCost);
        }
        [TestMethod]
        public void CalculateAnnualCosts_ConsumptionLowerThan0_Returns800()
        {
            var currentConsumption = -2000;
            decimal expectedCost = 800;

            var tariff = new PackagedTariff(currentConsumption);
            var actualCost = tariff.AnnualCosts;

            Assert.AreEqual(expectedCost, actualCost);
        }
    }
}
