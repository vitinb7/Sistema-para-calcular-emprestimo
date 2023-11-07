using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("SEJA BEM VINDO COLABORADOR");
        Console.WriteLine();
        Console.WriteLine("Vamos começar com a simulação do seu empréstimo, para isso vou precisar dos seus dados!");
        Console.WriteLine();
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Digite a data de admissão no formato DD-MM-AAAA:");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime datadeadmissao))
        {
            DateTime dataAtual = DateTime.Today;

            if (dataAtual >= datadeadmissao.AddYears(5))
            {

            }
            else
            {
                Console.WriteLine("Agradecemos seu interesse, mas você não atende os requisitos mínimos do programa.");
                return;
            }
        }
        Console.WriteLine();
        Console.WriteLine("Digite seu salário atual:");
        float salario = float.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Digite o valor do empréstimo:");
        float emprestimo = float.Parse(Console.ReadLine());
        Console.WriteLine();
        if (emprestimo <= (salario * 2) && emprestimo % 2 == 0)
        {


        }
        else
        {
            while(emprestimo > salario * 2 || emprestimo % 2 != 0)
            {
                Console.WriteLine("Insira um valor válido!");
                emprestimo = float.Parse(Console.ReadLine());
            }
        }
        int opcao;
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Notas de maior valor");
        Console.WriteLine("2 - Notas de menor valor");
        Console.WriteLine("3 - Notas meio a meio");
        Console.WriteLine("");
        opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                MostrarNotasDeMaiorValor(emprestimo);
                break;
            case 2:
                MostrarNotasDeMenorValor(emprestimo);
                break;
            case 3:
                MostrarMetadeEMetade(emprestimo);
                break;
        }
        
        Console.ReadKey();

        static void MostrarNotasDeMaiorValor(float valor)
        {
            int notas100 = (int)(valor / 100);    // (int) é Conversão explícita ou "casting" 
            int notas50 = (int)((valor % 100) / 50);

            Console.WriteLine("Notas de maior valor:");
            Console.WriteLine(" {0} x 100 reais", notas100);
            Console.WriteLine(" {0} x 50 reais", notas50);
        }
    }
    static void MostrarNotasDeMenorValor(float valor)
    {
        int notas20 = (int)(valor / 20); 
        valor %= 20; 

        int notas10 = (int)(valor / 10); 
        valor %= 10; 

        int notas5 = (int)(valor / 5);

        int notas2 = (int)(valor / 2);

        Console.WriteLine("Notas de menor valor:");
        Console.WriteLine();
        Console.WriteLine(" {0} x 20 reais", notas20);
        Console.WriteLine(" {0} x 10 reais", notas10);
        Console.WriteLine(" {0} x 5 reais", notas5);
        Console.WriteLine(" {0} x 2 reais", notas2);

    }
    static void MostrarMetadeEMetade(float valor)
    {
        float metade = valor / 2;

        int notas100metade = (int)(metade / 100);
        int notas50metade = (int)((metade % 100) / 50);
        int notas20metade = (int)((metade % 50) / 20);
        int notas10metade = (int)((metade % 20) / 10);
        int notas5metade = (int)((metade % 10) / 5);



        Console.WriteLine("{0} reais em notas de maior valor:", metade);
        Console.WriteLine();
        Console.WriteLine(" {0} x 100 reais", notas100metade);
        Console.WriteLine(" {0} x 50 reais", notas50metade);
        Console.WriteLine(" {0} x 20 reais", notas20metade);
        Console.WriteLine(" {0} x 10 reais", notas10metade);
        Console.WriteLine(" {0} x 5 reais", notas5metade);

        int notas20restantes = (int)((valor - metade) / 20);
        int notas10restantes = (int)(((valor - metade) % 20) / 10);
        int notas5restantes = (int)(((valor - metade) % 10) / 5);
        int notas2restantes = (int)(((valor - metade) % 5) / 2);

        Console.WriteLine("{0} reais em notas de menor valor:", metade);
        Console.WriteLine();
        Console.WriteLine(" {0} x 20 reais", notas20restantes);
        Console.WriteLine(" {0} x 10 reais", notas10restantes);
        Console.WriteLine(" {0} x 5 reais", notas5restantes);
        Console.WriteLine(" {0} x 2 reais", notas2restantes);

    }
}