using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using VerivoxTask.Models.Interfaces;
using VerivoxTask.Models;

namespace VerivoxTask
{
    class TariffComparer
    {
        public IEnumerable<ITariff> GetTariffList(int consumption)
        {
            var tariffsList = new List<ITariff>()
            {
                new BasicElecticityTariff(consumption),
                new PackagedTariff(consumption)
            };
            return tariffsList.OrderBy(t => t.AnnualCosts);

        }
    }
}
