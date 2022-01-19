using System;

 class minhaClasse 
 {
        static void Main(string[] args) {
            //continue a solucao com a insercao da variavel corretamente
            Console.WriteLine("Digite dois números para descobrir se eles são múltiplos!");
            Console.WriteLine("");
            Console.WriteLine("Digite o primeiro número: ");
            int A;
            int B;
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Agora, digite o segundo número: ");
            B = int.Parse(Console.ReadLine());

            if (A % B  == 0 || B % A == 0) {
                Console.WriteLine(" Os números digitados são múltiplos");
            }else{
                Console.WriteLine(" Os números digitados não são múltiplos");
            }
            
        }
    }
