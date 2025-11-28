int total, contadorParaMim, contadorParaVoce, restante, picaPau, raposinha;

Console.WriteLine("--- Esperto Contra Sabido ---\n");

Console.Write("Quantos alimentos serão distribuídos? ");
total = Convert.ToInt32(Console.ReadLine());

if (total <= 0) return;

Console.WriteLine();

restante = total;
picaPau = 0;
raposinha = 0;

contadorParaVoce = 0;
contadorParaMim = 0;

while (restante > 0)
{
    ContadorPicaPau();

    while (restante > 0 && contadorParaMim < contadorParaVoce)
    {
        ContadorRaposinha();
    }
    
     if (contadorParaMim > 0)
    {
        Console.WriteLine("para mim.");
    }


}

if (contadorParaMim == 0)
{
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine($"Pica-pau recebeu {picaPau} alimento(s).");
Console.WriteLine($"Raposinha recebeu {raposinha} alimento(s).");

void ContadorPicaPau(){
    contadorParaVoce++;
    picaPau += 1;
    restante -= 1;

    Console.Write($"{picaPau} para você. ");
    contadorParaMim = 0;

}

void ContadorRaposinha(){

        contadorParaMim++;
        raposinha += 1;
        restante -= 1;
        
        Console.Write($"{contadorParaMim}");

        if (restante > 0 && contadorParaMim < contadorParaVoce)
        {
            Console.Write(",");
        }

        Console.Write(" ");
}