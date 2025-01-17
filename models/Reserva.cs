using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_C_2.models
{
    public class Reserva
    {


        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }
        public double Valor { get; set; }


        public Reserva() { }
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }


        public void CadastrarHospedes(List<Pessoa> hospedes)
        {

                if (Suite.Capacidade >= hospedes.Count)
                {
                    Hospedes = hospedes;
                }

                else
                {
                    throw new Exception("A quantidade de hóspedes não pode exceder a capacidade da suíte");
                }

        }


        public void CadastrarSuite(Suite suite)
        {

            Suite = suite;
        }

        public int QuantidadeDeHospedes()
        {
            int Quantidade = Hospedes.Count;
            return Quantidade;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valor = valor * 0.90M;
            }

            return valor;

        }

       
    }
}