using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROVA_DE_SUFICIENCIA.Entities
{
    public class Empresa
    {
        public List<Passageiro> getPassageirosMaisVelhos(List<Passageiro> passageiros)
        {
            return passageiros.Where(x => x.Idade >= 60).ToList();
        }
    }
}
