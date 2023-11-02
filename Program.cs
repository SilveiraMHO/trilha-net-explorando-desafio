using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa personOne = new Pessoa(nome: "João", sobrenome: "Almeida");
Pessoa personTwo = new Pessoa(nome: "Carlos", sobrenome: "Pereira");
Pessoa personThree = new Pessoa(nome: "Ana Beatriz", sobrenome: "Machado");

hospedes.Add(personOne);
hospedes.Add(personTwo);
hospedes.Add(personThree);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine("Hóspedes:");
Console.WriteLine("--------------------------");
foreach (Pessoa hospede in hospedes)
{
    Console.WriteLine($"> {hospede.NomeCompleto}");
}
Console.WriteLine("--------------------------");
Console.WriteLine($"Total de hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria():C}");