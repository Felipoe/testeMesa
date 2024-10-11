using System;
namespace calculadoraInvestimentos{

    class tMesa3(){
        public static void um(){
            int mes = 8, dia = 10;
            
   
            Console.Write("Digite o valor presente: ");
            double valorPresente = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a taxa de juros (em decimal): ");
            double taxaJuros = (Convert.ToDouble(Console.ReadLine()));
            double meses = mes + (dia/30.0);
            double valorTaxa = taxaJuros + 1;
            double rendimento = valorPresente * Math.Pow(valorTaxa, meses);
            Console.WriteLine($"O rendimento após {mes} meses e {dia} dias será de {rendimento:C2}");
        }
    }
    class tsMesa3{
        public static void dois(){
            double valorPresente, taxaJuros, resgate;
            int periodoMes;

            Console.WriteLine("Investimento com resgate");
            Console.Write("Digite o valor presente: ");
            valorPresente = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a taxa de juros (em decimal): ");
            taxaJuros = (Convert.ToDouble(Console.ReadLine()));
            Console.Write("Digite o periodo de investimento: ");
            periodoMes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o valor de resgate: ");
            resgate = Convert.ToDouble(Console.ReadLine());
            calculadoraInvestimento calculadora = new calculadoraInvestimento(valorPresente, taxaJuros, resgate);

            Console.WriteLine("\nResultados:");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            Console.WriteLine("| Mês   |   Rendimento   | Resgate Parcial | Valor Final | Rendimento Restante | Saldo Restante |");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

            for (int i = 1; i <= periodoMes; i++){
                double rendimento = calculadora.rendimentoMensal();
                double valorFinal = calculadora.saldoLiquido(i);

                if (i == 5){
                    valorFinal = valorFinal - resgate;
                    rendimento = rendimento - resgate;
                }
                Console.WriteLine($"| {i,-5} | {rendimento,-14:C2} | {(i == 5 ? resgate : 0),-15:C2} | {valorFinal,-13:C2} | {(i == 5 ? rendimento : calculadora.rendimentoRestante(i + 1)), -19:C2} | {(i == 5 ? valorFinal + rendimento : calculadora.saldoRestante(i + 1)), -14:C2} |");
            }
            
        }
        public static void tres(){
        {
            Console.WriteLine("Investimento com resgate de rendimentos");
            Console.Write("Digite o valor presente: ");
            double valorPresente = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a taxa de juros (em decimal): ");
            double taxaJuros = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o período de investimento: ");
            int periodoMeses = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o valor de resgate: ");
            double resgate = Convert.ToDouble(Console.ReadLine());

            calculadoraInvestimento calculadora = new calculadoraInvestimento(valorPresente, taxaJuros, resgate);

            Console.WriteLine("\nResultados:");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("| Valor Inicial | Taxa de Juros | Rendimento   | Período | Resgate  | Valor Final |");
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            for (int i = 1; i <= periodoMeses; i++)
            {
                double rendimento = calculadora.rendimentoMensal();
                double saldoLiquido = calculadora.saldoLiquido(i);
                double saldoRestante = calculadora.saldoRestante(i);

                if (i == 5)
                {
                    saldoLiquido -= resgate;
                }

                Console.WriteLine($"| {valorPresente,-16:C2} | {taxaJuros ,-12:P0} | {rendimento,-12:C2} | {i,-14} | {(i == 5 ? resgate : 0),-8:C2} | {saldoLiquido,-13:C2} |");
            }
            Console.WriteLine("-------------------------------------------------------------------");
        }
    }
    class calculadoraInvestimento{
        private double valorPresente;
        private double taxaJuros;
        private double resgate;

        public calculadoraInvestimento (double valorPresente, double taxaJuros, double resgate){
            this.valorPresente = valorPresente;
            this.taxaJuros = taxaJuros;
            this.resgate = resgate;
        }

        public double rendimentoMensal(){
            return valorPresente * taxaJuros;
        }

        public double saldoLiquido(int meses){
            double rendimentoTotal = 0;
                for (int i =0; i <= meses; i++){
                    rendimentoTotal += valorPresente * taxaJuros;            
                }
            return valorPresente + rendimentoTotal;
        }

        public double rendimentoRestante(int meses){
            double rendimentoTotal = 0;
            for (int i = 1; i<= meses; i++){
                rendimentoTotal += valorPresente *taxaJuros;
            }
            return rendimentoTotal - resgate;
        }

        public double saldoRestante(int meses){
            double rendimentoTotal = 0;
            for (int i = 1; i<= meses; i++){
                rendimentoTotal += valorPresente*taxaJuros;
            }
            return valorPresente + rendimentoTotal - resgate;
        }

    }
    }
}