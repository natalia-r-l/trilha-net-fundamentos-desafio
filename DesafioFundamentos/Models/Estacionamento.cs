namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            Console.WriteLine("Digite a placa do veículo para estacionar:");

            // MINHA RESOLUÇÃO: Uso do método Readline para armazenar o valor que o usuário digitou como placa do veículo.
            string placa = Console.ReadLine();

            // MINHA RESOLUÇÃO: Uso do método Add para adicionar o valor informado pelo usuário na lista "veículos".
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // TODO: Pedir para o usuário digitar a placa e armazenar na variável placa
            
            
            // MINHA RESOLUÇÃO: Uso do método ReadLine para armazenar o valor que o usuário digitou como placa do veículo. 
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,                            

                // MINHA RESOLUÇÃO: Utiliza o Readline, e o Convert para armazenar o total de horas que o usuário digitou
                int horas = Convert.ToInt32(Console.ReadLine());               

                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal

                // MINHA RESOLUÇÃO: Realiza o cálculo de "precoInicial + precoPorHora * horas"
                
                decimal valorTotal = precoInicial + (precoPorHora * horas);

                // TODO: Remover a placa digitada da lista de veículos              

                // MINHA RESOLUÇÃO: Utiliza o método Remove para remover a placa informada pelo usuário da lista "veículos".
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados                

                // MINHA RESOLUÇÃO: Optei por usar o For como laço de repetição, ao invés do Foreach, pois queria exibir uma contagem de carros junto da lista de carros estacionados. 

                for (int contador = 0; contador < veiculos.Count; contador++)
                {
                    Console.WriteLine($"Veículo nº {contador + 1} - {veiculos[contador]}");
                }
                
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
