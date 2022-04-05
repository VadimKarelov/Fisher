using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fisher
{
    class Fishing
    {
        public int Resource { get; private set; }
        public double Capital { get; private set; }
        public double Income { get; private set; }
        public double Consumption { get; private set; }
        public double PersonalGain { get; private set; }

        public int Fleet { get; private set; } = 1;
        public int Crew { get; private set; }

        public double KInvestment { get; set; } = 0.2;
        public double KSaving { get; set; } = 0.2;

        public double KReproduction { get; set; }
        public double MarketPrice { get; set; }
        public double ShipPrice { get; set; }
        public double ShipLife { get; set; }
        public double ShipProduction { get; set; }
        public double Salary { get; set; }
        public int CrewNumber { get; set; } = 30;

        private int prevFish;
        private double kProduction = 1;

        public Fishing(int initResource, double initCapital)
        {
            Resource = initResource;
            Capital = initCapital;
            Crew = Fleet * CrewNumber;
        }

        public void Update(bool regulation)
        {
            prevFish = Resource;
            Resource = (int)(Resource * KReproduction);

            int production = (int)(ShipProduction * Fleet * GetEfficiency(Resource) * kProduction);

            if (production >= Resource || Resource - production < 10)
                production = 0;

            Resource -= production;

            CountIncome(production);
            CountConsumption();

            if (regulation) Control();

            Distribution();
            CorrectData();
        }

        private void Control()
        {
            // если с рыбой все хорошо
            if (Resource > prevFish)
            {
                if (Capital < ShipPrice * 2 && Capital - Consumption > 0)
                {
                    // накопление
                    KInvestment = 0;
                    KSaving = 0.9;
                }
                else
                {
                    // трата
                    KInvestment = 0.9;
                    KSaving = 0.05;
                }

                kProduction = 1;
            }
            // восстановление рыбы
            else
            {
                KInvestment = 0;
                KSaving = 0.5;

                kProduction = (double)(prevFish - Resource) / Resource;
            }
        }

        private double GetEfficiency(int resource)
        {
            if (resource > 1000)
                return 1;
            else
                return Math.Sqrt(resource / 1000.0);
        }

        private void CountIncome(int production)
        {
            Income = production * MarketPrice;
            Capital += Income;
        }

        private void CountConsumption()
        {
            double amortization = Fleet * ShipPrice / ShipLife;
            double shipTax = Fleet;
            double allSalaries = Crew * Salary;
            double NDFL = allSalaries * 0.13;

            Consumption = amortization + shipTax + allSalaries + NDFL;
            Capital -= Consumption;
        }

        private void Distribution()
        {
            double toPersonal = 0, toShips = 0;

            if (Income - Consumption > 0)
                toPersonal = (Income - Consumption) * (1 - KInvestment - KSaving);

            if (Capital > 0)
                toShips = (int)(Math.Truncate(Capital * KInvestment / ShipPrice) * ShipPrice);

            BuyShips((int)(toShips / ShipPrice));

            Capital = Capital - toPersonal - toShips;
            PersonalGain += toPersonal;
        }

        private void CorrectData()
        {
            Crew = Fleet * CrewNumber;
        }

        private void BuyShips(int count)
        {
            Fleet += count;
        }
    }
}
