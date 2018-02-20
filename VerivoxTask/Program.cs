using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using VerivoxTask.Models;
using VerivoxTask.Models.Interfaces;

namespace VerivoxTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentConsumption = 6000;
            CompareTariffs(currentConsumption);
        }
        private static IEnumerable<ITariff> GetTariffList(int consumption)
        {
            var tariffsList = new List<ITariff>()
            {
                new BasicElecticityTariff(consumption),
                new PackagedTariff(consumption)
            };
            return tariffsList.OrderBy(t => t.AnnualCosts);

        }

        private static void CompareTariffs(int kWh)
        {
            Console.WriteLine($"Consumption: {kWh}");

            var sortedTariffs = GetTariffList(kWh);
            foreach (var tariff in sortedTariffs)
            {
                Console.WriteLine($"Tariff Name: {tariff.TariffName}.\nTariff Costs: {tariff.AnnualCosts:N2} Euro.\n");
            }
        }
    }


}
