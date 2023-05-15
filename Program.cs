using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

/*Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);
*/
Reserva reserva = new Reserva();
List<Pessoa> pessoa=new List<Pessoa>();


// Cria a suíte
Suite suite = new Suite();
reserva.CadastrarSuite(suite);

// Cria uma nova reserva, passando a suíte e os hóspedes
reserva.CadastrarHospedes(pessoa);

// Exibe a quantidade de hóspedes e o valor da diária
reserva.ObterQuantidadeHospedes();
reserva.CalcularValorDiaria();
