using System;
using System.Collections.Generic;
using VerivoxTask.Models;
using VerivoxTask.Models.Interfaces;

namespace VerivoxTask
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Hello World!");
            var currentConsumption = 6000;
            var tariffsList = GetTariffList();
            CompareConsumtion(tariffsList, currentConsumption);
        }
        private static IEnumerable<ITariff> GetTariffList()
        {
            var tariffsList = new List<ITariff>()
            {
                new BasicElecticityTariff(),
                new PackagedTariff()
            };
            return tariffsList;

        }

        private static void CompareConsumtion(IEnumerable<ITariff> tariffs, int kWh)
        {
            foreach (var tariff in tariffs)
            {
                Console.WriteLine($"Tariff Name: {tariff.TariffName}.");
                Console.WriteLine($"\tTariff Costs: {tariff.CalculateAnnualCosts(kWh)} Euro.\n");
            }
        }
    }


}
