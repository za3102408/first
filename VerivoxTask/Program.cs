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
            var tariffComparer = new TariffComparer();
            var tariffList = tariffComparer.GetTariffList(currentConsumption);

            DisplayComparison(tariffList, currentConsumption);
        }

        private static void DisplayComparison(IEnumerable<ITariff> tariffs, int kWh)
        {
            Console.WriteLine($"Consumption: {kWh}");
            foreach (var tariff in tariffs)
            {
                Console.WriteLine($"Tariff Name: {tariff.TariffName}.\nTariff Costs: {tariff.AnnualCosts:N2} Euro.\n");
            }
        }
    }


}
