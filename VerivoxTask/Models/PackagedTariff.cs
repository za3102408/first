using System;
using System.Collections.Generic;
using System.Text;
using VerivoxTask.Models.Interfaces;


namespace VerivoxTask.Models
{
    public class PackagedTariff : ITariff
    {
        readonly string tariffName = "PackagedTariff";
        readonly decimal centPerkWh = 0.30M;
        readonly decimal baseCostsPerYear = 800M;
        private decimal annualCosts;

        public PackagedTariff(int consumption)
        {
            this.annualCosts = CalculateAnnualCosts(consumption);
        }

        public decimal AnnualCosts => this.annualCosts;
        public string TariffName => this.tariffName;

        private decimal CalculateAnnualCosts(int kWh)
        {
            if (kWh <= 4000)
            {
                return baseCostsPerYear;
            }
            decimal annualCost = baseCostsPerYear + ((kWh - 4000) * centPerkWh);
            return annualCost;
        }
    }
}
