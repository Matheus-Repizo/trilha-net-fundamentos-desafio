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
            Console.WriteLine("Digite a placa do veículo para estacionar:"); // Apresenta no console a mensagem para o Usuário digitar a placa do Veiculo.
            string placaVeiculo = Console.ReadLine(); // Realiza a leitura do input gerado pelo Usúario e atribui o valor a variavel do tipo String placaVeiculo.

            // Realiza validações, 
            if (placaVeiculo.Length > 7) // Verifica se a placa fornecida tem mais de 7 caracteres.
            {
                Console.WriteLine($"Digite uma placa válida, você digitou uma placa com {placaVeiculo.Length} caracteres!"); // Apresenta um alerta ao usuário no console.
            }
            else if (veiculos.Any(x => x.ToUpper() == placaVeiculo.ToUpper())) // Verifica se a placa já existe cadastrada na Lista veiculos.
            {
                Console.WriteLine($"A placa {placaVeiculo} já esta cadastrada no sitema!"); // Apresenta um alerta ao usuário no console.
            }
            else
            {
                veiculos.Add(placaVeiculo); // Se nenhuma validação anterior for verdadeira, adiciona a placa na Lista Veiculos.
            }
        }
        public void RemoverVeiculo()
        {
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            Console.WriteLine("Digite a placa do veículo para remover:"); // Apresenta no console a mensagem para o Usuário digitar a placa do Veiculo.
            string placa = Console.ReadLine(); // Realiza a leitura do input gerado pelo Usúario e atribui o valor a variavel do tipo String placa.

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))

            {
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                int horas = Convert.ToInt32(Console.ReadLine()); /*Realiza a leitura do input gerado pelo Usúario , 
                                                                    converte o valor de string para inteiro e atribui o mesmo a variavel do tipo int inteiro.*/
                decimal valorTotal = precoInicial + (precoPorHora * horas); // Realiza o cálculo do valor a ser cobrado pelo tempo que o veiculo permaneceu estacionado.


                // TODO: Remover a placa digitada da lista de veículos

                veiculos.Remove(placa); // Faz a remoção da placa na Lista veiculos.

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}"); // Apresenta a mensagem no console com a validação da remoção da placa e o valor a ser pago.
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente"); // Apresenta uma mensagem caso o veiculo não conste na Lista Veiculo.
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:"); // Apresenta uma mensagem no console se houver veiculos estacionados.
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados.
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo); // Apresenta no console todos os veiculos existente na Lista veiculos.
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados."); // Apresenta uma mensagem no console se não houver veiculos estacionados.
            }
        }
    }
}
