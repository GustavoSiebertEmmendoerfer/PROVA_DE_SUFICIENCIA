using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROVA_DE_SUFICIENCIA.Entities
{
    public class Intermunicipal : Viagem
    {
        public Intermunicipal(string placaOnibus, string nomeMotorista, DateTime dataViagem, TimeOnly horaViagem) : base(placaOnibus, nomeMotorista, dataViagem, horaViagem)
        {
        }
        public override void AddPassageiro(Passageiro passageiro)
        {
            if (Passageiros.Count() == 35)
            {
                throw new ArgumentException("Limite de 35 passageiros atingido");
            }
            base.AddPassageiro(passageiro);
        }
        public float GetValorTotal()
        {
            return Passageiros.Select(x => x.GetTarifa() + 3.95f).Sum();
        }
    }
}
