using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cina
{
    class CinaFestiva
    {
        public int NumarDePersoane;
        public decimal CostBauturaPersoana;
        public decimal CostDecoratii = 0;
        public const int CostMincarePersoana = 30;
        private int numarDePersoane;

        public decimal totacCostF;
        public void OptiuneaEco(bool eco)
        {
            if (eco == true)
                CostBauturaPersoana = 5.00M;
            else
                CostBauturaPersoana = 20.00M;
        }
        public void OptiuniCina(int persoane, bool artificii)
        {
            numarDePersoane = persoane;
            CalculCostDecoratii(artificii);
        }
        public int GetNumarDePersoane()
        {
            return numarDePersoane;
        }
        public void CalculCostDecoratii(bool artificii)
        {
            if (artificii)
                CostDecoratii = NumarDePersoane * 15 + 50;
            else
                CostDecoratii = NumarDePersoane * 10 + 30;
        }
        public decimal CalculareCost(bool eco)
        {
            decimal totalCost = CostDecoratii + ((CostBauturaPersoana + CostMincarePersoana) *
               NumarDePersoane);
            totacCostF = totalCost;
            if (eco)
                return totalCost * 0.95M;
            else
                return totalCost;
        }
    }
}
