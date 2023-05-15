namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Reserva(Suite suite) 
        {
            this.Suite = suite;
   
        }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }
    
        public Reserva() { }

        public Reserva(int diasReservados)
        {
           
            DiasReservados = diasReservados;
        }
     int quantidade=0;
     Pessoa pessoa=new Pessoa();
     Suite suite=new Suite();
       
    
    public void CadastrarHospedes(List<Pessoa> hospede)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
          try{
                Console.WriteLine("Digite a quantidade de hóspedes que deseja cadastrar:");
                quantidade = int.Parse(Console.ReadLine());
                    int qtd=0;

                foreach (Pessoa pessoa1 in hospede) 
                {                    
                        Console.WriteLine($"Digite O nome do {qtd+1} Hospede");
                        pessoa1.Nome = Console.ReadLine();
                        Console.WriteLine($"Digite O Sobrenome do {qtd+1} Hospede");
                        pessoa1.Sobrenome= Console.ReadLine();
                        qtd++;
                        hospede.Add(pessoa1);

                }
                Console.WriteLine("Digite quantos dias ira ficar Hospedado:");
                DiasReservados = int.Parse(Console.ReadLine());
                
                  foreach (Pessoa pessoa1 in hospede )
                {
                   Console.WriteLine($"Hospede: {pessoa1.NomeCompleto}");

                }}

                
                
            
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTE AQUI*
 
          catch(Exception e)
           {
            Console.WriteLine(" Erro no Cadastro de hospede "+e.Message);
           } }
 public void CadastrarSuite(Suite suite)
        {
            
        
           try
           {
            
            Console.WriteLine($"1 - Suite Casal");
            Console.WriteLine($"2 - Suite Solteiro");
            Console.WriteLine($"3 - Suite Stander");
            Console.WriteLine($"4 - Suite Master");
            Console.WriteLine("Escolha Suite voce deseja.");
            int escolha= int.Parse(Console. ReadLine());
            if(quantidade <=2 && escolha==1){
                suite.TipoSuite="Suite Casal";
                    Console.WriteLine(suite.TipoSuite);
                } else if(quantidade==1 && escolha==2){
                    suite.TipoSuite="Suite Solteiro";
                    Console.WriteLine(suite.TipoSuite);
                }else if(quantidade<=3 && escolha== 3){
                    suite.TipoSuite="Suite Stander";
                    Console.WriteLine(suite.TipoSuite);
                }else if(quantidade <= 5 && escolha==4){
                    suite.TipoSuite="Suite Master";
                    Console.WriteLine(suite.TipoSuite);
                }else
                {
                    Console.WriteLine("Não foi possivel Selecionar a suite, o numero Hospede excedeu:");
                    
                }  
                
        }catch(Exception e)
           {
            Console.WriteLine("Não foi possivel Selecionar a suite: try_Catch "+e.Message);
           }}
        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            
            Console.WriteLine($"A quantidade de Hospede é {quantidade}");
            return quantidade;
        }

        public decimal CalcularValorDiaria()
        {
            Suite suite=new Suite();
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor=0;
            suite.ValorDiaria = 100m;
            Console.WriteLine($"Valor diaria: R${suite.ValorDiaria}");
            valor = DiasReservados * suite.ValorDiaria;
            Console.WriteLine($"dias reservado: R${DiasReservados}");

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados >= 10)
            {
                decimal desconto =  valor * 0.1m;
                 valor = valor - desconto;
                Console.WriteLine($"Valor desconto: R${desconto}");
            }else
            {
               Console.WriteLine($"Valor total da reserva: R${valor}");
            }

            return valor;
        }
    }
}