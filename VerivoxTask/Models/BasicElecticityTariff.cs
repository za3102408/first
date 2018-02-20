using System;
using System.Collections.Generic;
using System.Text;
using VerivoxTask.Models.Interfaces;


namespace VerivoxTask.Models
{
    public class BasicElecticityTariff : ITariff
    {
        readonly string tariffName = "BasicElecticityTariff";
        readonly decimal centPerkWh = 0.22M;
        readonly decimal baseCostsPerMonth = 5M;
        private decimal annualCosts;

        public BasicElecticityTariff(int consumption)
        {
            this.annualCosts = CalculateAnnualCosts(consumption);
        }

        public decimal AnnualCosts => this.annualCosts;
        public string TariffName => this.tariffName;

        private decimal CalculateAnnualCosts(int kWh)
        {
            if(kWh < 0)
            {
                throw new ArgumentException("Consumption can't be lower than zero.");
            }
            decimal annualCost = baseCostsPerMonth * 12 + kWh * centPerkWh;
            return annualCost;
        }
    }
}
