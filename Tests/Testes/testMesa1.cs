using System;
public class tMesa1 {
    public static void um(){
         int a = 10;
         int b = 20;
         int c = (a + b) / 2;
         c = c - 40;
         int[] v = new int[4];
         v[3] = a + b + c;

            for (int i = 0; i < 4; i++){
                if(v[i] == 5){
                    Console.WriteLine($"O vetor na posição V[i] é == 5");
                } else{
                    Console.WriteLine($"O vetor na posição V[i] não é == 5");
             }
         }
    }

    public static void dois(){
        int a = 2;
        int[] v = new int[5];
        
            for(int i=0; i<v.Length; i++ ){
                v[i] = 10 * a;
                a++;
                Console.WriteLine($"V[{i}] = {v[i]}");
        }
    }  

    public static void tres(){
        int a = 7;
        int b = a - 6;
        int[] v = new int [6];
        
          while(b < a){
            v[b] = b + a;
            Console.WriteLine($"V[{b}] = {v[b]}");
            b = b + 2;
        }
    }  
}