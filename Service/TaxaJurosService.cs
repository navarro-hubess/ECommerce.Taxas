using Domain;
using System;
using System.Threading.Tasks;

namespace Service
{
    public class TaxaJurosService
    {
        public async Task<decimal> RetornaTaxaJuros()
        {
            return new TaxaJuros().TaxaDeJuros;
        }
    }
}
