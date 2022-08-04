using Bogus;
using PROVA_DE_SUFICIENCIA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class PassageiroFaker : Faker<Passageiro>
    {
        public PassageiroFaker()
        {
            RuleFor(p => p.Nome, f => f.Person.FullName);
            RuleFor(p => p.Telefone, f => f.Person.Phone);
            RuleFor(p => p.Idade, new Random().Next(1,100));
            RuleFor(p => p.TarifaInteira, 6);
        }

    }
}
