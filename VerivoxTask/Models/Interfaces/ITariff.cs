using System;
using System.Collections.Generic;
using System.Text;

namespace VerivoxTask.Models.Interfaces
{
    interface ITariff
    {
        string TariffName { get; }
        decimal CalculateAnnualCosts(int kWh);
    }
}
