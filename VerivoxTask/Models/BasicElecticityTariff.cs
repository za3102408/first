using System;
using System.Collections.Generic;
using System.Text;
using VerivoxTask.Models.Interfaces;


namespace VerivoxTask.Models
{
    public class BasicElecticityTariff : ITariff
    {
        readonly string tariffName = "BasicElecticityTariff";
        readonly decimal CentPerkWh = 0.22M;
        readonly decimal baseCostsPerMonth = 5M;


        public string TariffName => this.tariffName;
        public decimal CalculateAnnualCosts(int kWh)
        {
            if(kWh <= 0)
            {
                return 12 * baseCostsPerMonth;
            }
            decimal AnnualCosts = baseCostsPerMonth * 12 + kWh * CentPerkWh;
            return AnnualCosts;
        }
    }
}
