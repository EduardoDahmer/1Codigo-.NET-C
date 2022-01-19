using System;

 class minhaClasse 
 {
        static void Main(string[] args) {
            //continue a solucao com a insercao da variavel corretamente
            int A;
            int B;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            if (A % B  == 0 || B % A == 0) {
                Console.WriteLine("Sao Multiplos");
            }else{
                Console.WriteLine("Nao sao Multiplos");
            }
            
        }
    }
