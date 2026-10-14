public class Monitoramento
{
    public void SimularMonitoramento()
    {
        int opcao;

        do
        {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("         Monitoramento         ");
            Console.WriteLine("===============================");

            // Pergunta a localização
            Console.Write("Onde você está? ");
            string local = Console.ReadLine()!;

            // Pergunta a velocidade
            Console.Write("Qual a velocidade do veículo (km/h)? ");
            int velocidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Local: " + local);
            Console.WriteLine("Velocidade:" + velocidade + "km/h");
            Alerta alerta;
            // Verifica a velocidade e exibe o alerta
            if (velocidade > 80)
            {
                alerta = new Alerta();
            }
            else if (velocidade > 40)
            {
                alerta = new AlertaAmerelo();
            }
            else
            {
                alerta = new AlertaVermelho();
            }
            alerta.ExibirAlerta();
            Console.WriteLine("\n===============================");
            Console.WriteLine("1 - Monitorar novamente");
            Console.WriteLine("0 - Sair do monitoramento");
            Console.Write("\nEscolha uma opção: ");
            opcao = Convert.ToInt32(Console.ReadLine());
        } while (opcao != 0);
        }
    }