public class AlertaVermelho : Alerta
{
    public override void ExibirAlerta()
    {
        Console.WriteLine("ALERTA VERMELHO");
        Console.WriteLine("Cuidado!!! Região com alto risco de furto cruzando o horario com sua velocidade!!!");
        Console.WriteLine("Recomendado guardar seu pertences(Especialmente o celular)");
    }
}