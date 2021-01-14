using Domain;
using System;
using System.Threading.Tasks;

namespace Service
{
    public class TaxaJurosService
    {
        public async Task<TaxaJuros> RetornaTaxaJuros()
        {
            TaxaJuros tx = new TaxaJuros { TaxaDeJuros = 0.01m };
            return tx;
        }
    }
}
