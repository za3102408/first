using Microsoft.VisualStudio.TestTools.UnitTesting;
using VerivoxTask.Models;

namespace VerivoxTests
{
    [TestClass]
    public class BasicElectricityTariffTests
    {
        [TestMethod]
        public void CalculateAnnualCosts_AverageConsumption_Returns830()
        {
            var tariff = new BasicElecticityTariff();
            var currentConsumption = 3500;
            decimal expectedCost = 830;

            var actualCost = tariff.CalculateAnnualCosts(currentConsumption);

            Assert.AreEqual(expectedCost, actualCost);
        }

        [TestMethod]
        public void CalculateAnnualCosts_ConsumptionLowerThan0_Returns60()
        {
            var tariff = new BasicElecticityTariff();
            var currentConsumption = -2000;
            decimal expectedCost = 60;

            var actualCost = tariff.CalculateAnnualCosts(currentConsumption);

            Assert.AreEqual(expectedCost, actualCost);
        }

        [TestMethod]
        public void CalculateAnnualCosts_ConsumptionEquals0_Returns60()
        {
            var tariff = new BasicElecticityTariff();
            var currentConsumption = 0;
            decimal expectedCost = 60;

            var actualCost = tariff.CalculateAnnualCosts(currentConsumption);

            Assert.AreEqual(expectedCost, actualCost);
        }
    }
}
