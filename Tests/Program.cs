
﻿using System;
using calculadoraInvestimentos;

class Program{

    static void Main(){
        //Cria um menu simples para navegação entre os testes.
        Console.WriteLine("Teste de mesa. Digite a opção desejada:" +
        "\nTeste Mesa 1"+
        "\n1) 1º teste" +
        "\n2) 2º teste"+
        "\n3) 3º teste"+
        "\nTeste Mesa 2" +
        "\n4) 1º teste"+
        "\n5) 2º teste"+
        "\n6) 3º teste"+
        "\n7) 4º teste"+
        "\n8) 5º teste"+
        "\nTeste Mesa 3"+
        "\n9) 1º teste"+
        "\n10) 2º teste"+
        "\n11) 3º teste"+
        "\nDigite a opção: ");

        //lê a entrada do teclado e a converte para int32
        int index = Convert.ToInt32(Console.ReadLine());

        //Define que código executar a depender da entrada.
        switch(index){
            case 1:
                tMesa1.um();
                break;

            case 2:
                tMesa1.dois();
                break;

            case 3:
                tMesa1.tres();
                break;
            case 4:
                tMesa2.um();
                break;

            case 5:
                tMesa2.dois();
                break;

            case 6: 
                tMesa2.tres();
                break;

            case 7:
                tMesa2.quatro();
                break;

            case 8:
                tMesa2.cinco();
                break;

            case 9:
                tMesa3.um();
                break;

            case 10:
                tsMesa3.dois();
                break;

            case 11:
                tsMesa3.tres();
                break;

        }

    }
}