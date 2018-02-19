using System;
using System.Collections.Generic;
using System.Text;
using VerivoxTask.Models.Interfaces;


namespace VerivoxTask.Models
{
    public class PackagedTariff : ITariff
    {
        readonly string tariffName = "PackagedTariff";
        readonly decimal CentPerkWh = 0.30M;
        readonly decimal baseCostsPerYear = 800M;


        public string TariffName => this.tariffName;
        public decimal CalculateAnnualCosts(int kWh)
        {
            if (kWh <= 4000)
            {
                return baseCostsPerYear;
            }
            decimal AnnualCosts = baseCostsPerYear + ((kWh - 4000) * CentPerkWh);
            return AnnualCosts;
        }
    }
}
