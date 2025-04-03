using System.Security.Cryptography.X509Certificates;

namespace Sistema_Veiculos
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Veiculo> Lista= new List<Veiculo>();
            try
            {
                Console.WriteLine("-------Locadora de veículos-------");

                Console.WriteLine("Qual nome do veículo que deseja alugar?");
                string modelo = Console.ReadLine();

                Console.WriteLine("Qual a marca?");
                string marca = Console.ReadLine();

                Console.WriteLine("Qual o ano?");
                int ano = int.Parse(Console.ReadLine());

                Console.WriteLine("Por quantos dias deseja alugar?");
                int dias = int.Parse(Console.ReadLine());

                Console.WriteLine("""
                Qual é o tipo do veículo?
                1 - Carro
                2 - Moto
                3 - Caminhão
                """);
                int op = int.Parse(Console.ReadLine());

                decimal diaria = 0;
            
            switch (op)
            {
                case 1:
                    Veiculo veiculo = new Carro(modelo, marca, ano, dias );
                    Console.WriteLine("Diária de 499,99 R$");
                        Lista.Add(veiculo);
                        diaria = 499.99m;
                        break;
                case 2: 
                    Veiculo veiculoMoto = new Moto(modelo, marca, ano, dias );
                    Console.WriteLine("Diária de 399,00 R$");
                        Lista.Add(veiculoMoto);
                        diaria = 399.00m;
                    break;
                case 3:
                    Veiculo veiculoCaminhao = new Caminhao(modelo, marca, ano, dias );
                    Console.WriteLine("Diária de 1,500 R$");
                        Lista.Add(veiculoCaminhao);
                        diaria = 1.500m;
                    break;
                default:
                    Console.WriteLine("Opção invalida!");
                    break;
            }


            foreach (Veiculo veiculo in Lista)
            {
                Console.WriteLine($" Modelo: {veiculo.Modelo}\n Marca: {veiculo.Marca}\n Ano: {veiculo.Ano}\n Dias alugados: {veiculo.Dias}\n Total: {veiculo.Calculardiaria(diaria,dias):F2} R$");
            }
           
           } catch (Exception ex)
            {
                Console.WriteLine(ex.Message, "Erro!");
            }
            
           
        }

       
    }
}
