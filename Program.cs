﻿using System.Text;
using projeto_C_2.models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        // Cria os modelos de hóspedes e cadastra na lista de hóspedes
        List<Pessoa> hospedes = new List<Pessoa>();

        Pessoa p1 = new Pessoa(nome: "Hóspede 1");
        Pessoa p2 = new Pessoa(nome: "Hóspede 2");

        hospedes.Add(p1);
        hospedes.Add(p2);

        // Cria a suíte
        Suite suite = new Suite(tipoSuite: "Premium", capacidade: 5, valorDiaria: 30);

        // Cria uma nova reserva, passando a suíte e os hóspedes
        Reserva reserva = new Reserva(diasReservados: 5);
        reserva.CadastrarSuite(suite);
        reserva.CadastrarHospedes(hospedes);

        // Exibe a quantidade de hóspedes e o valor da diária
        Console.WriteLine($"Hóspedes: {reserva.QuantidadeDeHospedes()}");
        Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
    }
}