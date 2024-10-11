using System;

public class tMesa2 {
    public static void um(){
        double f , v;
        double valorPresente = 1000;
        double taxaJuros = 0.053;
        int periodoMes = 10;
        double valorTaxa = 1 + taxaJuros;
        
        v = Math.Pow(valorTaxa, periodoMes);
        f = valorPresente * v;
        Console.WriteLine($"Valor futuro: {f:F2}");
    }

    public static void dois(){
        double f, valorPresente = 3600.00, taxaJuros = 0.0125;
        int periodoMes = 6;
        double[] valoresMeses= new Double[periodoMes];
        double valorTaxa = 1 + taxaJuros;
        

        for (int i = 1; i <= periodoMes ; i++){
            f = valorPresente * Math.Pow(valorTaxa, periodoMes);
            valoresMeses[i] = f;
            Console.WriteLine ($"Rendimento no {i}º mês= {valoresMeses[i]:F2}");
        }
    }

    public static void tres(){
        double valorPresente, taxaJuros, valorFinal, valorTaxa;
        int periodoMes;

        Console.WriteLine("Digite o valor presente: ");
        valorPresente = double.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Digite a taxa de juros: ");
        taxaJuros = double.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Digeite o periodo: ");
        periodoMes = int.Parse(Console.ReadLine() ?? "0");
        valorTaxa = taxaJuros + 1;
        

        valorFinal = valorPresente * Math.Pow(valorTaxa, periodoMes);
        Console.WriteLine($"Valor do rendimento: {valorFinal:F2}");
    }

    public static void quatro(){
        double valorPresente = 2000;
        double taxaJuros = 0.020;
        double valorFinal;
        double saque = 1000;
        double[] valoresMeses = new double[6];
        double valorTaxa = 1 + taxaJuros;

        Console.WriteLine("Digite o valor presente: ");
        valorPresente = double.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Digite a taxa de juros (em decimal): ");
        taxaJuros = double.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Digeite o periodo: ");
        valorTaxa = taxaJuros + 1;

        for(int i = 1 ; i <= 6 ; i++){
            valoresMeses[i] = Math.Pow(valorTaxa, i);
            if(i == 5){
                valorFinal = valorPresente * valoresMeses[i];
                valorFinal = valorFinal - saque;
                Console.WriteLine($"Valor no {i}º mes após saque: {valorFinal:F2}");
            } else {
                valorFinal = valorPresente * valoresMeses[i];
                Console.WriteLine($"Valor após {i}º mes: {valorFinal:F2}");
            }
        }
    }

    public static void cinco(){
        double valorPresente, valorTaxa, valorFinal = 7390.61;
        
        Console.WriteLine("Digite a taxa de juros (em decimal): ");
        double taxaJuros = double.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Digeite o periodo (em meses): ");
        int periodoMes = int.Parse(Console.ReadLine() ?? "0");
        valorTaxa = taxaJuros + 1;
        
        valorPresente = valorFinal / Math.Pow(valorTaxa, periodoMes);
        Console.WriteLine($"O valor inicial investido: {valorPresente:F2}");
    }
}